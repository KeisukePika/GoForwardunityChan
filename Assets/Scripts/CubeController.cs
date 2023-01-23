using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    //課題
    public AudioClip impact;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        //課題
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }



    }

    //課題
    private void OnCollisionEnter2D(Collision2D collider)
    {
        audioSource.PlayOneShot(impact, 0.7f);
       

        if (collider.gameObject.CompareTag("UnityChan"))
        {
            audioSource.Stop();
            
        }
        
    }
}
