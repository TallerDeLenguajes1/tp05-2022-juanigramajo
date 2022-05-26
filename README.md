# tp05-2022-juanigramajo

## Ejercicio 4.
# Responder las siguientes preguntas en el archivo readme.md
- ¿String es una tipo por valor o un tipo por referencia?
- ¿Qué secuencias de escape tiene el tipo string?
- ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?


## ¿String es una tipo por valor o un tipo por referencia?

Un tipo de referencia almacena una referencia a sus datos. Entre los tipos de referencia se incluyen los siguientes:
- String
- Todas las matrices, incluso si sus elementos son tipos de valor
- Tipos de clase, como Form
- Delegados


## ¿Qué secuencias de escape tiene el tipo string?

- \a	Campana (alerta)
- \b	Retroceso
- \f	Avance de página
- \n	Nueva línea
- \r	Retorno de carro
- \t	Tabulación horizontal
- \v	Tabulación vertical
- \'	Comilla simple
- \"	Comillas dobles
- \\	Barra diagonal inversa
- \?	Signo de interrogación literal
- \ooo	Carácter ASCII en notación octal
- \xhh	Carácter ASCII en notación hexadecimal
- \xhhhh	Carácter Unicode en notación hexadecimal si esta secuencia de escape se utiliza en una constante de caracteres anchos o un literal de cadena Unicode.


## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Las cadenas interpoladas se identifican mediante el  $  carácter especial e incluyen expresiones interpoladas entre llaves.

El @ antes de una cadena de texto indica que una cadena debe interpretarse textualmente, es decir, se interpretará la cadena sin importar códigos de escape delante de la cadena.