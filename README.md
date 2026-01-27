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
  - Modelos base (`TaskItem`) y enums (`TaskStatus`, `TaskPriority`)
  - Sin dependencia de UI ni de frameworks de BD.

- **TaskApp.Application**
  - Casos de uso / reglas de negocio (`TaskService`)
  - Contrato del repositorio (`ITaskRepository`) para desacoplar la app de la tecnología de datos.

- **TaskApp.Infrastructure**
  - Inicialización de SQLite (`DbInitializer`)
  - Implementación del repositorio con Dapper (`DapperTaskRepository`)
  - Connection factory (`SqliteConnectionFactory`)

- **TaskApp.WinForms**
  - Formularios (`TaskAppForm`, `TaskEditForm`)
  - ViewModel (`MainViewModel`) que conecta UI con `TaskService`

---

## MVVM-lite en WinForms
WinForms no trae MVVM como WPF, así que se usó un enfoque práctico:

- `MainViewModel` expone una `BindingList<TaskItem>` para enlazar la grilla.
- El formulario principal enlaza el `DataGridView` con el ViewModel mediante `BindingSource`.
- Las reglas de negocio se mantienen en `TaskService` (capa Application), evitando lógica “pesada” en la UI.

---

## Capa de datos y futura migración a Entity Framework
La aplicación depende únicamente de `ITaskRepository` en la capa **Application**.  
Actualmente se usa `DapperTaskRepository` con **SQLite**.  
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
