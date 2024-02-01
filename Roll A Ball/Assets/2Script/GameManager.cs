using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int totalItemCount;
    public int stage;
    public Text stageCountText;
    public Text playerCountText;

    private void Awake()
    {
        stageCountText.text = "/ " + totalItemCount.ToString();
    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(stage);
        }
    }
    public void Exit()
    {
        #if UNITY_EDITOR //unity editor �󿡼� ����
                UnityEditor.EditorApplication.isPlaying = false;
        #else // application ��ü�� ����
                Application.Quit();
        #endif
    }
}
