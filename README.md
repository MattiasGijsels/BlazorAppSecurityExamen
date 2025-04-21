# BlazorAppSecurityExamen - Syntra

**Author:** Mattias Gijsels  
**Project Type:** Blazor WebAssembly Application  
**Purpose:** Syntra Security Assignment

---

## 🛡️ Overview

**BlazorAppSecurityExamen** is a Blazor application created to demonstrate secure web application practices as part of the Syntra security assignment. It includes examples of:

- User Authentication & Authorization
- Role-Based Access Control (RBAC)
- Symmetric & Asymmetric Encryption
- Secure Profile Editing

This project highlights how to protect sensitive features and data within a Blazor environment using layered security techniques.

---

## ✨ Features

- ✅ User Authentication & Authorization
- 🔐 Role-Based Access Control (RBAC)
- 🔁 Symmetric Encryption Demo
- 🔑 Asymmetric Encryption Demo
- 👤 Secure Profile Editing

---

## 🔑 Role System

The application implements a tiered role system to manage access control:

| Role       | Description                                                                                                                                     |
|------------|-------------------------------------------------------------------------------------------------------------------------------------------------|
| **Admin**      | Full access: profile editing, both encryption demos, and the admin-only page.                                                                 |
| **SuperUser**  | Can access the symmetric encryption demo and edit profile. No access to admin-only pages.                                                     |
| **User**       | Limited to managing their own profile (e.g., add birthdate, phone number). No access to encryption or authentication-related pages.           |

---

## 🧪 Test Accounts

> ⚠️ **Note:** These credentials are for demonstration purposes only. Real-world applications should never hardcode or share credentials publicly.

| Role       | Email                  | Password       |
|------------|------------------------|----------------|
| Admin      | tony@stark.com         | Password001-   |
| SuperUser  | peter@parker.com       | Password002-   |
| User       | captain@america.com    | Password003-   |

---

## 📦 Used NuGet Packages

The following NuGet packages are used to support security, identity, and data management:

- `Microsoft.AspNetCore.Components.WebAssembly.Server`
- `Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore`
- `Microsoft.AspNetCore.Identity.EntityFrameworkCore (8.0.14)`
- `Microsoft.EntityFrameworkCore.SqlServer (8.0.14)`
- `Microsoft.EntityFrameworkCore.Tools (8.0.14)`

### These packages provide:

- ASP.NET Core Identity integration
- Entity Framework Core support for SQL Server
- Developer tools and runtime diagnostics
- Hosting Blazor WebAssembly apps on the server

---

## 📌 Notes

- Newly registered users are assigned the **User** role by default.
- Page access is strictly role-based and demonstrates good separation of concerns.
- Encryption demos are available only to users with appropriate privileges.

---

## 📚 Summary

This project showcases a secure, structured approach to managing user access and protecting sensitive components using **Blazor WebAssembly** and **ASP.NET Core Identity**. It is built for **educational purposes** and demonstrates best practices in modern web security.

---

## 🚀 Future Improvements

- Add an **Admin Control Panel** that allows administrators to delegate roles to newly registered users.
  - This will make role management more dynamic and user-friendly.
  - Reduces the need for manual database changes.
