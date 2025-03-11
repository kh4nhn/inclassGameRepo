using UnityEngine;

public class Jumper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(IsGrounded());
    }

    bool IsGrounded()
    {
        Vector2 triBelly = transform.position;
        // Vector2 belowFeet = triBelly + Vector2.down*0.6f;
        Vector2 direction = Vector2.down;
        float distance = 0.5f;
        Debug.DrawRay(triBelly, direction, Color.blue);
        RaycastHit2D hit = Physics2D.Raycast(triBelly, direction, distance);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
}
