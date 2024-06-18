# Table-Titans

Descrição:
Table Titans é um jogo de futebol gol a gol para dois jogadores. O objetivo do jogo é simples: impedir que o adversário chute a bola contra a sua parede e marcar pontos chutando a bola contra a parede do adversário.

Controles:
Player 1: Controla seu personagem com as teclas W (para mover para cima) e S (para mover para baixo).
Player 2: Controla seu personagem com as setas ↑ (para mover para cima) e ↓ (para mover para baixo).

Regras do Jogo:
Cada jogador controla um "titã" de mesa.
O objetivo é marcar pontos chutando a bola contra a parede do adversário.
O jogador não pode deixar a bola atingir sua própria parede, caso contrário, o adversário pontuará.
O jogo continua até que um dos jogadores alcance a pontuação máxima (ou qualquer regra de término definida).

Funcionalidades:

O script abaixo controla o movimento de dois jogadores, cada jogador é movido para cima e para baixo (no eixo z). A enumeração ePlayer distingue entre o jogador da esquerda e o jogador da direita, e a velocidade do movimento é ajustada pela variável speed.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer
{
    Left,
    Right
}
public class Player : MonoBehaviour
{   
    public float speed = 15f;
    public ePlayer player;

    // Update is called once per frame
    void Update()
    {
        float inputSpeed = 0f;
        if (player == ePlayer.Left)
        {
            inputSpeed = Input.GetAxisRaw("PlayerLeft");
        }
        else if (player == ePlayer.Right)
        {
            inputSpeed = Input.GetAxisRaw("PlayerRight");
        }

        transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
    }
}

O script abaixo é responsável por dar à bola um impulso inicial quando o jogo começa. Quando o jogo inicia, o método Start é chamado, que então obtém o componente Rigidbody da bola e aplica uma força definida pelo vetor inintialImpulse, fazendo com que a bola comece a se mover. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{  



    public Vector3 inintialImpulse;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(inintialImpulse, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

Fotos e vídeo:
![2](https://github.com/Vitorsz01/Table-Titans/assets/167926693/f1775f10-3759-4952-9d7b-91900187e515)
![Menu](https://github.com/Vitorsz01/Table-Titans/assets/167926693/62770c9a-9445-4025-8ff3-a7bfe3e331ce)
![1](https://github.com/Vitorsz01/Table-Titans/assets/167926693/9b84bf48-92f5-4687-8638-ca88cba427fe)

https://github.com/Vitorsz01/Table-Titans/assets/167926693/9a223be4-3366-441f-b078-19518f578644
