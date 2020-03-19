using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHider : MonoBehaviour
{
    public float renderDistance;
    public GameObject[] players;

    public SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        players = GameObject.FindGameObjectsWithTag("Player");
    }
    void LateUpdate(){
        CheckAllPlayerDistances();
    }

    void CheckAllPlayerDistances(){
        foreach(GameObject p in players){
            float distance = Vector2.Distance(this.transform.position, p.transform.position);
            if(distance < renderDistance){
                spriteRenderer.enabled = true;
                return;
            } 
            else spriteRenderer.enabled = false;
        }
    }
}
