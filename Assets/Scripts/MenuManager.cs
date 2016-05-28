using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour
{
    public Menu currentMenu;    // The current menu being displayed

    public void Start()
    {
        // Makes sure the current menu is displayed when the game starts
        ShowMenu(currentMenu);
    }

    // Manages the changing of menus
    public void ShowMenu(Menu menu)
    {
        if (currentMenu != null)
            currentMenu.isOpen = false;

        currentMenu = menu;
        currentMenu.isOpen = true;
    }
}