using UnityEngine;

public class KeyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //現在の回転量を取得する
        var currentRotation = this.transform.rotation;

        //上下左右の回転軸（左右矢印キーで動く）の値を取得する
        //Quarternionは掛け算をすると回転量が変わる
        var horizontalRotation = Quaternion.AngleAxis(Input.GetAxis("Horizontal"), Vector3.forward);
        var verticalRotation = Quaternion.AngleAxis(Input.GetAxis("Vertical"), Vector3.right);

        var nextRotation = currentRotation * horizontalRotation * verticalRotation;

        //計算後の回転量を設定する
        this.transform.rotation = nextRotation;
    }
}
