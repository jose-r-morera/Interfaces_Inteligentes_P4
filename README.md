# P4: Delegados, Eventos

## 1
   ![Ejercicio1](img/1.gif)  
   Para detectar la colisión el cubo tiene un rigidbody cinemático. El cubo es un trigger y se emplea el evento OnTriggerEnter. Para que las esferas reaccionen a la colisión se emplea un script notificador que define un evento (función delegado) "OnCollision". Las esferas tienen un script suscriptor que tiene una referencia al notificador. Las de tipo 1 tienen un script y las de tipo 2 otro para que cada uan tenga el comportamiento deseado. Vemos como las esferas de tipo 1 persiguen a una de las de tipo2, que a su vez se desplaza hacia el cilindro.
## 2  
   ![Ejercicio2](img/2.gif)  
   Se sustituyen las esferas de tipo 1 por arañas zules, y las esferas de tipo 2 por arañas rojas. Se sustituye el cilindro por un huevo.
## 3
![Ejercicio3](img/3.gif)  
Cuando el cubo colisiona con cualquier araña de tipo 2, las arañas de tipo1 se acercan a un huevo de tipo1. Cuando el cubo toca cualquier araña de tipo 1, las arañas de tipo1 se dirigen a huevos del tipo2. Para cambiar el material de los huevos cuando colisiona una araña se accede al mesh renderer hijo del objeto de la colisión mediante "GetComponentInChildren" y se cambia el material a una copia con otro color. Se siguen unsando eventos y delegados para notificar a las arañas.
## 4
![Ejercicio4](img/4.gif)  
Las arañas de tipo1 se teletransportan al huevo verde de la derecha, las de tipo2 miran al huevo gris.
Se ha desactivado el script de animación de las arañas de tipo2 para que tras ejecutar la instrucción lookAt no cambien su rotación. Para el teletransporte se emplea el método translate acortando la distancia de movimiento una cantidad variable respecto al objetivo para que las arañas no se solapen dentro del huevo.
## 5
![Ejercicio5](img/5.gif)
Se aplica un teletransporte al huevo que se recolecta mediante "Translate", usando un vector aleatorio en los ejes x, z. La puntuación se almacena con una variable y se detecta la colisión con "OnTriggerEnter", siendo el cubo de tipo trigger, y teniendo los huevos colliders de esferas.

## 6
![Ejercicio6](img/6.gif)
Se muestra la puntuación con una interfaz en el Canvas mediante el texto de TextMeshPro. El script de la puntuación usa la librería TMPro para incorporar como variable un objeto de tipo TMP_Text cuyo valor se actualiza con el método "SetText()".

## 7
![Ejercicio7](img/7.gif)
La recompensa se implementa mediante una imagen de UI en forma de estrella. Se crea un prefab que se instancia con un cierto desplazamiento cada vez que se obtienen 100 puntos. Para ello se usa el método  Instantiate y una variable con referencia al prefab. También se necesita una variable con una referencia al Canvas para que la imagen se instancie como hija de él.

 ## 8
![Ejercicio8](img/8.gif)
El prototipo consiste en un escenario en el que los zombies persiguen al personaje hasta que consigue la estrella, momento en el que se quedan quietos 5 segundos.

## 9
![Ejercicio9](img/9.gif)
Se implementa el ejercicio 3 con físicas haciendo el cubo físico (no cinemático) y deshabilitandolo como trigger. Se le aplican fuerzas según las teclas pulsadas. Se hacen trigger las arañas.
