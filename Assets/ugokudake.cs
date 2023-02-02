using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ugokudake : MonoBehaviour
{
    [SerializeField]
    float JUMP_VELOCITY = 700; // ジャンプ力
    Rigidbody2D _rigidbody; // 物理挙動コンポーネント保持用

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 左に移動
        if (Input.GetKey (KeyCode.LeftArrow)) {
            this.transform.Translate (-0.1f, 0.0f, 0.0f);
        }
        // 右に移動
        if (Input.GetKey (KeyCode.RightArrow)) {
            this.transform.Translate (0.1f, 0.0f, 0.0f);
        }
        // ジャンプ
        if (Input.GetKeyDown(KeyCode.Space)) {
            _rigidbody.velocity = Vector2.zero; //落下ベクトルのスカラーを0にする
            _rigidbody.AddForce(new Vector2(0, JUMP_VELOCITY)); //上方向に力を加える
        }
    }
}
