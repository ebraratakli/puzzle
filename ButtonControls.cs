using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControls : MonoBehaviour
{
    [Header("VolumeSetting")]
    [SerializeField] private TMP_Text volumeValueText = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultVolume = 1.0f;

    private void Start()
    {
        volumeSlider.onValueChanged.AddListener(SetVolume);
        SetVolume(defaultVolume);
    }
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeValueText.text = volume.ToString("0.0");
    }

    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
    }


    public void ResetButton()
    {

        AudioListener.volume = defaultVolume;
        volumeSlider.value = defaultVolume;
        volumeValueText.text = defaultVolume.ToString("0.0");
        VolumeApply();

    }
    public void FollowingLevel()
    {
        int afterSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (afterSceneIndex >= 0)
        {
            SceneManager.LoadScene(afterSceneIndex);
        }
    }

    public void StartingScene()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}