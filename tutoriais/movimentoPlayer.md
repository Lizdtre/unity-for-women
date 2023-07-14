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

## Movimento

  Ao rodar o jogo agora, o player terá gravidade e colidirá com o chão a cair, porém, ainda não temos controle sobre ele

### Inputs
1. No canto superior esquerdo, clique em edit > Project Settings
2. Na nova janela aberta, clique em Input Manager > Axes > Horizontal
3. Defina os botões negativo e positivo com as teclas que quiser usar para mover o player para a esquerda e para a direita, respectivamente

  ![Input Maganer](https://cdn.discordapp.com/attachments/1105270961391030293/1126883320458924102/image.png)

  
### Script

1. Para criar um script, adicione um componente ao player com um nome original (ex.: "PlayerMovementation") e clique em New Script
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
  transform.position += Vector3.right;
```
  ⚠ Sempre salve quaisquer alterações feitas em scripts

  Ao rodar o jogo, você deverá ver o player ir para a direita extremamente rápido, para controlar sua velocidade, podemos fazer a seguinte mudança

```C#
  transform.position += speed * Vector3.right;
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

4. Para permitir que o player seja controlado pelo teclado, fazemos essa modificação dentro de Update()
  
```C#
    var inputX = Input.GetAxis("Horizontal");
    transform.position += inputX * speed * Vector3.right;
```

   ![Player sendo controlado pelo teclado](https://media.discordapp.net/attachments/1105270961391030293/1126913829171904593/ezgif-2-1672155832.gif?width=719&height=404)

## Pulo

  Para permitir que o player pule, ao invés de atualizar sua velocidade vertical todo frame como para o movimento horizontal, verificaremos primeiro SE o player está apertando o botão de pulo

1. Repita o mesmo processo feito anteriormente para definir os inputs, dessa vez com o eixo vertical (defina o botão positivo)

2. Dentro de update, insira o seguinte código
