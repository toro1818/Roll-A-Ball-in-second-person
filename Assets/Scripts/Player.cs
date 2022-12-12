using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Rigidbody rd;

    public int score = 0;

    public Text scoreText;

    public GameObject winText;

    // Start is called before the first frame update
    // Start ���� Update ���� ���� = ����   
    void Start()
    {
        //Debug.Log("��Ϸ��ʼ��");
        //��ӡ ��� ��ʾ
        //��־ //��ֵ
        //rd = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("��Ϸ��������");
        //(x,y,z) (1,0,0)
        // Vector3.right left forward back
        // (2,0,0)
        //rd.AddForce( new Vector3(10,0,0) );

        float h = Input.GetAxis("Horizontal");//-1 1
        float v = Input.GetAxis("Vertical");// ws 
        //Debug.Log(h);  (1,2,3) * 2 = (2,4,6)
        rd.AddForce(new Vector3(h, 0, v) * 1 );
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("������ײ�� OnCollisionEnter");


        if(collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
        }

    }
    //private void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("������ײ�� OnCollisionExit");
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("������ײ�� OnCollisionStay");
    //}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter"+other.tag);

        if (other.tag == "Food")
        {
            Destroy(other.gameObject);

            //++���������
            score++;

            scoreText.text = "������" + score ;

            if(score == 4)
            {
                winText.SetActive(true);//true false
            }
        }


    }
    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("OnTriggerExit" + other.tag);
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("OnTriggerStay" + other.tag);
    //}
}
