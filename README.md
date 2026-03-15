# ACA-Programacion-2

Proyecto final de la asignatura **Programación Avanzada**.

Este repositorio contiene el desarrollo del sistema **OmniStock**, un sistema
de gestión de inventario y ventas diseñado para pequeñas y medianas empresas.

El proyecto consiste en el desarrollo de una **aplicación de escritorio**
conectada a una **base de datos MySQL**, permitiendo administrar productos,
clientes y ventas mediante una interfaz gráfica.

---

# Descripción del proyecto

OmniStock es un sistema diseñado para facilitar la administración de inventarios
dentro de un negocio.

El sistema permite registrar productos, clientes y ventas, manteniendo el
inventario actualizado automáticamente.

El proyecto está compuesto por dos componentes principales:

Aplicación de escritorio  
Interfaz gráfica desarrollada en Visual Studio para la gestión del sistema.

Base de datos MySQL  
Encargada de almacenar y organizar toda la información del sistema.

---

# Objetivos del proyecto

El desarrollo del sistema busca aplicar los siguientes conocimientos:

- Programación avanzada y desarrollo de software
- Diseño de bases de datos relacionales
- Conexión entre aplicaciones y bases de datos
- Desarrollo de interfaces de usuario
- Implementación de operaciones CRUD

---

# Tecnologías utilizadas

Aplicación

- Visual Studio
- Aplicación de escritorio

Base de datos

- MySQL

Herramientas de apoyo

- MySQL Workbench
- XAMPP / WAMP / Laragon

---

# Funcionalidades del sistema

## Gestión de productos

Permite registrar y administrar los productos del sistema.

Operaciones disponibles:

- Crear producto
- Consultar producto
- Actualizar producto
- Eliminar producto

---

## Gestión de clientes

Permite administrar la información de los clientes.

Operaciones disponibles:

- Crear cliente
- Consultar cliente
- Actualizar cliente
- Eliminar cliente

---

## Gestión de ventas

Permite registrar las ventas realizadas en el sistema.

Incluye:

- Registro de ventas
- Asociación con cliente
- Asociación con productos
- Registro del detalle de la venta

---

## Control de inventario

El sistema actualiza automáticamente el stock de productos cuando se realiza
una venta.

Esto permite mantener un control actualizado del inventario.

---

## Gestión de usuarios

El sistema incluye autenticación básica de usuarios para controlar el acceso
al sistema.

---

# Base de datos

La base de datos del sistema se encuentra implementada en **MySQL**.

Su función es almacenar toda la información del sistema de forma estructurada.

Las principales entidades incluyen:

- Productos
- Clientes
- Ventas
- Detalle de ventas
- Usuarios

El diseño de la base de datos busca garantizar:

- Integridad de los datos
- Consistencia
- Eficiencia en consultas

---

# Arquitectura del sistema

El sistema sigue una arquitectura **cliente – base de datos**.

La aplicación de escritorio funciona como cliente y se comunica con MySQL
para consultar y modificar información.

```
Aplicación de escritorio
        │
        │ conexión a base de datos
        ▼
      MySQL
        │
        ▼
    Base de datos
```
---

# Estructura del proyecto

```
ACA-Programacion-2
│
├── database
│   └── omnistock.sql
│
├── src
│   ├── models
│   ├── controllers
│   ├── views
│   └── database
│
├── docs
│   └── documentacion.md
│
└── README.md
```
---

# Operaciones CRUD

El sistema implementa operaciones CRUD sobre las principales entidades.

Create  – Crear nuevos registros  
Read    – Consultar información  
Update  – Actualizar registros  
Delete  – Eliminar registros  

Estas operaciones se aplican a:

- Productos
- Clientes
- Ventas

---

# Presentación del proyecto

Como parte del trabajo final se debe presentar un **video explicativo** del
funcionamiento del sistema.

El video debe incluir:

- Presentación del estudiante
- Explicación del sistema
- Demostración de las operaciones CRUD
- Interacción con la base de datos

Duración recomendada: **5 a 10 minutos**.

---

# Entrega

La entrega del proyecto se realiza a través de la plataforma **CDigital**.

Cada integrante del grupo debe subir el proyecto individualmente en la
plataforma.

---

# Autor

Proyecto desarrollado para la asignatura **Programación Avanzada**.

**Estudiantes** 
- Gustavo Mejia
- Ian

Carrera  
Ingeniería de Sistemas


Hola-...