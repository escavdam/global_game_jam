# Brainstorming

- Lo contrario. Un mundo en el que todo el mundo ríe, nuestro prota no sabe como hacerlo y tiene que buscar el chiste que le haga reir por primera vez.
- Cada vez que pasa delante de un NPC este le diga un chiste. Tiene que buscar el chiste que le haga reír para poder experimentar por primera vez lo que se siente al reirse.

# SÍ, LO SÉ, ES MUY POCA COSA, PERO SI LAS DEMÁS IDEAS SON DEMASIADO COMPLICADAS PODEMOS HACER COSAS CON ESTA.

Movimiento necesario para que sea como los pokemons:
```C#
 Vector3 movement = Vector3.zero;

 if (Input.GetKey(KeyCode.W))
 {
     movement += Vector3.up;
 }

 if (Input.GetKey(KeyCode.A))
 {
     movement += Vector3.left;
 }

 if (Input.GetKey(KeyCode.S))
 {
     movement += Vector3.down;
 }

 if (Input.GetKey(KeyCode.D))
 {
     movement += Vector3.right;
 }

 movement = movement.normalized;
 transform.position += movement * speed * Time.deltaTime;
```
