using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellHandler : MonoBehaviour
{
    Vector3 target;
    public int index;
    public static SpellHandler instance;
    [SerializeField] GameObject[] spellEffects;
    [SerializeField] SpellData[] spellDatas;
    private float coolDownA;
    private float coolDownB;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            Spell(index);
        }
    }
    private void Spell(int id)
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (id == 1) //lightning
        {
            Instantiate(spellEffects[0], new Vector3(target.x, 0, 0), spellEffects[0].transform.rotation);
        } else if (id == 2)
        {
            Debug.Log(target.x + id);
        }
    }

    public void setIndex(int id)
    {
        index = id;
        Debug.Log(index);
    }
}
