## Resolución TP6

#### ¿String es un tipo por valor o un tipo por referencia?
El String es un tipo por referencia, es decir se usa y pasa la dirección del puntero. Sin embargo, a diferencia de otros lenguajes, al hacer una comparación (== ; !=), estas responden al valor del objeto, y no a la dirección, por lo que es más fácil. En otros lenguajes comparar Strings así resulta siempre en False (direcciones distintas)
	
#### ¿Qué secuencias de escape tiene el tipo string?

Secuencias de escape:

' - comilla simple

" - comillas dobles

\ - barra invertida

\0 - nulo

\a - alerta

\b - retroceso

\f - alimentación de formulario

\n - nueva línea

\r - retorno de carro

\t - pestaña horizontal

\v - pestaña vertical

\u - Secuencia de escape Unicode (UTF-16)

\U - Secuencia de escape Unicode (UTF-32)

\x - Secuencia de escape Unicode similar a "\u" excepto con longitud variable

#### ¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?

En este caso se interpreta como un literal de cadena textual, donde, a diferencia de los literales con comillas, no se procesan las secuencias de escape.

### Expresiones Regulares

Las expresiones regulares, tambien conocidas como regex, son una secuencia de caracteres que conforma un patrón.

#### ¿Funcionan únicamente en C#?

Su funcion se extiende más allá de este lenguaje, utilizándose en muchos procesadores de texto como sublime o notepad++.

#### ¿En qué casos le parecen útiles? Enuncie al menos 3.

- Para realizar búsquedas avanzadas
- Para crear diccionarios de contraseñas para fuerza bruta
- Para crear filtros
- Para verificar datos, que tengan que cumplir ciertos patrones, como emails

#### ¿Cómo se hace uso de estas en C#?

Para usar expresiones regulares en C#, se hace uso de la clase Regex.