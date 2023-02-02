using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ugokudake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        // 上に移動
        if (Input.GetKey (KeyCode.UpArrow)) {
            this.transform.Translate (0.0f, 0.1f, 0.0f);
        }
        // 下に移動
        if (Input.GetKey (KeyCode.DownArrow)) {
            this.transform.Translate (0.0f, -0.1f, 0.0f);
        }

    }
}
