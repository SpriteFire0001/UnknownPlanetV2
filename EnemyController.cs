using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Used for applying AI functions in the script.
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public float health = 50f; //health of the enemy.
    NavMeshAgent agent; //NavMeshAgent of the enemy.
    Transform target; //The enemy's target.
    public float lookradius = 3f; //The enemy's sight.
    public float EnemyAttackFactor = 2f;
    private Rigidbody ERB;
    public Transform ItemDrop; //The location which the items drops from the enemy after its death in action.
    public GameObject Metal;
    public GameObject Alien;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>(); //Get the NavMeshAgent.
        target = GameObject.FindGameObjectWithTag("Player").transform; //Set the target as the player.
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ERB = GetComponent<Rigidbody>();

        float distance = Vector3.Distance(transform.position, target.position); //The distance between the enemy and the player.

        if (distance <= lookradius) //Following the player.
        {
            agent.SetDestination(target.position);

        }


    }

    public void OnCollisionEnter(Collision collision)
    {

        Player Damage = collision.transform.GetComponent<Player>();
        
        
        float distance = Vector3.Distance(transform.position, target.position); //The distance between the enemy and the player.

        


        if (distance <= lookradius) //Following the player.
        {
            

            if (distance <= agent.stoppingDistance + 0.33) //The attacking sequence of the enemeny.
            {
                if (collision.gameObject.tag == "Player")
                {
                    Damage.PlayerTakesDamage(EnemyAttackFactor);
                }
            }
        }
    }



    


    public void TakeDamage(float amount) //The damage system.
    {
        health -= amount; //health take away by the amount of damage.

        if (health <= 0) //The enemy destruction function.
        {
            int DropValue = Random.Range(1, 6); //A random number generate whose result gives diffent dropped items to the player.
            Die(); //Summons the Die function which was designed to remove the enemy when they die in combat.

            if (DropValue == 1)
            {
                Instantiate(Metal, transform.position, transform.rotation);
                


            }
            else if (DropValue == 2)
            {
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                


            }
            else if (DropValue == 3)
            {
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                


            }
            else if (DropValue == 4)
            {
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                

            }
            else if (DropValue == 5)
            {
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                Instantiate(Metal, transform.position, transform.rotation);
                
            }
        }

    }

    void Die() 
    {
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected() //Used for drawing which the one  editing in Unity is able to see the lookradius of the enemy.
    {
        Gizmos.DrawWireSphere(transform.position, lookradius);
    }






}
