using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScriptController : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;

    public AudioSource[] dialouges;

    // Start is called before the first frame update
    //called one time on start of play
    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    //called every time script is running
    void Update()
    {

        bool walkKeyPressed = Input.GetKey("w");
       // bool isWalking = animator.GetBool("isWalking");
        //if w is pressed
        if (walkKeyPressed)
        {
            //the boolean flag isWaving is set to true
            animator.SetBool("isWalking",true);
           // audioSource.Play();

        }
        if (!walkKeyPressed)
        {
            //the boolean flag isWalking is set to true and isWaving to false
            animator.SetBool("isIdle", false);
        } 
        if (Input.GetKey("s"))
        {
            //the boolean flag isSearching is set to true
            animator.SetBool("isSearching", true);
        }
    }
}
