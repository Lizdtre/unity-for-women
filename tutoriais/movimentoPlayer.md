Nesse tutorial iremos mostrar como fazer o objeto player interagir com a fase

## Adicionando física

### Rigid Body
1.1. Vá nas configurações do objeto
1.2. Clique na opção no fim para adcionar um novo componente
1.3. procure por "rigid body"
1.4. O player tera fisica

### Collider
2.1.





## Movimento




```
transform.position += Vector3.right;


    transform.position += speed * Vector3.right;


    var inputX = Input.GetAxis("Horizontal");
    transform.position += inputX * speed * Vector3.right;

   ```
