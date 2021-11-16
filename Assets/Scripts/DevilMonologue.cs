
using UnityEngine;

public class DevilMonologue : MonoBehaviour
{
    
    public Animator animator;

     void Start() 
    {
        animator = GetComponent<Animator>();    
    }


    public void StartTalk ()
    {
      //  animator.SetFloat("monologue 2", 1f);
        
        Debug.Log("animatie speelt af");
    }

        public void StopTalk()
    {
       // animator.SetFloat("monologue 2", 0f);
        Debug.Log("animatie stopt");
    }
}
