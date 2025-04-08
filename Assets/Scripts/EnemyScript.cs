using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;

    [SerializeField] int hitPoints = 5;
    [SerializeField] int scoreValue = 5;

    ScoreBoard scoreBoard;
    private void Start()
    {
        scoreBoard = FindFirstObjectByType<ScoreBoard>();
    }
    private void OnParticleCollision(GameObject other)
    {
        
        ProccessHits();
    }

    private void ProccessHits()
    {
        
        hitPoints--;
        if (hitPoints <= 0)
        {
            DestroyShip();
        }
    }

    protected virtual void DestroyShip()
    {
        scoreBoard.IncreaseSocre(scoreValue);
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
