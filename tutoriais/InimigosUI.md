# Inimigos e UI

## Inimigos
  Vamos adicionar uma ameaça ao nosso jogo na forma de um inimigo que fica andando de um lado para o outro

  1. Crie um novo objeto e dê o sprite que quiser
  2. Adicione um Collider2D e customize o formato

  ![Inimigo com collider](https://cdn.discordapp.com/attachments/1105270961391030293/1141479279109079193/image.png)

  Queremos que esse inimigo fique andando de um lado para o outro, se movendo até uma posição expecífica e trocando de direção

  3. Crie um novo script de movimentação para seu inimigo
  4. Insira o seguinte código dentro de Update() (e defina a variável speed no início da classe)
  ```C#
  update()
  {
    transform.position += Vector3.right * speed;
  }
  ```
  Sabemos que isso fará o inimigo se deslocar para a direita infinitamente
  5. Para definir os limites do seu movimento, crie as seguintes variáveis no início da classe

  ```C#
  public Vector3 startPosition;
  public Vector3 endPosition;
  private int direction = 1;
  ```

  E adicione este código em Update()
  ```C#
  Update()
  {
    transform.position += Vector3.right * speed * direction;

    if (Vector3.Distance(transform.position, startPosition) <= 0.1f)    // if acontece quando o inimigo está dentro de 0.1 unidades de distância da posição final
    {
      direction = 1;         // Direção = direita
    }
    
    if (Vector3.Distance(transform.position, endPosition) <= 0.1f)    // if acontece quando o inimigo está dentro de 0.1 unidades de distância da posição final
    {
      direction = -1;        // Direção = esquerda
    }
  }
  ```
  
  ⚠ Note que simplesmente fazer "transform.position == endPosition" não vai funcionar devido as posições serem floats, é possível que o inimigo ultrapasse a posição final sem que a condição se torne verdadeira

  ![]() INSIRA GIF AQUI

### Prefabs
  Agora que temos nosso objeto inimigo criado, podemos querer ter varios inimigos idênticos espalhados pela fase, todos com as mesmas propriedades.

  Podemos fazer isso simplesmente copiando e colando o inimigo por ai, mas uma forma muito mais prática é tornar o inimigo em um prefab(pre-fabricated object), um inimigo pronto que podemos adicionar à fase sempre que precisarmos.

  Outra vantagem de prefabs é que alterações ao prefab se aplicam a todas as suas instâncias na fase, ou seja, podemos, por exemplo, mudar o sprite do inimigo alterando somente o prefab, sem ter que achar todos os inimigos no nível e alterar seus sprites individualmente(também é possivel modificar instâncias expecíficas de prefabs).

  1. Para fazer isso, simplesmente arraste seu objeto inimigo da Hierarchy para o local desejado na janela Project

  Se tudo der certo, o inimigo irá aparecer dentre os seus arquivos e o inimigo já existente ficará com texto azul

  ![Criação de prefab](https://cdn.discordapp.com/attachments/1105270961391030293/1141494091641798718/image.png)
  
  
## UI
