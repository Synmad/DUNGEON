using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Character", menuName = "Character")]
public class CharacterDataSO : ScriptableObject
{
    [SerializeField] List<SkillSO> skills = new List<SkillSO>();
}