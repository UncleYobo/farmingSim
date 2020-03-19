using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private bool canMoveX, canMoveY;

    void Start(){
        canMoveX = true;
        canMoveY = true;
    }

    // Update is called once per frame
    void Update()
    {
        InputCheck();

        if(canMoveY){
            ApplyMovement(0f, Input.GetAxis("Vertical"));
        }
        if(canMoveX){
            ApplyMovement(Input.GetAxis("Horizontal"), 0f);
        }
    }

    void InputCheck(){
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

        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)){
            canMoveY = true;
        } 
        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)){
            canMoveX = true;
        } 
    }

    void ApplyMovement(float x, float y) {
        Vector3 moveVec = new Vector3(x, y, 0f);
        this.transform.Translate(moveVec * moveSpeed);
    }
}
