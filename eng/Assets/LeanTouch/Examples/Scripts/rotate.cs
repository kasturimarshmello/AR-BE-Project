using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    private Transform mMoveObject = null;  //for the root game object
    private float RotationSpeed = 0.5f;
    private Vector2 PrevPt1;
    private Vector2 PrevPt2;
    private Rotate mTransform;
    private GameObject mGORoot;  //cube object


    public void SetTransformRotateAround(Transform goMove)
    {
        mMoveObject = goMove;
        if (mMoveObject == null)
        {
            Debug.LogWarning("Error! Cannot find object!");
            return;
        }
    }

    float dx, dy, touchDist;  
// rotate

    // construction method
    public Rotate()
    {
    if (Input.touchCount == 1) //single touch event
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
            PrevPt1 = Input.GetTouch(0).position;

        if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            dx = PrevPt1.x - Input.GetTouch(0).position.x;
            dy = PrevPt1.y - Input.GetTouch(0).position.y;
            touchDist = Mathf.Abs(dx) + Mathf.Abs(dy);

            if (touchDist > 10)
            {
                //rotate the model if finger has big movement
                dx = Input.GetTouch(0).deltaPosition.x;
                dy = Input.GetTouch(0).deltaPosition.y;
                mMoveObject.RotateAround(Vector3.zero, mMoveObject.transform.up, -dx * RotationSpeed);
                mMoveObject.RotateAround(Vector3.zero, Vector3.right, dy * RotationSpeed);
            }
        }
    }
    mGORoot = GameObject.Find("Space Scour Drone");
    mTransform = new Rotate();
    mTransform.SetTransformRotateAround(mGORoot.transform);


}

// Update is called once per frame
public void Update()
    {
    mTransform.Update();



}
}
