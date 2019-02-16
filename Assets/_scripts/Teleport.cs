using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport :MonoBehaviour {

    PlayerController pc = new PlayerController();

    private static int count = 0;
    
    void OnTriggerEnter(Collider other) {

        if( other.gameObject.CompareTag( "red" ) || other.gameObject.CompareTag( "red1" ) ) {
            if( GameObject.Find( "Orange (1)" ) != null ) {
                other.gameObject.transform.position = GameObject.Find( "Orange (1)" ).transform.position;
                GameObject.Find( "Orange (1)" ).SetActive( false );
            } else {
                other.gameObject.transform.position = GameObject.Find( "Orange (2)" ).transform.position;
                GameObject.Find( "Orange (2)" ).SetActive( false );
            }
            count = count + 1;
        }
        if( other.gameObject.CompareTag( "red2" ) || other.gameObject.CompareTag( "red3" ) ) {
            if( GameObject.Find( "Orange (3)" ) != null ) {
                other.gameObject.transform.position = GameObject.Find( "Orange (3)" ).transform.position;
                GameObject.Find( "Orange (3)" ).SetActive( false );
            } else {
                other.gameObject.transform.position = GameObject.Find( "Orange (4)" ).transform.position;
                GameObject.Find( "Orange (4)" ).SetActive( false );
            }
            count = count + 1;
        }
        if( other.gameObject.CompareTag( "red4" ) || other.gameObject.CompareTag( "red5" ) ) {
            if( GameObject.Find( "Orange (5)" ) != null ) {
                other.gameObject.transform.position = GameObject.Find( "Orange (5)" ).transform.position;
                GameObject.Find( "Orange (5)" ).SetActive( false );
            } else {
                other.gameObject.transform.position = GameObject.Find( "Orange (6)" ).transform.position;
                GameObject.Find( "Orange (6)" ).SetActive( false );
            }
            count = count + 1;
        }

        CheckWin();
    }
    
    void CheckWin() {
        if( count > 2 )
            pc.Win();
    }

}
/*

        if( other.gameObject.CompareTag( "red1" ) ) {
            if( Random.Range( 0, 2 ) < 1 ) {
                Debug.Log( "BAlabzo" );
                if( GameObject.Find( "Orange (1)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red1" ).transform.position = GameObject.Find( "Orange (1)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red1" ).transform.position = GameObject.Find( "Orange (2)" ).transform.position;
                }
            } else {
                if( GameObject.Find( "Orange (2)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red1" ).transform.position = GameObject.Find( "Orange (2)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red1" ).transform.position = GameObject.Find( "Orange (1)" ).transform.position;
                }
            }
            GameObject.FindGameObjectWithTag( "red1" ).transform.Translate( new Vector3( 0.0f, 0.0f, 0.0f ) );
            GameObject.Find( "Orange (1)" ).SetActive( false );
            GameObject.Find( "Orange (2)" ).SetActive( false );
            count++;
        }

        if( other.gameObject.CompareTag( "red2" ) ) {
            if( Random.Range( 0, 2 ) < 1 ) {
                if( GameObject.Find( "Orange (3)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red2" ).transform.position = GameObject.Find( "Orange (3)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red2" ).transform.position = GameObject.Find( "Orange (4)" ).transform.position;
                }
            } else {
                if( GameObject.Find( "Orange (4)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red2" ).transform.position = GameObject.Find( "Orange (4)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red2" ).transform.position = GameObject.Find( "Orange (3)" ).transform.position;
                }
            }
            GameObject.FindGameObjectWithTag( "red2" ).transform.Translate( new Vector3( 0.0f, 0.0f, 0.0f ) );
            GameObject.Find( "Orange (3)" ).SetActive( false );
            GameObject.Find( "Orange (4)" ).SetActive( false );
            count++;
        }

        if( other.gameObject.CompareTag( "red3" ) ) {
            if( Random.Range( 0, 2 ) < 1 ) {
                if( GameObject.Find( "Orange (3)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red3" ).transform.position = GameObject.Find( "Orange (3)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red3" ).transform.position = GameObject.Find( "Orange (4)" ).transform.position;
                }
            } else {
                if( GameObject.Find( "Orange (4)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red3" ).transform.position = GameObject.Find( "Orange (4)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red3" ).transform.position = GameObject.Find( "Orange (3)" ).transform.position;
                }
            }
            GameObject.FindGameObjectWithTag( "red3" ).transform.Translate( new Vector3( 0.0f, 0.0f, 0.0f ) );
            GameObject.Find( "Orange (3)" ).SetActive( false );
            GameObject.Find( "Orange (4)" ).SetActive( false );
            count++;
        }
        if( other.gameObject.CompareTag( "red4" ) ) {
            if( Random.Range( 0, 2 ) < 1 ) {
                if( GameObject.Find( "Orange (5)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red4" ).transform.position = GameObject.Find( "Orange (5)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red4" ).transform.position = GameObject.Find( "Orange (6)" ).transform.position;
                }
            } else {
                if( GameObject.Find( "Orange (6)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red4" ).transform.position = GameObject.Find( "Orange (6)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red4" ).transform.position = GameObject.Find( "Orange (5)" ).transform.position;
                }
            }
            GameObject.FindGameObjectWithTag( "red4" ).transform.Translate( new Vector3( 0.0f, 0.0f, 0.0f ) );
            GameObject.Find( "Orange (5)" ).SetActive( false );
            GameObject.Find( "Orange (6)" ).SetActive( false );
            count++;
        }

        if( other.gameObject.CompareTag( "red5" ) ) {
            if( Random.Range( 0, 2 ) < 1 ) {
                if( GameObject.Find( "Orange (5)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red5" ).transform.position = GameObject.Find( "Orange (5)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red5" ).transform.position = GameObject.Find( "Orange (6)" ).transform.position;
                }
            } else {
                if( GameObject.Find( "Orange (6)" ) != null ) {
                    GameObject.FindGameObjectWithTag( "red5" ).transform.position = GameObject.Find( "Orange (6)" ).transform.position;
                } else {
                    GameObject.FindGameObjectWithTag( "red5" ).transform.position = GameObject.Find( "Orange (5)" ).transform.position;
                }
            }
            GameObject.FindGameObjectWithTag( "red5" ).transform.Translate( new Vector3( 0.0f, 0.0f, 0.0f ) );
            GameObject.Find( "Orange (5)" ).SetActive( false );
            GameObject.Find( "Orange (6)" ).SetActive( false );
            count++;
        }
*/