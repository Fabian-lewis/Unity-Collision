using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeJump : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public Rigidbody rb;

    public bool CubeOnGround = true;
    public int points = 0;
    public TextMeshProUGUI score_text;
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
       
        
    }

    // Update is called once per frame
   void Update()
    {

        if (Input.GetButtonDown("Jump") && CubeOnGround)
        {
            if(rb != null){
                rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            }
            CubeOnGround = false;
           
            //AddPoints(10);
            //UpdatePointsUI();
        }
        
    }
    public void OnCollisionEnter(Collision collision){
        CubeOnGround = true;
        points = points +1;
        print("Points = "+points);
        score_text.text = "Points: " + points.ToString();

       
    }
}
