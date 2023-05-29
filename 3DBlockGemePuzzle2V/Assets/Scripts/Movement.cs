using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    [SerializeField] KeyCode KeyOne;
    [SerializeField] KeyCode KeyTwo;
    [SerializeField] KeyCode KeyThree;
    [SerializeField] Vector3 MoveVector;
    [SerializeField] Vector3 MoveVector2;
    
    
    
        void FixedUpdate()
        {
            if(Input.GetKey(KeyOne)){GetComponent<Rigidbody>().velocity += MoveVector;}
            if(Input.GetKey(KeyTwo)){GetComponent<Rigidbody>().velocity -= MoveVector;}
            if(Input.GetKey(KeyThree)){GetComponent<Rigidbody>().velocity += MoveVector2;}
        }
    

        void OnTriggerEnter(Collider other){
            if(this.CompareTag("Player") && other.CompareTag("Finish")){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }


        }
}
