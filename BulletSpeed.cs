using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    private Rigidbody rb; //Bullet's rigidbody.
    public float speed; //Speed of the bullet.
    public float damage = 25f; //Bullet's damage.


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Gets the bullet's rigidboy.
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        







        rb.velocity = transform.forward * -speed; //the speed of the bullet

    }

    private void OnCollisionEnter(Collision collision) //Collisions of the bullet.
    {
        Destroy(gameObject);

        EnemyController Target = collision.transform.GetComponent<EnemyController>(); //connects the enemy's script with the bullet script.

        if (collision.gameObject.tag == "Enemy_Alien_Lifeform") //If it his the alien lifeform.
        {
            Target.TakeDamage(damage); //alien is damage when in contact with the bullet.
            

      
        }

    }
}
