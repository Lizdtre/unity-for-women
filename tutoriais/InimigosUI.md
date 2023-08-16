# Inimigos e UI

## Inimigos
  Vamos adicionar uma ameaça ao nosso jogo na forma de um inimigo que fica andando de um lado para o outro

  1. Crie um novo objeto e dê o sprite que quiser
  2. Adicione um Collider2D e customize o formato

  ![Inimigo com collider](https://cdn.discordapp.com/attachments/1105270961391030293/1141479279109079193/image.png)

  Queremos que esse inimigo fique andando de um lado para o outro, se movendo até uma posição expecífica e trocando de direção

  3. Crie um novo script de movimentação para seu inimigo
  4. Insira o seguinte código dentro de update (e defina a variável speed no início da classe)
  ```C#
  update()
  {
    transform.position += Vector3.right * speed;
  }
  ```
  Sabemos que isso fará o inimigo se deslocar para a direita infinitamente, para definir os limites do seu movimento, crie as seguintes variáveis no início da classe

  ```Cs
  public Vector3 startPosition;
  public Vector3 endPosition;
  ```
  
## UI
