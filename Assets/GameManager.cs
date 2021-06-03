
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public ParticleSystem Game_end_particles;
    private bool GameHasEnded = false;
    public float restart_delay = 1f;
    public Text crashedText;

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    private IEnumerator GameEndRoutine()
    {

        GameHasEnded = true;
        Debug.Log("game over");
        Time.timeScale = 0;
        yield return new WaitForSeconds(2);
        crashedText.enabled = true;

        Invoke("Restart", restart_delay);

    }

    public void EndGame()
    {

        if (GameHasEnded == false)
        {

            StartCoroutine(GameEndRoutine());
   
        }

       


    }

}
