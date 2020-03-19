using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    public int sizeX, sizeY;
    public float offset;
    public GameObject grassTile;
    // Start is called before the first frame update
    void Start()
    {
        SpawnLevel();
        PositionInCenter();
    }

    void SpawnLevel(){
        for(int x = 0; x < sizeX; x++){
            for(int y = 0; y < sizeY; y++){
                Vector2 placement = new Vector2(x * offset, y * offset);
                GameObject tile = Instantiate(grassTile, placement, Quaternion.identity);
                tile.transform.SetParent(this.gameObject.transform);
            }
        }
    }

    void PositionInCenter(){
        Vector2 centerPoint = new Vector2(-(sizeX * offset)/2f, -(sizeY * offset)/2f);
        this.transform.position = centerPoint;
    }

}
