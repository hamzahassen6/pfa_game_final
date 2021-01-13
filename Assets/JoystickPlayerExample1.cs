using UnityEngine;

public class JoystickPlayerExample1 : MonoBehaviour
{

    public float speed;
    public FloatingJoystick floatingjoystick_right, floatingjoystick_left;
    public GameObject right, left;
    public Rigidbody rb_right, rb_left;
    public float maxdis = 8f;
    Vector3 offset;
    public float speedmovetowards;




    public void FixedUpdate()
    {

        float dist = Vector3.Distance(right.transform.position, left.transform.position);

        /*******************direction right and left*****************/
        Vector3 direction_right = Vector3.forward * floatingjoystick_right.Vertical + Vector3.right * floatingjoystick_right.Horizontal;

        Vector3 direction_left = Vector3.forward * floatingjoystick_left.Vertical + Vector3.right * floatingjoystick_left.Horizontal;
       
        /******************* if the right moves **********************/
        if (direction_right != Vector3.zero)
        {
            rb_right.velocity = new Vector3(direction_right.x * speed, 0, direction_right.z * speed);



            /******************check maxdistance************/
            if (dist >= maxdis)

            {
                offset = right.transform.position - left.transform.position;
                right.transform.position = left.transform.position + Vector3.ClampMagnitude(offset, maxdis);
            }

        } 
        else if (direction_right == Vector3.zero)
        { 
            rb_right.velocity = Vector3.zero;
        } 
        /******************* if the left moves **********************/
        if (direction_left != Vector3.zero)
        {
            rb_left.velocity = new Vector3(direction_left.x * speed, 0, direction_left.z * speed);


            /******************check maxdistance************/
            if (dist >= maxdis)
            {
                offset = right.transform.position - left.transform.position;
                right.transform.position = left.transform.position + Vector3.ClampMagnitude(offset, maxdis);
            }
        }
        else if (direction_left == Vector3.zero)
        {
            rb_left.velocity = Vector3.zero;
        }

        /*
        if (direction == Vector3.zero)
        {
            //rb.AddForce(offset * magnetforce * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, sec.transform.position, speedmovetowards);
            rb.velocity = Vector3.zero;

        }*/


      
}
}