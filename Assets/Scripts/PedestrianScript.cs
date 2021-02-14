using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PedestrianScript : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool fast;
    public bool stopped;
    public float canWalk = 0;
    public static float currentSpeed;
    public static bool roadRedBool = false;
    public static bool roadYellowBool = false;

    void FixedUpdate()
    {
        // face direction
        transform.rotation = Quaternion.LookRotation(direction);

        // set speed
        GetComponent<Rigidbody>().velocity = direction.normalized * speed * Time.deltaTime;
        if (roadRedBool)
        {
            SetSpeed(0f);
        } else if (roadYellowBool) {
            SetSpeed(currentSpeed * 1.5f);
        } else
        {
            if (!fast)
            {
                if (RestartScene.gameTimer >= 45f)
                {
                    SetSpeed(100);
                    currentSpeed = 100;
                }
                else if (RestartScene.gameTimer <= 45f && RestartScene.gameTimer >= 25f)
                {
                    SetSpeed(120);
                    currentSpeed = 120;
                }
                else if (RestartScene.gameTimer <= 25f)
                {
                    SetSpeed(140);
                    currentSpeed = 140;
                }
            }
        }



    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
    }

    public void OnMouseDown()
    {
        Debug.Log("Walker Click!");
        fast = !fast;
        if (fast)
        {
            SetSpeed(0f);
        }
        else
        {
            SetSpeed(currentSpeed);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "carPrefab")
        {
            playerDeathManagerScript.playerDied = true;
            Destroy(collision.gameObject);
            Debug.Log("dead car");
        }

        if (collision.gameObject.tag == "changeDirection")
        {
            ScoreKeeper.playerScoreNum++;
            ScoreKeeper.numPedsInt++;
            if (ScoreKeeper.playerScoreNum > ScoreKeeper.playerHighScoreNum)
            {
                ScoreKeeper.playerHighScoreNum++;
            }
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "pedestrianPrefab")
        {
            Destroy(gameObject);
        }
    }
}
