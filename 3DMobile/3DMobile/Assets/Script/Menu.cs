using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject resumeButton;
    [SerializeField] private GameObject GameUIPanel;
    [SerializeField] private GameObject ExitButton;
    [SerializeField] private GameObject SettingsButton;
    [SerializeField] private GameObject HintButton;
    [SerializeField] private GameObject MapButton;
    [SerializeField] private GameObject SettingPanel;
    [SerializeField] private GameObject SettingsExitButton;
    [SerializeField] private GameObject ExitButton2;
    void Start()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        GameUIPanel.SetActive(true);
        ExitButton.SetActive(false);
        SettingsButton.SetActive(false);
        HintButton.SetActive(false);
        MapButton.SetActive(false);
        SettingPanel.SetActive(false);
        pauseButton.GetComponent<Button>().onClick.AddListener(Pause);
        resumeButton.GetComponent<Button>().onClick.AddListener(Resume);
        ExitButton.GetComponent<Button>().onClick.AddListener(ExitGame);
        SettingsButton.GetComponent<Button>().onClick.AddListener(SettingsMenu);
        SettingsExitButton.GetComponent<Button>().onClick.AddListener(SettingsExit);
        ExitButton2.GetComponent<Button>().onClick.AddListener(SettingsExit);

        HintButton.GetComponent<Button>().onClick.AddListener(HintoMenu);
        MapButton.GetComponent<Button>().onClick.AddListener(MapView);
    }

    private void Pause()
    {
        Time.timeScale = 0;  // éûä‘í‚é~
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
        GameUIPanel.SetActive(false);
        ExitButton.SetActive(true);
        SettingsButton.SetActive(true);
        HintButton.SetActive(true);
        MapButton.SetActive(true);
    }

    private void Resume()
    {
        Time.timeScale = 1;  // çƒäJ
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        GameUIPanel.SetActive(true);
        ExitButton.SetActive(false);
        SettingsButton.SetActive(false);
        HintButton.SetActive(false);
        MapButton.SetActive(false);
    }
    private void ExitGame()
    {

    }
    private void SettingsMenu()
    {
        SettingPanel.SetActive(true);
        pausePanel.SetActive(false);
    }
    private void SettingsExit()
    {
        SettingPanel.SetActive(false);
        pausePanel.SetActive(true);
    }
    private void HintoMenu()
    {

    }
    private void MapView()
    {

    }
}
