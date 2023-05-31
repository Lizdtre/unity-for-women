# Criando seu primeiro nível
## Adquirindo assets

Para esse tutorial, partiremos de um [projeto Unity](https://github.com/Duerno/unity-for-women-at-unb) que possui uma coleção de sprites prontos.

1. Baixe o repositório e extraia o arquivo .zip

![Download de repositório no Github](https://cdn.discordapp.com/attachments/1105270961391030293/1113536584994799676/image.png)

2. Em seguida, no Unity Hub, na aba Projects, clique em add/open e selecione a pasta “workshop” dentro da pasta do repositório baixado

![Open em Unity Hub](https://cdn.discordapp.com/attachments/1105270961391030293/1113537054714908764/image.png)

3. Selecione a versão 2019.4.9f1 LTS ou a versão mais próxima disponível
4. Abra o projeto

## Primeiros passos no projeto

⚠Projeto tem que ter aberto em uma tela vazia


### Alteração de um objeto numa cena

- Cena engloba tudo que está renderizado(ativo) no unity
- A alteração de um objeto pode ser feito dentro da cena ou na aba inspector 
- Algumas propriedades devem ser feitas na aba inspector  

Algumas alterações são:
1. Scale: Tamanho e proporções do objeto

2. Rotation: Rotação do objeto nos eixos x,y,z

3. Position: Posição do objeto na cena

4. Scene rotation: Rotação da Cena (a sua perspectiva como desenvolvedor)

![Locais das alterações no unity](https://cdn.discordapp.com/attachments/1105270961391030293/1113538043568197715/Object_shenags.png)


## Criação do nível

1. Clicando no objeto Câmera, garanta que está em modo orthographic e que os objetos que você criar a seguir estão dentro do campo de visão dela, é recomendado também trocar a perspectiva de edição para modo 2D

![Opções da câmera no Unity](https://media.discordapp.net/attachments/1105270961391030293/1113529900033388685/image.png?width=849&height=311)

2. Na aba project na parte inferior da tela, navegue até Assets > Part I > Scenes
   - Você verá uma cena chamada “Part I”, apague ela e crie uma nova (botão direito > Create > Scene) com o nome que desejar, em seguida abra-a

   ![Criação da cena nova](https://media.discordapp.net/attachments/1105270961391030293/1113525288752644107/image.png?width=514&height=412)
  
3. Na aba Hierarchy, crie um objeto vazio (Create Empty)

4. Com o novo objeto selecionado, adicione o componente sprite renderer

5. Abra o explorador de sprites e selecione um sprite de chão

![Adicionando Sprite](https://cdn.discordapp.com/attachments/1105270961391030293/1113538683723841678/image.png)

6. Para expandir o chão, crie cópias do objeto e alinha as cópias lado a lado
   - Segurar Ctrl pode facilitar o alinhamento

   ![Chão expandido](https://media.discordapp.net/attachments/1105270961391030293/1113539344284778676/image.png?width=704&height=412)

7. Para organização, crie um objeto vazio que guardará todos os chãos, e os insira dentro desse objeto

![Objeto Chão](https://media.discordapp.net/attachments/1105270961391030293/1113539931629961418/image.png?width=326&height=230)

8. Adicione a parte subterrânea do chão para preencher a tela, da mesma forma como anteriormente

### Criação do jogador

1. Crie uma sprite

2. Adicione o componente Rigidbody 2D

3. Adicione também um Box Collider 2D

4. Adicione um Box Collider 2D no objeto que guarda os chãos

5. Edite o collider para que fique igual ao contorno do chão (bottão Edit Collider)

-IMAGEM DA HITBOX DO COLIDER NO CHAO-

⚠ Certifique-se que o player e o chão estão na mesma posição Z


### Movimentação de Jogador

1. Clique em edit > project settings
2. Na nova aba aberta, clique em input manager > Axes > Horizontal
3. Configure os botões negativo e positivo como “a” e “d” respectivamente
4. No objeto do jogador, adicione um novo componente “new script”
5. Dê um nome distinto (ex.: PlayerMovement)

⚠ Formatação para nome de script
- O script deve começar com letra maiúscula e não pode conter espaço 

6. Abra o script recém criado
- O script padrão do unity contém:
  - Void Start(): Função chamada no mesmo frame que o objeto que possui o script for instanciado
  - Void Update(): Chamada todo frame subsequente


