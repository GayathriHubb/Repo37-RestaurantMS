This is a C# Windows Forms Desktop Application for managing restaurant operations. Here's a comprehensive overview:

Project Purpose
A comprehensive Restaurant Management System designed to handle day-to-day restaurant operations including menu management, customer tracking, inventory control, order processing, and business analytics.

Key Features & Modules
1. Authentication System

Login Module (Login.cs) - Secure user login functionality
Register Module (Register.cs) - User registration for new staff members
FormLoad (FormLoad.cs) - Loading screen/splash screen displayed on startup
2. Main Dashboard (Dashboard.cs)

Central hub for restaurant management
Quick access to all system features
Business analytics and overview
3. Menu Management (Menu.cs)

Add, edit, and delete menu items
Organize food items with descriptions and pricing
Food card display component (UCFoodCard.cs) for visual menu presentation
4. Categories (Categories.cs)

Manage food categories (e.g., Appetizers, Main Course, Desserts, Beverages)
Organize menu items by category
Data handling via CategoriesData.cs
5. Inventory Management (Inventory.cs)

Track stock levels of ingredients and supplies
Monitor inventory usage
Manage product information via ProductsData.cs
6. Customer Management (Customers.cs)

Maintain customer records and profiles
Track customer information and preferences
Handle customer data via CustomersData.cs
7. Home Form (HomeForm.cs)

Main navigation interface after login
Buttons for accessing:
Dashboard
Food/Menu ordering
Categories
Inventory
Customers
Logout functionality with confirmation
Technical Architecture
Frontend:

Windows Forms UI (.Designer.cs files contain form controls)
.resx files contain form resources and styling
Backend:

Data layers (CategoriesData.cs, CustomersData.cs, ProductsData.cs, RestaurantData.cs)
Business logic in form classes
Database:

SQL Server Local Database (.mdf and .ldf files: Restaurant.mdf and Restaurant_log.ldf)
Configuration:

App.config - Application settings and connection strings
RestaurantMS.csproj - Project configuration file

Project Structure
Code
RestaurantMS/
├── Authentication (Login, Register, FormLoad)
├── UI Forms (HomeForm, Dashboard, Menu, Categories, Inventory, Customers)
├── Data Layers (CategoriesData, CustomersData, ProductsData)
├── Components (UCFoodCard - Reusable food display component)
├── Resources (Images folder, .resx files)
├── Database (Restaurant.mdf - SQL Server database)
└── Configuration (App.config, Project files)

How It Works
Startup → Program.cs launches FormLoad (splash screen)
Authentication → User logs in via Login.cs or registers with Register.cs
Main Navigation → HomeForm.cs provides access to all modules
Operations → Staff can:
Manage menu and categories
Track inventory
Handle customer information
View business analytics via Dashboard
Data Storage → All information persists in the SQL Server database
Technology Stack
Language: C# (.NET Framework)
UI Framework: Windows Forms
Database: SQL Server (Local Database)
Architecture: 3-tier (Presentation → Business Logic → Data Access)

This system provides a complete solution for small to medium-sized restaurant operations with essential features for daily management.
