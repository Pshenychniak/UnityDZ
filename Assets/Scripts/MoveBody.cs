using UnityEngine;

public class MoveBody : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigitbody;
    [SerializeField] private float _speed;

    private void Update()
    {
        var horisontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var horisontalSpeed= horisontal* _speed*Time.deltaTime;
        var verticalSpeed= vertical * _speed*Time.deltaTime;
        _rigitbody.AddForce(horisontalSpeed, 0f, verticalSpeed, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigitbody.AddForce(0f, 3f, 0f, ForceMode.Impulse);
        }
    }

}
