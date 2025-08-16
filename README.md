# Proyecto Donantes (VB.NET WinForms, .NET 6) + MySQL

A Windows Forms application written in VB.NET (.NET 6, Windows-only) to manage blood donation campaigns, donors, and personnel. It uses MySQL/MariaDB for persistence and the MySql.Data provider.

This repository contains two Visual Studio solutions:

- Proyecto Donantes: the main app connected to MySQL
- recu: a minimal WinForms template (for study/testing)

---

## Features (Proyecto Donantes)

- User login (`ACCESO/frm_acceso`)
- Campaign management: create/update campaigns (`CAMPAÑA/frm_campaña`)
- Donors by campaign: list/search donors per campaign (`DONANTES_CAMPAÑA/donantes_camp`)
- Personnel management: list/create/update personnel (`PERSONAL_CAMPAÑA/personal`, `PERSONAL_CAMPAÑA/frm_personal`)
- Main menu (`FORM_PRINCIPAL/Form1`)

## Repository layout

```
/Proyecto Donantes/
  Proyecto Donantes.sln
  Proyecto Donantes/
    ACCESO/
    CAMPAÑA/
    DONANTES_CAMPAÑA/
    PERSONAL_CAMPAÑA/
    FORM_PRINCIPAL/
    MOD/
    My Project/
/recu/
  recu.sln
  recu/

distrito_24d02.sql   # Database schema & sample data
```

## Requirements

- Windows 10/11
- Visual Studio 2022 (v17+) with "+.NET Desktop Development" workload
- .NET 6 SDK (Windows desktop); target framework is `net6.0-windows`
- MySQL Server 8.x (or MariaDB 10.x; tested with 10.4.28)
- MySQL Connector/NET 8.0.x (provider `MySql.Data`)

## Database setup

Import the provided schema and seed data contained in `distrito_24d02.sql`.

- With MySQL CLI (example):

```bash
mysql -u root -p -h 127.0.0.1 -P 3306 < distrito_24d02.sql
```

- Or use MySQL Workbench / phpMyAdmin to import the SQL dump

Tables created:

- `campaña` (`ID_Campaña` PK, `Nombre`, `Lugar`, `Fecha`, `Estado`)
- `donante` (`ID_Donante` PK, `ID_Campaña` FK -> `campaña`)
- `personal` (`ID_Personal` PK, `ID_Campaña` FK -> `campaña`)

Seeded login (from `personal` table):

- Username: `user`
- Password: `1234`

Note on encoding: table names include `ñ` (e.g., `campaña`). The dump uses `utf8mb4`. Ensure your server uses a compatible charset/collation.

## Application configuration (DB connection)

The connection parameters are defined in `Proyecto Donantes/Proyecto Donantes/MOD/MODconexion.vb`. Adjust them to match your local database.

```vb
' Proyecto Donantes/Proyecto Donantes/MOD/MODconexion.vb
Dim servidor As String = "localhost"
Dim basededatos As String = "distrito_24d02"
Dim usuario As String = "root"
Dim clave As String = ""
Dim puerto As String = "3306"
Public cadenaConexion As String = "server=" & servidor & ";database=" & basededatos & ";user id=" & usuario & ";password=" & clave & ";port=" & puerto & ";"
```

- Keep `basededatos` consistent with the database you imported
- If your MySQL root user has a password, set `clave` accordingly

## MySQL provider (MySql.Data)

The project currently references `MySql.Data.dll` via a Windows HintPath. On your machine you have two options:

1) Recommended: install the NuGet package
- Right-click project `Proyecto Donantes` → Manage NuGet Packages…
- Install `MySql.Data` (8.0.x)
- Remove the old manual assembly reference if present

2) Or update the assembly reference path to the connector installed on your machine

## Build & run (Visual Studio)

1. Open `Proyecto Donantes/Proyecto Donantes.sln` in Visual Studio 2022
2. Ensure the `Proyecto Donantes` project is set as the Startup Project
3. Verify/adjust DB connection in `MODconexion.vb`
4. Build Solution (Ctrl+Shift+B)
5. Run (F5)
6. Log in using the seeded credentials (`user` / `1234`)

## Using the app

- Login (`frm_acceso`)
- Main menu (`Form1`):
  - "Registrar campañas": opens `frm_campaña` to create or edit campaigns
  - "Lista de donantes": opens `donantes_camp` to search/list donors by campaign
  - "Registrar personal": opens `personal` list; double-click rows or use "Nuevo" to manage personnel

## Troubleshooting

- Could not load file or assembly `MySql.Data`:
  - Install `MySql.Data` via NuGet (recommended) or correct the assembly reference
- Cannot connect to MySQL:
  - Check `MODconexion.vb` values (`servidor`, `puerto`, `usuario`, `clave`, `basededatos`)
  - Ensure the database was imported and the server is reachable
- Characters/encoding issues:
  - Use UTF-8/utf8mb4 in your server and client tools

## Security notes (for improvement)

- Current code uses inline SQL and stores passwords in plain text (for learning/demo). For production:
  - Use parameterized queries to avoid SQL injection
  - Hash and salt passwords
  - Store secrets outside source code (e.g., user secrets, environment variables, config files)

## Secondary solution: `recu`

`/recu` contains a small WinForms project (`recu.sln`, `recu/`) targeting `net6.0-windows`. It is independent of the main app and can be built/run similarly in Visual Studio.

## License

No license specified. Add a `LICENSE` file if you intend to publish or share this code.