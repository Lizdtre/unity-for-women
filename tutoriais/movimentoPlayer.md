Nesse tutorial iremos mostrar como fazer o objeto player interagir com a fase

## Adicionando física

### Rigid Body
1. Vá nas configurações do objeto
2. Clique na opção no fim para adcionar um novo componente
3. Procure por "rigid body"
4. O player tera fisica

### Collider
- Essa estrutura tem que ser adicionada para ambos player e chão
  
1. Vá nas características do objeto novamente
2. Desca para a parte de "add component"
3. Procure por "box colider"





## Movimento

1. Crie um script ou clique na opção "add componet"
2. Escreva o nome que você vai dar a seu script
3.  dê um nome ainda não usado para criar o script (Ex: player)
4. Abra o script

- O script Unity vem com funções especificas do Unity. Sendo elas:
- void start: Esta função é ativada no primeiro frma do jogo
- void update: Esta é ativida a cada frame

````
function
````

````
fucntion
````



```
transform.position += Vector3.right;


    transform.position += speed * Vector3.right;


    var inputX = Input.GetAxis("Horizontal");
    transform.position += inputX * speed * Vector3.right;

   ```
