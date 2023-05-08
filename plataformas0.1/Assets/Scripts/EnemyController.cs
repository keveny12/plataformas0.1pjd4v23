using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private int hp;

    [SerializeField] private Sprite mySprite;

    [SerializeField] private float changeDirectionTime;

    private SpriteRenderer _spriteRenderer;

    private Vector2 walkDirection;

    private float _currentChangeTime;

    private Animator enemyAi;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyAi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       MoveDirection(); 
       CountTime();
    }

    public void initialize(int hp, Sprite sprite)
    {
        this.hp = hp;
        mySprite = sprite;

        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        _spriteRenderer.sprite = mySprite;
    }

    public void SetWalkDirection(Vector2 direction)
    {
        walkDirection = direction;
    }

    public void MoveDirection()
    {
        transform.Translate((walkDirection * Time.deltaTime));
    }

    public void CountTime()
    {
        if (_currentChangeTime <= changeDirectionTime)
        {
            _currentChangeTime += Time.deltaTime;
        }
        else
        {
            _currentChangeTime = 0;
            //mudar a direcao de andar
            enemyAi.SetTrigger("ChangeDirection");
        }
    }
}
