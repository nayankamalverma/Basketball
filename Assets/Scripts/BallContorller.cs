using UnityEngine;

public class BallContorller : MonoBehaviour
{

    [SerializeField] private Rigidbody ball;
    [SerializeField] private Transform barL;
    [SerializeField] private Transform barR;


    [SerializeField] private float forceAmount=10f;
    


    [SerializeField] private Vector3 dir;
    private Vector3 pos;

    private float z = -10;


    private void Start()
    {
        

    }

    private void Update()
    {
        pos = transform.position;
        transform.position = new Vector3(pos.x, pos.y, z);
        if(pos.x < barL.position.x)
        {
            transform.position = new Vector3(barR.position.x, pos.y, z);
        }else if(pos.x > barR.position.x)
        {
            transform.position = new Vector3(barL.position.x, pos.y, z);
        }

        if (Input.GetMouseButtonDown(0)) {
            ApplyForce();
        }
        void ApplyForce()
        {
            ball.AddForce(dir * forceAmount, ForceMode.Impulse);
        }



    }
}
