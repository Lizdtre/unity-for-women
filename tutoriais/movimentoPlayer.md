

# Adicionando movimento ao jogador

## Adicionando física

### Colisão
- Antes de adicionar a física, os objetos precisam ser capazes de interagir entre si, para isso os daremos um corpo físico

### Corpo físico

1. Selocione o seu objeto player
2. Clique na opção "add component"
3. Procure pela opção "Rigidbody 2D"
  O player terá fisica

### Colisões

- Essa estrutura tem que ser adicionada para ambos player e chão
  
1. Vá nas características do objeto novamente
2. Adicione um componente
3. Procure por "Box Collider 2D"
4. Clique para editar a caixa de colisão

  ![Botão de editar collider](https://media.discordapp.net/attachments/1105270961391030293/1124346156546273330/image.png?width=416&height=316)

5. Tente deixar a caixa de colisão o mais próximo o possível do formato dos objetos

⚠ Certifique-se que o player e o chão estão na mesma camada em Z, ou a colisão não irá funcionar

Ao rodar o jogo agora, o player terá gravidade e colidirá com o chão a cair, porém, ainda não temos controle sobre ele

## Movimento por transform

Existem algumas formas de adicionar movimento ao jogador, a mais símples é utilizando o componente transform dos objetos, que dita sua posição dentro do jogo

  
### Script

1. Para criar um script, adicione um componente ao player com um nome original (ex.: "PlayerMovimentation") e clique em New Script
2. Abra o script recém criado

- Os scripts Unity vem com funções especificas do Unity. Sendo elas:

```
void Start()
```
Tudo dentro desta função irá rodar uma única vez quando o objeto for criado (ou quando a cena for carregada)


```
void Update()
```
Tudo dentro desta função irá rodar continuamente todo frame que o objeto estiver ativo


3. Dentro de Update(), Insirá o seguinte código

```C#
void Update()
{
  transform.position += Vector3.right;
}
```
  ⚠ Sempre salve quaisquer alterações feitas em scripts

  Ao rodar o jogo, você deverá ver o player ir para a direita extremamente rápido, para controlar sua velocidade, podemos fazer a seguinte mudança

```C#
void Update()
{
  transform.position += speed * Vector3.right;
}
```

  E defina a variável speed como um float(número real) no início do script

```C#
public class PlayerMovimentation : MonoBehaviour
{
    public float speed = 0.1f;
      .
      .
      .
```

  Variáveis definidas com "public" podem ser acessadas diretamente pelo editor Unity

  ![Editando a variável durante execução](https://cdn.discordapp.com/attachments/1105270961391030293/1126910382817161257/ezgif-2-6ec952770d.gif)

### Inputs
1. No canto superior esquerdo, clique em edit > Project Settings
2. Na nova janela aberta, clique em Input Manager > Axes > Horizontal
3. Defina os botões negativo e positivo com as teclas que quiser usar para mover o player para a esquerda e para a direita, respectivamente

  ![Input Maganer](https://cdn.discordapp.com/attachments/1105270961391030293/1126883320458924102/image.png)

Para permitir que o player seja controlado pelo teclado, fazemos essa modificação dentro de Update()
  
```C#
void Update()
{
    var inputX = Input.GetAxis("Horizontal");
    transform.position += inputX * speed * Vector3.right;
}
```

   ![Player sendo controlado pelo teclado](https://media.discordapp.net/attachments/1105270961391030293/1126913829171904593/ezgif-2-1672155832.gif?width=719&height=404)
   
## Movimento por Rigidbody2D
Outra maneira de fazer a movimentação do jogador é utilizando seu componente Rigidbody2D, que dita sua velocidade

Para poder interagir com o Rigidbody2D dentro do script, precisamos primeiro defini-lo como um componente da nossa classe 

1.  Declare um novo componente público de tipo Rigidbody2D
```C#
public class PlayerMovimentation : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float maxSpeed = 1f;
	.
	.
	.
}
```
2. Dentro de Start(), escreva a seguinte linha
```C#
	void Start()
	{
		myrigidbody = GetComponent<RigidBody2D>();
	}
```

3. Depois de salvar o script, no Unity você verá uma nova variável no componente script do jogador com um valor "None". Para arrumar isso, clique e segure o RigidBody2D do jogador e leve-o até aquela caixa.

	![Arrastando o componente](https://cdn.discordapp.com/attachments/1105270961391030293/1129450931445051432/this_one.png)

5. Para movimentar o jogador através do Rigidbody2D, escreva o seguinte código em Update()
```C#
	void Update()
	{
		var inputX = Input.GetAxis("Horizontal");
		myrigidbody.velocity = new Vector2(inputX * maxSpeed, myrigidbody.velocity.y);
	}
```


## Pulo

  Para permitir que o player pule, ao invés de atualizar sua velocidade vertical todo frame como para o movimento horizontal, verificaremos primeiro SE o player está apertando o botão de pulo

1. Dentro de Project Settings > Input Manager, vá em Jump e defina o botão positivo assim como feito anteriormente. (escreva "space" caso queira utilizar a barra de espaço)

2. Dentro de Update(), adicione o seguinte código
```C#
	void Update()
	{
		var x = Input.GetAxis("Horizontal");
		myrigidbody.velocity = new Vector2(x*speed, myrigidbody.velocity.y);
        
        if (Input.GetButton("Jump")) {
			Debug.Log("Você Pulou!");
        }
	}
```

Quando apertarmos o botão de pulo, uma mensagem aparecerá no console de debug

![Console de Debug](https://media.discordapp.net/attachments/1105270961391030293/1129453759194468443/image.png?width=599&height=508)

3. Dentro da condição if, insira o seguinte código
```C#
	void Update()
	{
		var inputX = Input.GetAxis("Horizontal");
		myrigidbody.velocity = new Vector2(inputX * maxSpeed, myrigidbody.velocity.y);
        
        if (Input.GetButton("Jump")) {
			Debug.Log("Você Pulou!");
			myrigidbody.velocity += Vector2.up * jumpSpeed;
        }
	}
```
E declare a variável jumpSpeed no início da classe
```C#
public class PlayerMovimentation : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float maxSpeed = 1f;
    public float jumpSpeed = 0.5f;
    .
    .
    .
}
```


