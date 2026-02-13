# 📋 ToDo con Access (C# | Windows Forms)

Aplicación de escritorio para gestionar tareas (ToDo) usando **C#** y una base de datos **Microsoft Access (.accdb)**.

Este proyecto es una pequeña app CRUD donde podés **agregar, editar, eliminar y listar recordatorios** con campos como nombre, importancia, fecha y hora. Está hecha con **Windows Forms** y **OLE DB** para conectarse a la base de datos de Access.

---

## 🛠️ Tecnologías utilizadas

- **C#**
- **.NET Framework**
- **Windows Forms**
- **Microsoft Access + OLE DB**
- Visual Studio (IDE)

---

## 📌 ¿Qué hace esta aplicación?

Esta app permite:

✔️ Crear nuevos recordatorios  
✔️ Listar todos los recordatorios  
✔️ Editar uno existente  
✔️ Eliminar recordatorios  
✔️ Ver los datos en una grilla (DataGridView)

La base de datos utilizada es **Recordatorios.accdb**, y la conexión se realiza a través de **OLE DB** con el proveedor `Microsoft.ACE.OLEDB.12.0`.

---

## 💻 Cómo usar

1️⃣ Abri el proyecto en **Visual Studio**  
2️⃣ Asegurate de tener instalado el proveedor de Access (`Microsoft Access Database Engine`)  
3️⃣ Ejecuta la app (`F5` o desde **Debug > Start Debugging**)  
4️⃣ Usá el formulario para agregar o modificar recordatorios

---

## 📂 Estructura del proyecto

-todo-conacces/
│
├── Prueba1.sln
├── Prueba1.csproj
├── App.config
├── Program.cs
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
└── Recordatorios.accdb ← Base de datos Access

## 📌 Detalles técnicos

La conexión y operaciones se hacen con **OleDbConnection**, **OleDbCommand** y **OleDbDataAdapter**.  
El string de conexión está en `Form1.cs`:

Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Recordatorios.accdb

---

## 👨‍💻 Autor

**Dante Nicolás Rodríguez**  
GitHub: https://github.com/TecnicoD  
