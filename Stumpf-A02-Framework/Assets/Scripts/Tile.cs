using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Tile : MonoBehaviour
{

    [SerializeField] private Color _baseColor;
    [SerializeField] private Color _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    public Sprite[] buildings;
    public bool clickable = true;    
    private bool disableGrid; 
    private int addBuilding;
    private int addInsurance;

    private Tile selectedTile;

    public void Init(bool isOffset) {
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    public bool getClickable() {
        return clickable;
    }

    public void setClickable(bool newValue) {
        clickable = newValue;
    }

    void OnMouseEnter() {
        disableGrid = Manager.GetDisableGrid();
        if(disableGrid == false && clickable == true) {
            _highlight.SetActive(true);
        }
    }

    void OnMouseExit() {
        _highlight.SetActive(false);
    }

    void OnMouseDown() {
        selectedTile = this;
        disableGrid = Manager.GetDisableGrid();
        addBuilding = Manager.GetAddBuilding();
        addInsurance = Manager.GetAddBuilding();
        
        if(addBuilding > 0 && clickable == true && disableGrid == false) {
            selectedTile.GetComponent<SpriteRenderer>().sprite = buildings[addBuilding - 1];
            Manager.buildingsPurchased.Add(selectedTile);
            Manager.ChangeAddBuilding();
            clickable = false;      
        }
    }
}
