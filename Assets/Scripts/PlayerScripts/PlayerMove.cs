using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    
    private Rigidbody2D rb2d;

    private Camera cameraMain;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        cameraMain = Camera.main;
    }

    private Vector2 clickPos;
   
    private Vector2 direction;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPos = cameraMain.ScreenToWorldPoint(Input.mousePosition);
            direction = (clickPos - (Vector2)transform.position).normalized;
            Move(direction);
        }
    }

    public void Move(Vector2 direction)
    {
        rb2d.AddForce(direction * speed, ForceMode2D.Impulse);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, clickPos);
    }
}