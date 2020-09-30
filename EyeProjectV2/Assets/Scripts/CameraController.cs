 using UnityEngine;
 
 public class CameraController : MonoBehaviour
{
    public float speed = 3;

    private float X;
    private float Y;

    public bool isDrag = false;

    public void StartDrag()
    {
        isDrag = true;
    }


    public void MoveObject()
    {
        if (isDrag)
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0));
            X = transform.rotation.eulerAngles.x;
            Y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(X, Y, 0);
        }

    }



    public void FinishDrag()
    {
        isDrag = false;
    }
}
