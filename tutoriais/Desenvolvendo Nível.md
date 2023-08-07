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
   
