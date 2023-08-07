using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    private Vector3 _initialPosition;
    private bool birdLaunched;
    private float timeSittingAround;
    [SerializeField] private float force = 300;

    private void Awake()
    {
        _initialPosition = transform.position;
    }
    private void Update()
    {
        
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, _initialPosition);
        if (birdLaunched && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1f)
        {
            timeSittingAround = Time.deltaTime;
        }
        if (transform.position.y >10 || transform.position.y <-10 || transform.position.x >20 || transform.position.x < -20) 
        {
            string currentSceneName = SceneManager.GetActiveScene().name;  
            SceneManager.LoadScene(currentSceneName);
        }
        
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        GetComponent<LineRenderer>().enabled = true;
    }
    private void OnMouseUp()
    {
            GetComponent<SpriteRenderer>().color =Color.white;
        Vector2 directionToInitialPosition = _initialPosition - transform.position;
             GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * force);
        GetComponent<Rigidbody2D>().gravityScale = 1;
        birdLaunched = true;
        GetComponent<LineRenderer>().enabled = false;
    }
    private void OnMouseDrag()
    {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y, 0);
    }
}
