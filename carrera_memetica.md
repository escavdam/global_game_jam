# Carrera memetica

Tienes 2 minutos para intentar hacer reir al maximo numero de personas posible.
En tu camino te encontraras con diferentes tipos de personas, cada una con sus propios gustos y preferencias.
Cada persona tiene:
  - Unos memes preferidos
  - Unos memes que les dan asco
  - Unos memes que les confunden

Al comienzo del juego, te dan 3 memes aleatorios.

El jugador se mueve delante del npc y debe seleccionar un meme que tenga en su inventario.
    - Si es uno de los memes preferidos del npc, ganas un punto y avanzas
    - Si le da asco, pierdes una vida y avanzas
    - Si le confunde, quien sabe que hara? puede que queme uno de tus memes, puede que te regale otros 2, puede que te sane, cogeremos de un pool aleatorio de funciones que ejecuten cambios simples, y nos da algo de campo para experimentar.

Cuando acabas un combate, te dan a elegir un meme entre dos **QUIZAS AQUI** es el unico momento donde podriamos mostrar informacion sobre como afectan a los diferentes tipos de personas que apliquemos el meme.

Una simplificacion del juego seria algo asi:

```
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫🪜🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫🟫🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫💀🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜💖⬜3️⃣⬜⬜⬜⬜⬜🟫🟫🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜👌⬜9️⃣⬜⬜⬜⬜⬜🥳🟫🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫🟫🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫🟫🤠⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫🟫🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜👽🟫🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫🟫🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫🟫🤡⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫🟫🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🤖😛🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜🟫🟫🟫⬜⬜⬜⬜⬜⬜⬜⬜⬜
🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨
🟨🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟨
🟨🟪🟪🟩🟩🟩🟪🟥🟥🟥🟪🟧🟧🟧🟪🟩🟩🟩🟪🟪🟨
🟨🟪🟪🟩🟩🟩🟪🟥🟥🟥🟪🟧🟧🟧🟪🟩🟩🟩🟪🟪🟨
🟨🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟪🟨
🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨

⬜ mapa
🟫 suelo, marca el camino
🟪🟨 espacio para ui
😛 jugador
🤖🤡👽🤠🥳💀 enemigos
💖 vidas
👌 puntos
🪜 escalera para siguiente nivel
```
## 😛

El jugador puede moverse en todas direcciones, pero solo por el camino marcado 🟫

El jugador tiene *n* vidas 💖, *n* memes y 0 puntos 👌 al inicio del juego

### Alternativa

Podemos hacer que el juego vaya automaticamente avanzando? La mecanica de dar meme y coger meme quedará mas fluida asi, pero no se si es lo que queremos.

## 🤖🤡👽🤠🥳💀

Los enemigos son estaticos y no se mueven, pero no permiten el paso hasta que se les muestra un meme y nos dan una respuesta.

## 🟪🟨

Tenemos bastante espacio disponible ocupando algo similar al ascii superior, incluyendo algunas zonas que tenemos libres aun.

¿Podemos tener un numero infinito de memes en nuestro poder? ¿O tenemos que limitarlas al espacio que diseñemos?

## Memes

Los memes son nuestra herramienta principal, podemos entenderlas como un objeto:

```json
{
    "img": "meme1.png",
    "sound": "sample2.mp3",
    "gusta": ["🤖", "🤡"],
    "asco": ["👽", "🤠"],
    "confunde": ["🥳", "💀"]
}
```

Cada meme tiene una imagen, un sonido, y una lista de emojis que representan a los diferentes tipos de personas a los que afecta y como.

Obtenemos *n* memes al principio del juego, pero cada vez que acabamos un combate, nos dan a elegir entre dos memes, y podemos quedarnos con uno de ellos. Adicionalmente, cuando avanzamos de nivel bajando las escaleras, nos dan otros 3 nuevos memes.

Además, podemos reusar el espacio de la ui para mostar información acerca de que efectos tiene el meme sobre los diferentes tipos de enemigos.

>Tenemos que tener en cuenta que añadir mas enemigos hace que tengamos que actualizar **TODOS** los memes.

## Loop de juego

1. El jugador se mueve por el mapa / avanza automaticamente
2. El jugador selecciona el meme a usar contra el NPC
3. El NPC responde
4. El jugador selecciona un meme nuevo para añadir a su inventario
5. Volvemos al paso 1

[![](https://mermaid.ink/img/pako:eNp1kMFOAzEMRH_F8gmk9gf2wIVyRUhw9MUkbhtInJU3oUJV_52sV5wQt8x4_DzKFUONghMec72EM1uDtwMpadLU7gifMnz0E8dqsAiULl8C8xCSofDMhPekoZZ3_hPOEkKqymuUtEgRYOgLG4Sqzdx_fnl0gskyb_vDgVVVjeIjlcu_5K7gXB21qqe33rDfP8DW6redWyt4O-ZyoJ3vYt3DHRaxwimOD7mSAhC287hAOI1nZPskJL2NHPdWX7814NSsyw77HLnJIfHJuOB05LzI7Qd663ff?type=png)](https://mermaid.live/edit#pako:eNp1kMFOAzEMRH_F8gmk9gf2wIVyRUhw9MUkbhtInJU3oUJV_52sV5wQt8x4_DzKFUONghMec72EM1uDtwMpadLU7gifMnz0E8dqsAiULl8C8xCSofDMhPekoZZ3_hPOEkKqymuUtEgRYOgLG4Sqzdx_fnl0gskyb_vDgVVVjeIjlcu_5K7gXB21qqe33rDfP8DW6redWyt4O-ZyoJ3vYt3DHRaxwimOD7mSAhC287hAOI1nZPskJL2NHPdWX7814NSsyw77HLnJIfHJuOB05LzI7Qd663ff)
