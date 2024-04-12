using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VehicleMover : MonoBehaviour
{
[SerializeField]
private float moveSpeed = 10.0f;
[SerializeField]
private float turnSpeed = 50.0f;
private bool movingForward = false;
// Start is called before the first frame update
void Start()
{
}
// Update is called once per frame
void Update()
{
movingForward = false;
if(Input.GetKey(KeyCode.UpArrow))
{
transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
movingForward = true;
}
if (Input.GetKey(KeyCode.DownArrow))
{
transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
}
if (Input.GetKey(KeyCode.LeftArrow) && movingForward)
{
transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
}
if (Input.GetKey(KeyCode.RightArrow) && movingForward)
{
transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
}
}
}