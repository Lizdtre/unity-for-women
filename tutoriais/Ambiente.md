# Configurando o ambiente:

## Adquirindo o Unity Hub

1. Download
   - https://unity.com/pt/download

      ou 
   - https://unity.com/download

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
   2. Selecione a versão LTS(Long Term Support) mais recente
   3. Desselecione as outras opções
   4. Remova versões anteriores anteriores caso necessário

## Criando um projeto Unity
   1. Clique em project > New project
   2. Selecione o template 3D e nomeie seu projeto como desejar
   3. clique em seu projeto recém criado para abri-lo


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
   - Segurar a rodinha do mouse permite movimentos mais dinâmicos
   - Segure Shift durante qualquer movimento para acelerá-lo

   
   ### Câmera
   - Representa a perspectiva do jogador.
   - Pode-se alterar entre a perspectiva de jogador e developer com as abas “Game” e “Scene” na parte superior da tela 
   - Clicando na câmera mostra a parte do ambiente que será mostrada no jogo (Também pode ser visto através da aba Game)
     
   ### Obejeto e Componente
   1. Para criar seu primeiro objeto:
      - Na aba hierarquia à esquerda, clique com o botão direito e selecione 3D Object > Cube

   2. Para adicionar física ao seu objeto, utilizaremos um componente chamado RigidBody:
      - Clique no objeto para exibir seus componentes a aba “Inspector” na direita 
      - Clique em “Add Component” no fim da aba
      - Busque e adicione a opção RigidBody


