# Configurando o ambiente:

## Adquirindo o Unity Hub

1. Download
   - https://unity.com/pt/download

      ou 
   - https://unity.com/download
   
   ![Página de instalação do Unity Hub, com os links de download de cada OS](https://cdn.discordapp.com/attachments/1105270961391030293/1109909460933156984/image.png)

2. Instalação
   1. Linux
      - Abra o terminal (ctrl + alt + T)
      - Acesse sua pasta de downloads (ou a pasta onde você fez o download do instalador) utilizando o comando cd
      - Rode os comandos abaixo:
        - chmod +x UnityHub.appimage
        - ./UnityHub.appimage
      
   2. Windows/MAC
      - Execute o instalador
      - Siga o processo normalmente

## Configurando o Unity Hub:
Caso apareça a tela de licença, você pode ativar uma licença gratuita Unity Personal ou, se quiser, adquirir uma licença de estudante universitário utilizando suas credenciais institucionais
   1. Clique em Install > Install Editor ou Add
   ![Install Editor no Unity Hub](https://cdn.discordapp.com/attachments/1105270961391030293/1109910774194905088/image.png)
   
   2. Selecione a versão LTS(Long Term Support) mais recente e clique Install
   ![Seleção de versões para instalação](https://media.discordapp.net/attachments/1105270961391030293/1109911748972126269/image.png?width=642&height=440)
   
   3. Na tela de módulos, desselecione as outras opções caso necessário
   4. Remova versões anteriores anteriores caso necessário

## Criando um projeto Unity
   1. Clique em project > New project
   2. Selecione o template 3D e nomeie seu projeto como desejar
   3. Clique em seu projeto recém criado para abri-lo


## Plugin de Unity Hub para Visual Studio Code
   1. Selecione na aba de extensões 
   2. Pesquise e selecione o Unity Tolls na aba de extensão para baixa-lo 
   3.
   4.
   
   [Suporte para caso o VSCode não esteja mostrando sugestões de código para Unity](https://code.visualstudio.com/docs/other/unity)
 ## Básicos do Unity
   ### Movimentos
   - Clique e segure com o botão direito enquanto move o mouse na tela interativa para movimentar a perspectiva lateralmente
   - Use a rodinha do mouse para movimentar-se para frente e para trás
   - Apertar e segurar a rodinha do mouse permite movimentos mais dinâmicos
   - Segure Shift durante qualquer movimento para acelerá-lo

   
   ### Câmera
   - Representa a perspectiva do jogador.
   - Pode-se alterar entre a perspectiva de jogador e developer com as abas “Game” e “Scene” na parte superior da tela 
   - Clicando na câmera mostra a parte do ambiente 3D que será mostrada no jogo (Também pode ser visto através da aba Game)
     
   ### Obejeto e Componente
   1. Para criar seu primeiro objeto:
      - Na aba hierarquia à esquerda, clique com o botão direito e selecione 3D Object > Cube

![Criando um cubo](https://cdn.discordapp.com/attachments/1105270961391030293/1109911523268231249/image.png)

   2. Para adicionar física ao seu objeto, utilizaremos um componente chamado RigidBody:
      - Clique no objeto para exibir seus componentes a aba “Inspector” na direita 
      - Clique em “Add Component” no fim da aba
      - Busque e adicione a opção RigidBody

 ![Selecionando o RigidBody para o cubo](https://cdn.discordapp.com/attachments/1105270961391030293/1109911836217835662/image.png)

   ### Testar jogo
   - Clique o botão play na parte superior para começar a execução do jogo
   - Você deverá observar o cubo criado caindo
   - Nos controles superiores, você pode pausar ou parar a execução (clicando novamente em play)
   - Lembre-se de pará-la sempre antes de fazer modificações em objetos (ou elas poderão ser perdidas)
