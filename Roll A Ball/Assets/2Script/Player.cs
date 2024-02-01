using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpPower; // public이 붙으면 초기화 하지 않아도 됨
    public int itemCount;
    public GameManager manager;
    bool isJump;    
    Rigidbody rigid;
    AudioSource audio;

    void Awake() {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
    void Update() {
        if(Input.GetButtonDown("Jump") && !isJump){
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
    void FixedUpdate() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Floor")
            isJump = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coins")
        {
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false); //오브젝트 비활성화
            manager.GetItem(itemCount);
        }
        else if (other.tag == "Finish")
        {
            if(itemCount == manager.totalItemCount)
            {
                // Game Clear!
                // SceneManager.LoadScene("Example" + (manager.stage + 1).ToString());
                SceneManager.LoadScene(manager.stage + 1);
                manager.stage += 1;
            }
            else {
                // Restart
                Debug.Log("Restart");
                SceneManager.LoadScene(manager.stage);
            }
        }
    }
}
