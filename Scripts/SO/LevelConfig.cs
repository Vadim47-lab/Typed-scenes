using UnityEngine;

[CreateAssetMenu(fileName = "Level Config", menuName = "Create Level Config", order = 51)]
public class LevelConfig : ScriptableObject
{
    [SerializeField] private int _towerSize;

    public int TowerSize => _towerSize;
}