using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpForrce;
    public GameObject SplashPre;
    private GameManager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up*JumpForrce);
        GameObject splash = Instantiate(SplashPre,transform.position+new Vector3(0f,-0.1f,0f),transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);
        string materialname = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        
        if (materialname== "PlatformMaterial (Instance)")
        {

        }
        else if (materialname== "MatPlatYedek (Instance)")
        {
            gm.RestartGame();
        }

        else if (materialname== "SonMat (Instance)")
        {
            gm.RestartGame();
        }
    }
}
