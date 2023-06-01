using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public InputField enterName;

    void Start()
    {
        // Attach a listener to the onEndEdit event
        enterName.onEndEdit.AddListener(OnInputFieldEndEdit);
    }

    private void OnInputFieldEndEdit(string name)
    {
        // When listener is triggered, save entered name to PersistanceManager UserName field
        PersistanceManager.Instance.UserName = name;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
