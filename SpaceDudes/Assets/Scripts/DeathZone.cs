using UnityEngine;


public class DeathZone : MonoBehaviour
{

   
    
    public int damage = 3;
    

    // Start is called before the first frame update
 

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
}