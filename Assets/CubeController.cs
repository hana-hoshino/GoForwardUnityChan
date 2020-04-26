using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    //衝突音
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        //Componentを取得
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

    //地面もしくはキューブ同士が衝突したときに音を出す
    void OnColliderEnter2D(Collision2D other)
    {
        Debug.Log("キューブの音");
        audioSource.Play();

    }
}