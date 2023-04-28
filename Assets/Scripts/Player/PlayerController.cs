using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 4f;
    private Animator animator;
    private Rigidbody2D rb;
    public LayerMask layer;


    // Start is called before the first frame update
    void Start()
    {   
     //transform.position = new Vector3(10,10,0);
        //Debug.Log("START");
    }

    
    void Awake (){
         rb = GetComponent<Rigidbody2D>();
         animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("walking", Input.GetButton("Horizontal") || Input.GetButton("Vertical"));
       if (Input.GetAxisRaw("Horizontal") > 0) {
                transform.localScale = new Vector3(1, 1, 1);
                transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        } 
        else if (Input.GetAxisRaw("Horizontal") < 0) {
                transform.localScale = new Vector3(-1, 1, 1);
                transform.Translate(Vector2.left * velocidade * Time.deltaTime);
            }

        if (Input.GetAxisRaw("Vertical") > 0) {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }else if (Input.GetAxisRaw("Vertical") < 0) {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
                
}
}