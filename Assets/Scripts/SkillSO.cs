using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Skill")]
public class SkillSO : ScriptableObject
{
    [SerializeField] string _name;

    [SerializeField] int _damage;
}