using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    // ジャンプ力
    float JUMP_VELOCITY = 1000;
    // 物理挙動のためのコンポーネント
    Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            _rigidbody.velocity = Vector2.zero; // ジャンプ直前のオブジェクトのベクトルをゼロにする
            _rigidbody.AddForce(new Vector2(0, JUMP_VELOCITY));
        }
    }
}
