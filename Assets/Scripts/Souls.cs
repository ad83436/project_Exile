using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

 public enum AnimalType : uint
{
    Human,
    Bear, 
    Deer,
    None
 }

public enum DietType : uint
{
    herb, 
    carni,
    omnie
}

public enum AnimalAge : uint
{
    Child,
    Teen, 
    Adult
}

public abstract class Souls : MonoBehaviour
{
    protected float maxHealth_;
    protected float damage_;
    protected float curntHealth_;
    public float maxHealth { get { return maxHealth_; } private set { maxHealth_ = value; } }
    public float damage { get { return damage_; } private set { damage_ = value; } }
    public float curntHealth { get { return curntHealth_; } private set { curntHealth_ = value; } }

    public abstract AnimalType animalType();

    protected float speed = 0.0f;

    protected bool isWalking = false;
    protected bool isIdle = false;
    public bool isRunning { get; protected set; }
    protected bool isEating = false;
    protected bool isAttacking = false;
    protected bool arrived = true;

    public Animator soulAnimator;
    public CharacterController charaController;
    public NavMeshAgent navAgent;
    Vector2 animalDestination;
    public GameObject land;

    static Dictionary<AnimalType, Souls> worldSouls; 

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void MoveTo()
    {
        if (arrived)
        {
            float desX = Random.Range(land.GetComponent<Collider>().bounds.min.x, land.GetComponent<Collider>().bounds.max.x);
        }
    }

    public void TakeDamage(float damage_)
    {
        if(curntHealth_ <= 0)
        {
            Death();
        }
        else
        {
            curntHealth_ -= damage_;
        }
    }

    protected virtual  void Death()
    {

    }

    protected void StartUp()
    {
        soulAnimator = GetComponent<Animator>();

        charaController = GetComponent<CharacterController>();

        //check if the obj has a nav mesh agent component if it does then assign it to the variable 
        if(GetComponent<NavMeshAgent>() != null)
        {
            navAgent = GetComponent<NavMeshAgent>();
        }
    }
}

