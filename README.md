📚 School Transportation System (STS)

A Windows Forms application for managing:

Students

Drivers

Buses

Supervisors

Alerts

Attendance

Daily Trips

School Route Schedules

This system is designed for school transportation operations that require real-time updates, reporting, and bus tracking.

🚀 Features
✔ Student Management

Add, edit, delete, search, and assign students to buses.

✔ Driver Management

Assign drivers to buses, manage licenses and contact details.

✔ Bus Management

Route management, capacity control, trip scheduling.

✔ Alert System

Generate alerts for student absences, bus lateness, and manual notifications.

✔ Dataset Integration (XSD)

The system uses a strongly typed DataSet (XSD) for local operations.

✔ SQL Server Database Support

All operations connect to SQL Server using App.config.

🏗 Project Structure
STS/
│
├── STS.sln
├── README.md
├── .gitignore
│
├── /STS_App/
│   ├── STS_App.csproj
│   ├── /Forms/
│   ├── /Database/
│   ├── /Assets/
│   ├── App.config
│
└── /Documentation/
    ├── Wireframes.pdf
    ├── ERD.png
    └── Jira_Backlog.csv

🔧 Technologies Used

C# (.NET Framework — WinForms)

SQL Server

ADO.NET

Typed DataSet (XSD)

Git / GitHub

Jira (Agile Scrum)  https://farida-hassan.atlassian.net/jira/software/projects/SMS/boards/34/backlog

🚦 How to Build

Clone the repository

Open STS.sln in Visual Studio

Configure the SQL connection string in App.config

Rebuild the solution

Run the application

🧪 Testing

Testing is done using:

Manual UI tests

Unit tests (if added later)

Dataset validation

SQL constraint validation

👥 Contributors

Developer Farida Hassan

Developer Menna Khaled

📌 License


Free to use for academic purposes.
