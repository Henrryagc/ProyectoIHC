# ProyectoIHC
Proyecto de realidad aumentada, carrera de coches, curso de Interacción Humano Computador

# Ventanas del juego
Para el proyecto se ha desarrollado varios escenarios, cada uno de ellos muestra una diseño y funcionalidad para una tarea específica dependiendo el usuario, tenemos dos usuarios: el conductor y el copiloto. Ellos se comunicarán de manera remota para realizar interacciones dentro del escenario principal, el escenario principal cuenta con una pista de carreras, también con una serie de paneles como el chat botón de llamada y panel de información. Todas las ventanas se describen más adelante.
## Ventana de Inicio
La ventana de inicio cuenta con unos campos y botones, que serán llenados y elegidos de acuerdo con el usuario “conductor/copiloto”. De modo que en el siguiente escenario se le cargara la ventana según la elección.
Datos para ingresar:
-	Nombre
-	Conductor o copiloto

## Ventana para el Conductor
La siguiente venta se cargará si en la ventana anterior se eligió ingresar como conductor, en este escenario se muestran tres paneles:
-	El primer panel: que se encuentra en la parte superior izquierda de la imagen, se muestra una imagen de teléfono, la imagen es un botón que al pulsarlo se realiza una llamada al copiloto.
-	El segundo panel: que se encuentra en la parte superior derecha de la imagen, se muestra un nombre “Nombre con el que ingreso al juego”, un icono de la estación de combustible junto a una barra de estado que indican la cantidad de combustible y por último un ícono de panel de velocidad y la velocidad.
-	El tercer panel: se encuentra en la parte lateral derecha de la imagen, dónde se muestra un título, un botón de cerrar, un panel, una caja de texto y botón de enviar (send); toda esa ventana pertenece a la ventana de chat, en la que se comunicarán los usuarios mediante el envío de texto.

## Ventana para el Copiloto
En esta ventana se mostrará unos paneles similares al del copiloto con la diferencia del botón que activa al chat y el botón que cambia de cámaras. Para el escenario del copiloto se depusieron dos cámaras, que interactuarán cada que se pulse el botón “Cambiar camara”, una vez presionada se visualizara la “pantalla 01” con una vista mucho más panorámica de circuito.

### Ventana 01


### Ventana 02
Esta ventana se activara cuando se presione el botón de “cambiar camara”, como se ve en la imagen, cuenta con un diseño similar al del conductor pero con la diferencia de que el conductor no puede visualizar todo el circuito o mapa.

## Resultado
En las siguientes imágenes vemos los resultados del desarrollo final del proyecto de aplicación, el conductor y el copiloto interactúan mediante una videollamada, el copiloto ayudando a navegar al conductor por el circuito.
