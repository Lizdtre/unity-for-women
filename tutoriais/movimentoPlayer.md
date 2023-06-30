Nesse tutorial iremos mostrar como fazer o objeto player interagir com a fase

## Colisão

1. Vá nas configurações do objeto
2. Clique na opção no fim para adcionar um novo componente
3. procure por "rigid body"
4. 



## Movimento




```
transform.position += Vector3.right;


    transform.position += speed * Vector3.right;


    var inputX = Input.GetAxis("Horizontal");
    transform.position += inputX * speed * Vector3.right;

   ```
