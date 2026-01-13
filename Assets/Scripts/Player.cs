using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        gameObject.SetActive(true);
        _numSeedsLeft = _numSeeds = 5;
        _numSeedsPlanted = 0;

        if (_plantCountUI != null)
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * _speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * _speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
            PlantSeed();
    }

    public void PlantSeed ()
    {
        if(_numSeedsLeft > 0)
        {
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
            _numSeedsLeft--;
            _numSeedsPlanted ++;

            if(_plantCountUI != null)
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

        }
    }
}
