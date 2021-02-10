using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
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
        if (fast)
        {
            SetSpeed(200f);
        }
        else
        {
            SetSpeed(200f);
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
            Debug.Log("it works ok");
        }

        if (collision.gameObject.tag == "carPrefab")
        {
            Destroy(gameObject);
            ScoreKeeper.playerScoreNum = ScoreKeeper.playerScoreNum + 2;
            ScoreKeeper.numPickupsInt++;
            if (ScoreKeeper.playerScoreNum > ScoreKeeper.playerHighScoreNum)
            {
                ScoreKeeper.playerHighScoreNum = ScoreKeeper.playerHighScoreNum +2;
            }
            Debug.Log("dead car");
        }

        if (collision.gameObject.tag == "pedestrianPrefab")
        {
            Destroy(gameObject);
            ScoreKeeper.numPickupsInt++;
            //RestartScene.gameTimer = RestartScene.gameTimer + 10.0f;
            Debug.Log("pickup working with ped");
        }

        if (collision.gameObject.tag == "pickupPrefab")
        {
            Destroy(gameObject);
        }
    }
}
