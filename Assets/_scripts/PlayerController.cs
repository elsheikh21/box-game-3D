using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController :MonoBehaviour {

    private Rigidbody rb;
    public float speed = 10;

    //private bool isDead;
    //private bool isWin;

    void Start() {
        //isWin = false;
        //isDead = false;
        rb = GetComponent<Rigidbody>();
    }

    public void Kill() {
        //isDead = true;
        GameController.instance.Kill();
        Halt();
        return;
        //Hide();

    }

    public void Win() {
        //isWin = true;
        GameController.instance.Win();
        Hide();
        //Destroy( GameObject.FindGameObjectWithTag( "red" ) );
    }

    void FixedUpdate() {
        //if( isDead == false && isWin == false ) {
        float moveHorizontal = Input.GetAxis( "Horizontal" );
        float moveVertical = Input.GetAxis( "Vertical" );
        Vector3 movement = new Vector3( moveHorizontal, 0.0f, moveVertical );
        rb.transform.Translate( movement * Time.deltaTime * speed );
        //rb.AddForce( movement * speed * Time.deltaTime );
        if( IsRedThere() == true ) {
            if( GameObject.FindGameObjectWithTag( "player" ).transform.position.y < 0
                || GameObject.FindGameObjectWithTag( "red" ).transform.position.y < 0
                || GameObject.FindGameObjectWithTag( "red1" ).transform.position.y < 0 || GameObject.FindGameObjectWithTag( "red2" ).transform.position.y < 0
                || GameObject.FindGameObjectWithTag( "red3" ).transform.position.y < 0 || GameObject.FindGameObjectWithTag( "red4" ).transform.position.y < 0
                || GameObject.FindGameObjectWithTag( "red5" ).transform.position.y < 0 ) {
                    Halt();
                Kill();
            }
        }
        //}
    }
    void Hide() {
        if( IsRedThere() ) { 
        GameObject.FindGameObjectWithTag( "red1" ).SetActive( false );
        GameObject.FindGameObjectWithTag( "red2" ).SetActive( false );
        GameObject.FindGameObjectWithTag( "red3" ).SetActive( false );
        GameObject.FindGameObjectWithTag( "red4" ).SetActive( false );
        GameObject.FindGameObjectWithTag( "red5" ).SetActive( false );
        GameObject.FindGameObjectWithTag( "red" ).SetActive( false );
        }
    }

    void Halt() {
        if( GameObject.FindGameObjectWithTag( "player" ) != null ) { 
            GameObject.FindGameObjectWithTag( "player" ).SetActive( false );
        }
    }

    bool IsRedThere() {
        bool check1 = GameObject.FindGameObjectWithTag( "red" ) != null;
        bool check2 = GameObject.FindGameObjectWithTag( "red1" ) != null;
        bool check3 = GameObject.FindGameObjectWithTag( "red2" ) != null;
        bool check4 = GameObject.FindGameObjectWithTag( "red3" ) != null;
        bool check5 = GameObject.FindGameObjectWithTag( "red4" ) != null;
        bool check6 = GameObject.FindGameObjectWithTag( "red5" ) != null;
        bool check = check1 && check2 && check3 && check4 && check5 && check6;
        return check;
    }
}