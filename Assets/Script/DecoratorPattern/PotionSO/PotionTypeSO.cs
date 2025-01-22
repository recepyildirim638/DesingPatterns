using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PotionTypeSO", menuName ="SO/PotionTypeSO")]
public class PotionTypeSO : ScriptableObject
{
    public int value;
    public PotionType type;
}


public enum PotionType
{
    Speed,
    Healt,
    Damage
}