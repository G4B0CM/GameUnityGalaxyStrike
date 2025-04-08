using UnityEngine;

public class CollisionHandlert : MonoBehaviour
{
    [SerializeField] GameObject particulas;
    GameSceneManager gameSceneManager;

    private void Start()
    {
        gameSceneManager = FindAnyObjectByType<GameSceneManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        gameSceneManager.ReloadLevel();
        Instantiate(particulas,transform.position,Quaternion.identity);
        Destroy(this.gameObject);
    }
}
