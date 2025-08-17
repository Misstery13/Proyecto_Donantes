# 🩸 Proyecto Donantes (VB.NET WinForms, .NET 6) + MySQL 🐬

Aplicación de Windows Forms en VB.NET (.NET 6, solo Windows) para gestionar campañas de donación, donantes y personal. Usa MySQL/MariaDB y el proveedor MySql.Data.

Este repositorio contiene dos soluciones de Visual Studio:

- Proyecto Donantes: aplicación principal conectada a MySQL
- recu: proyecto WinForms mínimo (estudio/pruebas)

---

## ✨ Funcionalidades (Proyecto Donantes)

- 🔐 Inicio de sesión (`ACCESO/frm_acceso`)
- 📅 Gestión de campañas: crear/editar (`CAMPAÑA/frm_campaña`)
- 🩸 Donantes por campaña: listar/buscar (`DONANTES_CAMPAÑA/donantes_camp`)
- 🧑‍🤝‍🧑 Gestión de personal: listar/crear/editar (`PERSONAL_CAMPAÑA/personal`, `PERSONAL_CAMPAÑA/frm_personal`)
- 🧭 Menú principal (`FORM_PRINCIPAL/Form1`)

## 🧰 Requisitos

- Windows 10/11
- Visual Studio 2022 (v17+) con "+.NET Desktop Development"
- .NET 6 SDK (Windows desktop)
- MySQL 8.x o MariaDB 10.x (probado con 10.4.28)
- MySQL Connector/NET 8.0.x (MySql.Data)

## 🗄️ Base de datos

Importa el archivo `distrito_24d02.sql` (esquema y datos de ejemplo).

- 🐬 CLI MySQL (ejemplo):

```bash
mysql -u root -p -h 127.0.0.1 -P 3306 < distrito_24d02.sql
```

- O usa MySQL Workbench / phpMyAdmin

Tablas creadas: `campaña`, `donante`, `personal` con claves foráneas.

🔑 Credenciales de prueba (tabla `personal`): `user` / `1234`

⚠️ Codificación: nombres con `ñ` (ej. `campaña`). Usa `utf8mb4`.

## ⚙️ Configuración de conexión

Editar `Proyecto Donantes/Proyecto Donantes/MOD/MODconexion.vb` con tus parámetros de MySQL.

```vb
Dim servidor As String = "localhost"
Dim basededatos As String = "distrito_24d02"
Dim usuario As String = "root"
Dim clave As String = ""
Dim puerto As String = "3306"
Public cadenaConexion As String = "server=" & servidor & ";database=" & basededatos & ";user id=" & usuario & ";password=" & clave & ";port=" & puerto & ";"
```

## 📦 Proveedor MySQL (MySql.Data)

- ✅ Recomendado: instalar paquete NuGet `MySql.Data`
- 🔧 Alternativa: actualizar la referencia a `MySql.Data.dll` según tu instalación

## ▶️ Compilar y ejecutar (Visual Studio)

1. Abrir `Proyecto Donantes/Proyecto Donantes.sln`
2. Establecer `Proyecto Donantes` como proyecto de inicio
3. Verificar conexión en `MODconexion.vb`
4. Compilar (Ctrl+Shift+B)
5. Ejecutar (F5)
6. Iniciar sesión con `user` / `1234`

## 🛠️ Problemas comunes

- `MySql.Data` no se encuentra: instala el paquete NuGet o corrige la referencia
- No conecta a MySQL: revisa `MODconexion.vb` y que la BD esté importada
- Problemas de caracteres: usa UTF-8/utf8mb4

## 🔒 Notas de seguridad (mejoras futuras)

- Usar consultas parametrizadas
- Hashear y saltear contraseñas
- Mover secretos fuera del código fuente

## 🧩 Solución secundaria: `recu`

Proyecto WinForms independiente (`recu.sln`), también `net6.0-windows`.

## 📄 Licencia

MIT. Ver `LICENSE`.