﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountScene : UIScene
{
    public AccountScene(UIFacade uIFacade) : base(uIFacade) { }
    public override void EnterScene()
    {
        
        mUIFacade.AddPanelToDict(StringManager.LoginPanel);
        mUIFacade.AddPanelToDict(StringManager.RegisterPanel);
        base.EnterScene();

        // 打开LoginPanel
        mUIFacade.GetUIPanel(StringManager.LoginPanel).EnterPanel();
        Camera.main.GetComponent<Animator>().enabled = true;
    }

}