using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarScript : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool fast;
    public bool stopped;

    void FixedUpdate()
    {
        // face direction
        transform.rotation = Quaternion.LookRotation(direction);

        // set speed
        GetComponent<Rigidbody>().velocity = direction.normalized * speed * Time.deltaTime;

        if (PedestrianScript.roadRedBool)
        {
            if (fast)
            {
                SetSpeed(400f);
            }
            else
            {
                SetSpeed(300f);
            }
        } else if (PedestrianScript.roadYellowBool)
        {
            if (fast)
            {
                SetSpeed(500f);
            }
            else
            {
                SetSpeed(300f);
            }
        } else
        {
            if (fast)
            {
                SetSpeed(300f);
            }
            else
            {
                SetSpeed(150f);
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
        Debug.Log("Car Click!");
        fast = !fast;
        if (PedestrianScript.roadRedBool)
        {
            if (fast)
            {
                SetSpeed(400f);
            }
            else
            {
                SetSpeed(200f);
            }
        } else if (PedestrianScript.roadYellowBool)
        {
            if (fast)
            {
                SetSpeed(500f);
            }
            else
            {
                SetSpeed(300f);
            }
        } else
        {
            if (fast)
            {
                SetSpeed(300f);
            }
            else
            {
                SetSpeed(150f);
            }
        }

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SuccessBlock")
        {
            Destroy(gameObject);
            ScoreKeeper.playerScoreNum++;
            ScoreKeeper.numCardsInt++;
            if (ScoreKeeper.playerScoreNum > ScoreKeeper.playerHighScoreNum)
            {
                ScoreKeeper.playerHighScoreNum++;
            }
            Debug.Log("it works ok");
        }

        if (collision.gameObject.tag == "carPrefab")
        {
            Destroy(collision.gameObject);
            ScoreKeeper.playerScoreNum--;
            Debug.Log("dead car");
        }

        if (collision.gameObject.tag == "pedestrianPrefab")
        {
            Destroy(collision.gameObject);
            ScoreKeeper.playerScoreNum = 0;
        }
    }
}
