# TaskApp (WinForms .NET 8) – Prueba Técnica

## Descripción general
TaskApp es un administrador de tareas de escritorio desarrollado en **.NET 8 WinForms**, con una arquitectura por capas y un enfoque **MVVM-lite** (adaptado a WinForms).  
La capa de datos actualmente usa **SQLite + Dapper**, pero la solución está preparada para migrar a **Entity Framework** cambiando únicamente la implementación de infraestructura.

---

## Requerimientos cubiertos
- Listado de tareas ordenado por **fecha de vencimiento** (ascendente).
- Filtros por:
  - Texto en descripción
  - Estado
  - Prioridad
  - Usuario asignado
- Crear nuevas tareas.
- Editar tareas **solo si** están en estado **Pendiente**.
- Eliminar tareas **solo si** el estado **no** es **En proceso**.
- Transiciones de estado permitidas:
  - Pendiente → En proceso → Finalizada  
  - No se permite saltar estados ni revertir.

---

## Módulo adicional (Entidad User)
- Listado de usuarios ordenado por **nombre del usuario** (ascendente).
- Filtros por:
  - Texto en nombre
- Crear nuevos usuarios **solo si** se ha completado el campo **nombre**.
- Editar usuarios **solo si** se ha completado el campo **nombre**.
- Eliminar usuarios.

## Tecnologías
- **.NET 8**
- **WinForms** (MVVM-lite con `BindingList` + `BindingSource`)
- **SQLite** (base local en archivo)
- **Dapper** para acceso a datos

> Nota: Se consideró DevExpress, pero no se incluyó por problemas de compatibilidad/configuración en el ambiente local. La UI se implementó con controles estándar de WinForms, con un layout limpio y consistente.

---

## Arquitectura
La solución está dividida en 4 proyectos:

- **TaskApp.Domain**
  - Modelos base (`TaskItem`,`UserItem`) y enums (`TaskStatus`, `TaskPriority`)
  - Sin dependencia de UI ni de frameworks de BD.

- **TaskApp.Application**
  - Casos de uso / reglas de negocio (`TaskService`,`UserService`)
  - Contrato del repositorio (`ITaskRepository`,`IUserRepository`) para desacoplar la app de la tecnología de datos.

- **TaskApp.Infrastructure**
  - Inicialización de SQLite (`DbInitializer`)
  - Implementación del repositorio con Dapper (`DapperTaskRepository`,`DapperUserRepository`)
  - Connection factory (`SqliteConnectionFactory`)

- **TaskApp.WinForms**
  - Formularios (`TaskAppForm`, `TaskEditForm`,`UserEditForm`)
  - ViewModel (`MainViewModel`) que conecta UI con `TaskService`
  - ViewModel (`UserViewModel`) que conecta UI con `UserService`

---

## MVVM-lite en WinForms
WinForms no trae MVVM como WPF, así que se usó un enfoque práctico:

- `MainViewModel` expone una `BindingList<TaskItem>` para enlazar la grilla de tareas.
- `UserViewModel` expone una `BindingList<UserItem>` para enlazar la grilla de usuarios.
- El formulario principal enlaza el `DataGridView` con el ViewModel mediante `BindingSource`.
- Las reglas de negocio se mantienen en `TaskService` y `UserService` (capa Application), evitando lógica “pesada” en la UI.

---

## Capa de datos y futura migración a Entity Framework
La aplicación depende únicamente de (`ITaskRepository`,`IUserRepository`) en la capa **Application**.  
Actualmente se usa (`DapperTaskRepository`,`DapperUserRepository`) con **SQLite**.  
Para migrar a EF, basta con crear una implementación alternativa (por ejemplo `EfTaskRepository`) y reemplazar el wiring en `Program.cs`, sin cambios en UI ni reglas de negocio.

---

## Cómo ejecutar
1. Abrir la solución en Visual Studio 2022+
2. Establecer `TaskApp.WinForms` como proyecto de inicio
3. Ejecutar (F5)

En el primer arranque se crea el archivo SQLite local:
- `taskapp.db` dentro del output (`bin/Debug/net8.0-windows/`)

---

## Notas de UX
- Los filtros usan un **debounce con Timer** para evitar recargar en cada tecla.
- Los botones de acciones se habilitan/deshabilitan según la fila seleccionada y su estado, evitando operaciones inválidas.
- Estado y Prioridad se muestran en texto amigable (Pendiente / En proceso / Finalizada) y con “chips” de color (pintado en grilla).
- La grilla de tareas y usuarios están en un content espécifico para cada modelo, al presionar los botones del sidebar (Tareas, Usuarios) el content cambia al que debe, y se oculta el que no està ligado a ese botón.
- Los botones del navbar también cambian su visibilidad según el content que está habilitado.
