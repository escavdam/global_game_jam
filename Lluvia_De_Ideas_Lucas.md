# Mecanicas:

-Saltar:

```C#
if (Input.GetKeyDown(KeyCode.Space))
{
    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
}
```

Posibilidad de Juego:

un plataformas, con personaje que pelea con diferentes enemigos / boss final, 

se compone de diferente batallas, de elección multiple en el que tenemos que decidir cual es la opcion correcta.
Conforme vas pasando de enemigos, el numero de opciones correctas disminuye. Es decir si en el primer enemigo tiennes 4 opciones para elgir, 2/4 sean las correctas, y con el enemigo nº3 la opcion correcta sera 1/4. Para el 
jefe final encontraremos que las opciones seran 6-8, y la opcion correcta sera 1/8 esas elecciones.

En el camino que empezara el jugador, tendra una similitud de movimiento de un plataformas. Incluyendo saltos, gravedad..... hasta llegar a los distintos enemigos.
-Movilidad del jugador.

-
