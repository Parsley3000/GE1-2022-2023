using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Transform brick;
    private float offset = 2.0f;
    // Start is called before the first frame update

    public static int score;

    public Text scoreDisplay;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(brick, new Vector3((i * offset) - 10, 0f, 8f), Quaternion.identity);
        }

        for (int i = 0; i < 10; i++)
        {
            Instantiate(brick, new Vector3((i * offset) - 10, 0f, 12f), Quaternion.identity);
        }

        for (int i = 0; i < 10; i++)
        {
            Instantiate(brick, new Vector3((i * offset) - 10, 2f, 12f), Quaternion.identity);
        }

    }

    private void Update()
    {
        
        scoreDisplay.text = score.ToString();
    
    }

}
