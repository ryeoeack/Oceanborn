using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spell Data", menuName = "Scriptable Object/Spell Data", order = int.MaxValue)]

public class SpellData : ScriptableObject
{
    public float spellID;
    public string spellName;
    public float manaCost;
    public GameObject spellEffect;

}
