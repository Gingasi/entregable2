using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerHP : MonoBehaviour
{
    [SerializeField] private bool isGameOver;
    public int PlayerHp = 40;
    public int damage = 60;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{PlayerHp} - {damage} = {PlayerHp - damage}");
        PlayerHp = PlayerHp - damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            if (PlayerHp <= 0)
            {
                Debug.Log($"Te has quedado sin vida… GAME OVER");
            }
            else if (PlayerHp <= 30)
            {
                Debug.Log($" ¡¡¡Tienes poca vida!!!");
            }
            else 
            {
                Debug.Log($"  Vas bien de vida: tienes {PlayerHp} puntos de vida");
            }
        }
        if (isGameOver == true)
        {
                Debug.Log($"GAME OVER");
        }
    }
}

