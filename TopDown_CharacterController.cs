using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown_CharacterController : MonoBehaviour
{
    [SerializeField] float player_Speed = 1f;
    const float player_SpeedMultiplier = 10000;
    Rigidbody2D rb;

    private void Awake()
    {
        //Conseguir rigidbody2d.
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        //Conseguir direcion (normalizada) y multiplicar por velocidad del jugador.
        float moveX = 0;
        float moveY = 0;

        if (Input.GetKey(KeyCode.UpArrow)) moveY += 1;
        if (Input.GetKey(KeyCode.DownArrow)) moveY -= 1;
        if (Input.GetKey(KeyCode.LeftArrow)) moveX -= 1;
        if (Input.GetKey(KeyCode.RightArrow)) moveX += 1;
        SetVelocity(new Vector2(moveX,moveY).normalized);

        Debug.Log("Normalized direction: " + new Vector2(moveX, moveY).normalized);
        Debug.Log("Direction: " + new Vector2(moveX, moveY));
    }

    void SetVelocity(Vector2 direction)
    {
        //Añadir velocidad.
        rb.velocity = direction * player_Speed * player_SpeedMultiplier * Time.deltaTime;
    }


}
