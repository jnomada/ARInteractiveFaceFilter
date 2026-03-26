# ARInteractiveFaceFilter
## Cambios hechos

- He añadido tres prefabs nuevos al "glasses group", dos máscaras y un bigote ya que el "AR Face Manager" utiliza este grupo para mostrar los gameobject en la cara. Les he dado un tag único a cada uno.
- En el AR_Canvas he añadido otro grupo nuevo de botones "Mask Buttons", con tres botones. Cada botón utiliza una imagen para representar la máscara que añade. Al OnClick de cada botón les asigné el filterController, pasándole el tag de la máscara que activa.
- En el propio filterController añadí los nuevos tags para que se pueda desactivar todos los gameobjects y solo mostrar el que haya sido seleccionado.
- Build realizado y probado en el dispositivo móvil con éxito.

[Ligazón](https://github.com/jnomada/ARInteractiveFaceFilter)