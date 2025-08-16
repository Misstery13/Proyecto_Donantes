# Contributing

Thanks for your interest in contributing!

## Environment setup

- Windows 10/11
- Visual Studio 2022 with .NET Desktop Development workload
- .NET 6 SDK (Windows desktop)
- MySQL Server (or MariaDB) and MySQL Connector/NET
- Import `distrito_24d02.sql` before running the app

## Project overview

- Main app: `Proyecto Donantes/Proyecto Donantes.sln`
- Secondary app: `recu/recu.sln`
- Target framework: `net6.0-windows`
- Data access: `MySql.Data`
- Database connection: `Proyecto Donantes/Proyecto Donantes/MOD/MODconexion.vb`

## Workflow

1. Fork and create a feature branch
2. Keep edits focused and atomic
3. Build and run locally; verify login and key screens
4. Run through basic flows:
   - Login with `user` / `1234`
   - Create/Edit a campaña
   - Search donors by campaña
   - List/Create/Edit personal
5. Commit with descriptive messages
6. Open a Pull Request and describe changes and test steps

## Coding guidelines

- VB.NET WinForms
- Prefer parameterized queries; avoid inline string concatenation for SQL
- Do not commit secrets; if needed, use configuration files not tracked by git
- Use clear, descriptive names for forms, controls, and methods

## Issues

- Use the issue tracker for bugs and feature requests
- Include reproduction steps, expected vs actual behavior, and screenshots if UI-related

## Pull Requests

- Link related issues
- Include before/after screenshots for UI changes
- Describe testing performed
- Keep PRs small and focused for easier review