using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDeffender : MonoBehaviour
{
    [SerializeField] private TakeBonus _takeBonus;
    [SerializeField] private GameObject _core;
    private bool _isActive;
    void Start()
    {
        _isActive = false;
        _takeBonus.BonusDeffenderTakeHandler += TurnOnAllDeffender;
    }
    void TurnOnAllDeffender()
    {
        StartCoroutine(Duration());
       for(int i=0;i<_core.transform.childCount;i++)
        {
            if (_core.transform.GetChild(i).GetComponent<Deffend>() != null)
                _core.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
    IEnumerator Duration()
    {
        yield return new WaitForSeconds(10);
        _isActive = false;
        TurnOffAllDeffender();
    }
    void TurnOffAllDeffender()
    {
        for (int i = 1; i < _core.transform.childCount; i++)
        {
            if (_core.transform.GetChild(i).GetComponent<Deffend>() != null)
                _core.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
