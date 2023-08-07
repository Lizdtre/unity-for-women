# Desenvolvendo um nível
## Expandindo a fase

![Nível maior](https://media.discordapp.net/attachments/1105270961391030293/1138155828591988897/image.png?width=987&height=502)

Podemos expandir o nível já criado utilizando as ferramentas que já vimos anteriormente. Lembre-se de manter a organização dos blocos do chão e dos planos de fundo.

## Movimento da câmera

Como jogadores, ainda não podemos navegar essa fase, pois a câmera não segue o personagem.
Assim como fizemos para movimentar o jogador, podemos adicionar à câmera um script para movimentá-la também, já que a câmera também é um objeto manipulável.

1. Crie um novo script para a câmera, e dê um nome como "CameraMovimentation" ou algo similar

Queremos que a nossa câmera siga o jogador, para isso precisamos saber onde ele está dentro do script

2. Antes de Start() e Update(), crie a seguinte variável pública, que servirá de referência ao jogador:
   ```C#
   public class CameraMovimentation : MonoBehaviour
   {
      public GameObject player;
      .
      .
      .
   }
   ```

3. Salvando o código, volte no editor e arraste o objeto jogador até a caixa correspondente à essa variável no inspetor
   
   ![Linkando um objeto à uma variável pelo editor](https://media.discordapp.net/attachments/1105270961391030293/1138160991784403056/image.png?width=1013&height=411)
  ⚠ Lembre-se desse processo de atribuir componentes/objetos à variáveis públicas pelo editor, não a ilustraremos mais a partir daqui

Agora poderemos acessar propriedades do jogador como sua posição dentro do script da câmera

4. Dentro de Update(), insira o seguinte código:
   ```C#
   void Update()
   {
      transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
   }

   ```


Note que "transform.position" se refere à posição do objeto que possui o script que estamos escrevendo, neste caso a câmera, enquanto "player.transform.position" se refere a posição do jogador

Esse código fará com que a câmera se movimente horizontalmente para seguir o personagem, mas não verticalmente

A câmera continuará se movimentando onde quer que formos, podendo expor as partes que não queremos que o jogador veja

   
   ![GIF bordas da fase](https://cdn.discordapp.com/attachments/1105270961391030293/1138166371155451934/ezgif-5-15d373520c.gif)

5. Para resolver isso, definimos limites ao movimento da câmera
   ```C
   public class CameraMovimentation : MonoBehaviour
   {
      public GameObject player;

      public float minCameraPosition = 0;
      public float maxCameraPosition = 50;
      .
      .
      .
   }
   ```
   ```C#
   void Update()
   {
      if(player.transform.position.x >= minCameraPosition && player.transform.position.x <= maxCameraPosition)
      {
         transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
      }
   }
   ```


   ![GIF camera limitada](https://cdn.discordapp.com/attachments/1105270961391030293/1138169314051117167/ezgif-5-49fbdd9a31.gif)

## Adicionando obstáculos
   Com as mecânicas básicas de movimento feitas, agora você pode criar um nível símples como quiser!
   Adicione plataformas e obstáculos símples, e altere as variáveis de velocidade e pulo do jogador caso ache necessário
   
   ⚠ Lembre-se que todos os objetos sólidos precisam ter um collider, você pode addicionar um collider à cada bloco individual de terra/grama caso prefira, para que você possa copiar e colar os objetos à vontade

   Adicione também um objeto, como uma moeda, para ser o objetivo da fase

   ![Fase com obstáculos e objetivo](https://media.discordapp.net/attachments/1105270961391030293/1138173132260257873/image.png?width=962&height=213)
