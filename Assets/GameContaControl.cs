using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameContaControl : MonoBehaviour
{
    public List<int> _respList;
    public List<blocoNumero> _blocoNumeroList;

    private void Start()
    {
        Invoke("SetBlocoNumber", 1);
    }
    public void SetBlocoNumber()
    {
        for (int i = 0; i < _blocoNumeroList.Count; i++)
        {
            _blocoNumeroList[i]._numeroBloco = _respList[i];
            _blocoNumeroList[i]._textBloco.text = ""+ _respList[i];
        }
    }    
}
