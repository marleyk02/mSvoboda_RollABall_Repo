using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionScriptMaybe : MonoBehaviour
{
    Vector3 originalPos;
    public UnityEvent onHit;
    public float destroyTime;
    public GameObject Snowball;
    //Vector3 ballPosition = new Vector3(-2.317f, 2.124f, 3.666f);

    void Start()
    {
        originalPos = transform.position;
    }



    private void OnTriggerEnter()
    {
        transform.position = originalPos;
        //GameObject duplicate = Instantiate(Snowball);
        //StartCoroutine("RespawnBall");
        //onHit.Invoke();
        //Destroy(gameObject);
        //Snowball.SetActive(false);
        
    }

    //IEnumerator RespawnBall()
    //{
        
       //GameObject clone = (GameObject)Instantiate(Snowball, ballPosition, Quaternion.identity) as GameObject;
        
       // yield return null;
    //}

}
