using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Collider_Control : MonoBehaviour
{
    public int collect = 0;
    public AudioClip sound1=null;
    public int m_Score = 0; // Removed the space
    public int GetScore { get => m_Score; }
    public TextMeshProUGUI m_TxtScore;

    public void AddNewScore(int score)
    {
        m_Score += score;
        // Update UI => txt Score
        if (m_TxtScore) m_TxtScore.text = "Score : " + m_Score;

         if (m_Score >= 10)
            {
                SceneManager.LoadScene(5);
            }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "star")
        {
            Destroy(col.gameObject);

            AudioSource.PlayClipAtPoint(sound1, col.transform.position);
            AddNewScore(1);
        }


        else if (col.gameObject.tag == "obstacle")
        {
            SceneManager.LoadScene(6);
        }
    }


}






