using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flymach : MonoBehaviour
{
     public gamemanager gm;
    public float velocity = 1;
    
    public AudioClip jumpSound;
    public AudioClip crashsound;
    private AudioSource playerAudio;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)){
            rb.velocity = Vector2.up*velocity;
            playerAudio.PlayOneShot(jumpSound,1.0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        gm.GameOver();
        playerAudio.PlayOneShot(crashsound,1.0f);
    }
}
