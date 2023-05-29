using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode KeyOne;
    [SerializeField] KeyCode KeyTwo;
    [SerializeField] KeyCode Keyfre;
    [SerializeField] Vector3 MoveVector;
    [SerializeField] Vector3 MoveVector2;
    
    
        private void FixedUpdate()
        {
            if(Input.GetKey(KeyOne)){GetComponent<Rigidbody>().velocity += MoveVector;}
            if(Input.GetKey(KeyTwo)){GetComponent<Rigidbody>().velocity -= MoveVector;}
            if(Input.GetKey(Keyfre)){GetComponent<Rigidbody>().velocity += MoveVector2;}
        }
    

        void OnTriggerEnter(Collider other){
            if(this.ComparreTag("Player") && other.ComparreTag("Finish")){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }


        }
    
    
        
    
}
