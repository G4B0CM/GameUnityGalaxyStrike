using TMPro;
using UnityEngine;

public class FinalEnemyScript : EnemyScript
{
    [SerializeField] TMP_Text fin;
    protected override void DestroyShip()
    {
        base.DestroyShip();
        fin.text = "Gracias por Jugar!";
    }
}
