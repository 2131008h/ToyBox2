using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] private bool unlocked;
    public Image unlockedImage;
    public GameObject[] stars;
    public Sprite starSprite;

    private void Update()
    {
        UpdateLevelImage();
        UpdateLevelStatus();
    }
    private void UpdateLevelStatus()
    {
        //���[�J���ϐ��̐ݒ�
        //�A�^�b�`���Ă���GameObject�̖��O�𐔎��ɂ���K�v����
        //���[�J���ϐ� =�i�A�^�b�`���Ă���GameObject�̖��O�̐����j-1
        int PreviousLevelNum = int.Parse(gameObject.name) - 1;
        //�f�[�^�̃��[�h���s��
        //���̐���1�ȏ�ł���Ύ��̃X�e�[�W���J��
        if (PlayerPrefs.GetInt("Lv" + PreviousLevelNum) > 0)
        {
            unlocked = true;
        }
    }

    private void UpdateLevelImage()
    {
        //�A�����b�N����Ă��Ȃ��Ȃ�X�e�[�W�̑I�𗗂�\�������Ȃ�
        if (!unlocked)
        {
            unlockedImage.gameObject.SetActive(true);
            //star[].gameObject.SetActive(false);
            for(int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(false);
            }
            
        }
        //�X�e�[�W���������Ă���Ȃ�
        else
        {
            unlockedImage.gameObject.SetActive(false);
            //star[].gameObject.SetActive(true);
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(true);
            }
            for(int i = 0; i < PlayerPrefs.GetInt("Lv" + gameObject.name); i++)
            {
                stars[i].gameObject.GetComponent<Image>().sprite = starSprite;
            }
        }
    }
    //�{�^����������public�œ��͂������O�̃V�[���ֈڂ�
    public void PressSelection(string _LevelName)
    {
        if (unlocked)
        {
            SceneManager.LoadScene(_LevelName);
        }
    }
    
}
