# PokeDexBackend

## Estructura
Para el desarrollo de las funcionalidades de esta prueba técnica, decidí hacer uso de una arquitectura limpia, dividiendo el problema en los siguiente proyectos

- ### Dominio: 
En este apartado guardo las entidades que contienen las reglas de negocio, las cuales están totalmente aisladas a cualquier factor externo.
- ### Aplicación: 
A este nivel definí los contratos necesarios para poder cumplir con las funcionalidades, los casos de uso en los cuales se implementó el patro CQRS con el fin de hacer la aplicación escalable y de esa manera separar las responsabilidades de creacion y/o modificación de datos con la de solo lectura. para esto me apoyé en el nuget MediatR el cual permite facilitar la implemetnación del patrón mediador. También a este nivel definí múltiples objetos de transferencia de datos los cuales son mappeados entre sí mediante el nuget Automapper. Además es importante mencionar que en este apartado definí un repositorio genérico, el cual permite que la aplicación sea escalable en cuanto se agreguen mas casos de uso
- ### Infraestructura: 
En este proyecto definí las operaciones concretas para poder brindarle funcionalidad a los contratos definidos en la capa de aplicación. también definí un HttpClient para el consumo de la API de Pokemones.
- ### Presentación:
Ya en esta capa, que es donde se debe definir todo lo relacionado con la interfaz del cliente, definí una aplicación de consola, la cual le instalé los plugins necesarios para realizar la inyección de dependencias y así registrar los contenedores creados en Aplicación e Infraestructura, y la configuración para obtener valores desde un archivo appsettings.json