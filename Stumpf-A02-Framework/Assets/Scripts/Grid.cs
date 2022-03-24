using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=kkAjpQAM-jE

public class Grid : MonoBehaviour
{
    [SerializeField] private int _width;
    [SerializeField] private int _height;
    [SerializeField] private Tile _tilePrefab;
    private float startX = -16;
    private float startY = -7.2f;

    public Sprite water;
    public Sprite tree;



    private Dictionary<Vector2, Tile> _tiles;

    //https://www.youtube.com/watch?v=kkAjpQAM-jE
    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateGrid() {
        _tiles = new Dictionary<Vector2, Tile>();
        for(int x = 0; x < _width; x++) {
            for(int y = 0; y < _height; y++) {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3((4*x) + startX,(4*y) + startY, -1), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
                var isOffset = (x%2 == 0 && y %2 !=0) || (x%2 != 0 && y %2 ==0); 
                spawnedTile.Init(isOffset);

                var rand = Random.Range(0,10);
                if(rand == 0) {
                    // Water
                    spawnedTile.GetComponent<SpriteRenderer>().color = Color.blue;
                }
                if(rand == 1) {
                    // Tree
                    spawnedTile.GetComponent<SpriteRenderer>().sprite = tree;
                }

                _tiles[new Vector2(x,y)] = spawnedTile;
            }
        }
    }

    public Tile GetTileAtPosition(Vector2 position) {
        if(_tiles.TryGetValue(position, out var tile)) {
            return tile;
        }
        return null;
    }

 



}
