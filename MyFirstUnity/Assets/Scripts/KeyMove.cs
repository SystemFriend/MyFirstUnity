using UnityEngine;

public class KeyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //現在の回転量を取得する
        var currentRotation = this.transform.rotation;

        //左右の回転軸（左右矢印キーで動く）の値を取得する
        //Quarternionは掛け算をすると回転量が変わる
        var nextRotation = currentRotation * Quaternion.AngleAxis(Input.GetAxis("Horizontal"), Vector3.forward);

        //計算後の回転量を設定する
        this.transform.rotation = nextRotation;
    }
}
