using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject menu;
    public GameObject speedSlider;
    public GameObject openMenuButton;

    public bool menuActive = false;
    public bool openMenuButtonActive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(menuActive)
            menu.SetActive(true);
        else
            menu.SetActive(false);

        if(openMenuButtonActive)
            openMenuButton.SetActive(true);
        else
            openMenuButton.SetActive(false);

    }
    public void MenuShow(){
        menuActive = true;
        MenuButtonHide();
    }
    public void MenuHide(){
        menuActive = false;
        MenuButtonShow();
    }
    public void MenuButtonShow(){
        openMenuButtonActive = true;
        
    }
    public void MenuButtonHide(){
        openMenuButtonActive = false;
    }
}
