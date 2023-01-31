using UnityEngine;

[CreateAssetMenu (fileName = "CharacterData", menuName = "Data/ControllerData/CharacterData/CharacterData")]

public class CharacterData : ScriptableObject
{
    public ID id;
    public float speed, knockBackPower, knockBackResistance;
    public BoolData canRun, gameOver;
}
