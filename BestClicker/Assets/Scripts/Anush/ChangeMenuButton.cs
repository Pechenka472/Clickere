using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenuButton : MonoBehaviour
{
    public GameObject Menu;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangeMenu()
    {
        var menus = MonoSingleton<MenuController>.Instance.Menus;
        Debug.Log(1111);
        foreach (var menu in menus)
        {
            if (menu.name != Menu.name)
                menu.SetActive(false);
            else
                menu.SetActive(true);
        }
    }
}
