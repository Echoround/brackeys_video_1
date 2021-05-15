
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public ParticleSystem Game_end_particles;
    private bool GameHasEnded = false;
    public float restart_delay = 1f;

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void EndGame()
    {

        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("game over");

            Invoke("Restart", restart_delay);
        }

       


    }

}
