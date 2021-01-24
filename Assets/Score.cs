
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    private float scoreint;
    private int interval = 3;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);

        if (Time.frameCount % interval == 0)
        {
            scoreint = player.position.z + 4876;

            scoreText.text = scoreint.ToString("0");
        }


    }
}
