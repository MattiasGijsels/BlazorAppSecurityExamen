# BlazorAppSecurityExamen - Syntra
**Author:** Mattias Gijsels

Welcome to **BlazorAppSecurityExamen**, a Blazor application built for the Syntra Security assignment. This project demonstrates the implementation of **authentication**, **authorization**, **user role delegation**, and both **symmetric** and **asymmetric encryption**.

---

## 🔐 Features

- **User Authentication & Authorization**
- **Role-Based Access Control (RBAC)**
- **Symmetric Encryption Demo**
- **Asymmetric Encryption Demo**
- **Secure Profile Editing**

---

## 👥 Role System

The app implements a **tiered role system** for access control:

| Role        | Description                                                                                          |
|-------------|------------------------------------------------------------------------------------------------------|
| **Admin**   | Full access to all features: view/edit profile, symmetric & asymmetric encryption, and Auth page.   |
| **SuperUser** | Access to symmetric encryption and profile editing. Cannot access the "Auth Required" page.         |
| **User**    | Can only manage their own profile (e.g., add date of birth, phone number). No access to encryption or Auth page. |

---

## 🧪 Test Accounts  
> ⚠️ **Note:** These credentials are for demo/testing only — never hardcode or publish real credentials in production.

| Role        | Email                   | Password       |
|-------------|-------------------------|----------------|
| Admin       | tony@stark.com          | Password001-   |
| SuperUser   | peter@parker.com        | Password002-   |
| User        | captain@america.com     | Password003-   |

---

## 📦 Used NuGet Packages

The project uses the following NuGet packages:

- `Microsoft.AspNetCore.Components.WebAssembly.Server`
- `Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore`
- `Microsoft.AspNetCore.Identity.EntityFrameworkCore (8.0.14)`
- `Microsoft.EntityFrameworkCore.SqlServer (8.0.14)`
- `Microsoft.EntityFrameworkCore.Tools (8.0.14)`

These packages enable:
- ASP.NET Core Identity and Entity Framework integration
- SQL Server support for EF Core
- Developer tools and diagnostics for EF
- Hosting Blazor WebAssembly on the server

---

## 📝 Notes

- New users can register accounts but will have limited access (**User** role by default).
- The app demonstrates good separation of concerns and role-based access to specific pages.
- Encryption demos are available based on user privileges.

---

## ✅ Summary

This project showcases a secure and structured approach to managing user roles and protecting sensitive features using Blazor. It is designed for educational purposes and highlights best practices in web security within a Blazor environment.

---

## 🚀 Future Improvements

- Add an **Admin Control Panel** that allows administrators to **delegate roles to newly registered users**. This would provide a user-friendly interface for managing user access and permissions dynamically, without modifying the database manually.
