using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator animator;
    private bool canMoveX, canMoveY;

    void Start(){
        animator = GetComponent<Animator>();
        canMoveX = true;
        canMoveY = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        AnimatePlayer();
        if(Input.GetKey(KeyCode.LeftArrow) && canMoveX) {
            animator.SetInteger("speedX", -1);
        }
        else if(Input.GetKey(KeyCode.RightArrow) && canMoveX) {
            animator.SetInteger("speedX", 1);
        }
        else if(Input.GetKey(KeyCode.UpArrow) && canMoveY) {
            animator.SetInteger("speedY", 1);
        }
        else if(Input.GetKey(KeyCode.DownArrow) && canMoveY) {
            animator.SetInteger("speedY", -1);
        } else {
            animator.SetInteger("speedX", 0);
            animator.SetInteger("speedY", 0);
        }
    }

    void AnimatePlayer(){
        if(canMoveX){
            if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)){
                canMoveY = false;
            }
        }
        if(canMoveY){
            if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)){
                canMoveX = false;
            }
        }

        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)){
            canMoveX = true;
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)){
            canMoveY = true;
        }
    }

}
