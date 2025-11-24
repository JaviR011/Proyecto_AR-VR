
# Proyecto AR – Javier Rodríguez

Proyecto de realidad aumentada basado en **Unity + Vuforia Engine**.

---

## 🚀 Requisitos

Antes de abrir el proyecto, es necesario instalar el paquete de **Vuforia Engine**, ya que GitHub **no permite subir archivos mayores a 100 MB** (como el archivo `com.ptc.vuforia.engine-XX.X.X.tgz` que requiere Vuforia).

Unity **NO puede reconstruir Vuforia automáticamente**, por lo que su instalación manual es indispensable.

---

## 📌 Instalación de Vuforia (OBLIGATORIO)

Sigue estos pasos antes de abrir la escena principal del proyecto:

1. Descarga el paquete oficial de Vuforia desde:
   👉 [https://developer.vuforia.com/downloads/sdk](https://developer.vuforia.com/downloads/sdk)

2. En Unity, abre el **Package Manager**:
   `Window → Package Manager`

3. Clic en:
   `+ → Add package from disk`

4. Selecciona el archivo descargado:

   ```
   com.ptc.vuforia.engine-XX.X.X.tgz
   ```

5. Unity instalará automáticamente:

   * `ImageTargetBehaviour`
   * `DefaultObserverEventHandler`
   * `Vuforia.ImageTargetPreview`
   * Todos los componentes necesarios para que los Image Targets funcionen correctamente.

---

## 📦 Estructura del proyecto

El repositorio incluye los archivos necesarios para abrir el proyecto sin errores (excepto Vuforia):

* `Assets/` → Scripts, modelos 3D, animaciones, texturas, prefabs, escenas.
* `Packages/manifest.json` → Lista de dependencias del proyecto.
* `Packages/packages-lock.json` → Versiones exactas de los paquetes usados.
* `ProjectSettings/` → Configuraciones del proyecto Unity.

Las siguientes carpetas **NO se incluyen** porque Unity las reconstruye automáticamente:

* `Library/`
* `Temp/`
* `Obj/`
* `Logs/`
* `Build/`

---

## 🔧 Nota importante sobre Vuforia

El archivo `.tgz` de Vuforia supera el límite de 100 MB de GitHub, por ello **no está incluido en el repositorio**.

Para que los Image Targets y componentes AR funcionen, es indispensable instalar Vuforia mediante el archivo `.tgz` siguiendo los pasos anteriores.

Después de la instalación, Unity cargará correctamente:

* Los Image Targets
* Las detecciones
* Los scripts de seguimiento
* Los eventos de “Target Found” y “Target Lost”

---

## ▶️ Cómo ejecutar el proyecto

1. Instala Vuforia (sección anterior).
2. Abre Unity Hub.
3. Selecciona la carpeta del proyecto.
4. Deja que Unity importe los assets y reconstruya el proyecto.
5. Abre la escena principal (como `fire` o la escena indicada para pruebas).
6. Presiona **Play**.

---

## 👨‍💻 Autor

**Javier Rodríguez**
Proyecto académico AR.

---

Si quieres, puedo agregarte:

✔ Capturas de pantalla
✔ GIFs de la app en funcionamiento
✔ Instrucciones de compilación para Android o iOS
✔ Créditos o dependencias adicionales

Solo dime y lo adapto.
