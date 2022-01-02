using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementDuck : MonoBehaviour
{
    public float dirX;
    public float moveSpeed;
    private Rigidbody2D rb;
    private Vector3 localScale;
    private Animator anim;
    public float spawnTime = 3f;
    public GameObject duck;
    [SerializeField]
    private GameObject theScore;
    public ScoreManager scoreManager;

    public GameObject canvas;
    private CanvasManager canvasManager;

    private AudioSource audioSource;
    public AudioClip Dog;

    void Start ()
	{
        theScore = GameObject.Find("DuckGenerator");
        scoreManager = theScore.GetComponent<ScoreManager>();

        canvas = GameObject.Find("Canvas");
        canvasManager = canvas.GetComponent<CanvasManager>();

        audioSource = GetComponent<AudioSource>();


        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        anim =gameObject.GetComponent<Animator>();
        

        dirX = -1f;
        if(transform.position.x <= -22.44f)
        {
            moveSpeed = -3f;
            anim.Play("Duck_Right");
            
        }
        else
        {
            moveSpeed = 3f;
            anim.Play("Duck_Left");
        }
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

       
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        scoreManager.score += 100;
        canvasManager.bullets += 1;
        canvasManager.scoreValue += 100;



    }


}
