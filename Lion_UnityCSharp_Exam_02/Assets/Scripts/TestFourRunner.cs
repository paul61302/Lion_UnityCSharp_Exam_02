using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFourRunner : MonoBehaviour
{
    [Header("玩家移動速度"),Range(0,50)]
    public float Speed;

    public GameObject littleMin;
    public Vector3 angle;
    private Rigidbody rig;
    public Animator ani;
    public AudioSource aud;

    public bool move;

    public bool ArriveEndpoint;

    public delegate void WalkingLittleMin();

    public event WalkingLittleMin onArrive;

    private void Start()
    {
        // GetComponent<泛型>() 泛型方法 - 泛型 所有類型 Rigidbody, Transform, Collider...
        // 剛體 = 取得元件<剛體>();
        rig = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
        move = true;
        ArriveEndpoint = false;

        aud.volume = 0.05f;
    }

    private void Update()
    {
        if (move)
        {
            PlayerMove();
        }

        if (ArriveEndpoint)
        {
            print("嘿嘿嘿~");
            onArrive();
        }
    }

    public void PlayerMove()
    {
        // 按鍵輸入
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        rig.AddForce(transform.forward * Speed * Mathf.Abs(v));
        rig.AddForce(transform.forward * Speed * Mathf.Abs(h));

        if (Mathf.Abs(v) > 0 || Mathf.Abs(h) > 0)
        {
            ani.SetBool("跑步", true);
            print("123");
        }
        else
        {
            ani.SetBool("跑步", false);
            print("456");
        }

        if (v == 1) angle = new Vector3(0, 0, 0);               // 前 Y 0度
        else if (v == -1) angle = new Vector3(0, 180, 0);       // 後 Y 180度
        else if (h == 1) angle = new Vector3(0, 90, 0);         // 右 Y 90度
        else if (h == -1) angle = new Vector3(0, 270, 0);       // 左 Y 270度
        
        transform.eulerAngles = angle;
    }

    public void Arrived()
    {
        ArriveEndpoint = true;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            Arrived();
        }
    }
    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            Arrived();
        }
    }*/
}
