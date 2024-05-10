using UnityEngine;

[RequireComponent ( typeof ( MeshRenderer ) )]
public class Cube : MonoBehaviour
{
    [SerializeField] private float _cubeScale = 5f;
    
    private MeshRenderer _renderer;
    private float _scaleRatio = 2f;
    private float _spawnChanсe = 100f;
    
    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
        transform.localScale *= _cubeScale;
    }

    private void Start()
    {
        SetRandomColor();
    }

    public Vector3 GetSpawnScale()
    {
        return transform.localScale / _scaleRatio;
    }

    public void SetScale(Vector3 scale)
    {
        transform.localScale = scale;
    }

    public float GetSpawnChanсe()
    {
        return _spawnChanсe;
    }

    public void SetSpawnChance(float value)
    {
        _spawnChanсe = value;
    }

    public void SetRandomColor()
    {
        _renderer.material.color = Random.ColorHSV();
    }
}
