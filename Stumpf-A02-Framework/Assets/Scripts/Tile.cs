using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] private Color _baseColor;
    [SerializeField] private Color _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    
    private bool subMenuOn; 
    private int addBuilding;
    private Tile selectedTile;

    public void Init(bool isOffset) {
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    void OnMouseEnter() {
        subMenuOn = HUDButtons.GetSubMenuOn();
        if(subMenuOn == false) {
            _highlight.SetActive(true);
        }
    }

    void OnMouseExit() {
        _highlight.SetActive(false);
    }

    void OnMouseDown() {
        selectedTile = this;
        subMenuOn = HUDButtons.GetSubMenuOn();
        addBuilding = SubMenus.GetAddBuilding();

        if(addBuilding > 0) {
            if(addBuilding == 1) {
                selectedTile.GetComponent<SpriteRenderer>().color = new Color32(255,0,0,100);
            }
             if(addBuilding == 2) {
                selectedTile.GetComponent<SpriteRenderer>().color = new Color32(255,255,0,100);
            }
             if(addBuilding == 3) {
                selectedTile.GetComponent<SpriteRenderer>().color = new Color32(255,0,225,100);
            }
            SubMenus.ChangeAddBuilding();
        }
        if(subMenuOn == false) {
            Debug.Log("Tile has been clicked");
        }
    }
}
