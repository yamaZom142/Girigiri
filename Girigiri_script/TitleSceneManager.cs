﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
