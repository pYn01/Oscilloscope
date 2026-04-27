<img width="1918" height="1113" alt="Screenshot 2026-04-27 121327" src="https://github.com/user-attachments/assets/c7fbf795-9e66-49e8-bed3-290e3c4717ae" />
# ⚡ Oscilloscope

A simple, hybrid **C++** and **C#** project that simulates how an industrial ATE (Automatic Test Equipment) machine reads hardware data. 

This project was built to practice cross-language integration, asynchronous programming, and modern UI patterns.

## 🏗️ Architecture

* **Backend (C++):** A dynamic library (`.dll`) that acts as a fake hardware sensor. It generates a noisy voltage signal.
* **Frontend (C# WPF):** The user interface. It strictly follows the **MVVM** (Model-View-ViewModel) pattern to keep the graphics and logic cleanly separated.
* **The Bridge:** C# communicates with the unmanaged C++ DLL using **P/Invoke**.

## 🚀 Key Features

* **Real-time Simulation:** C++ generates data on the fly.
* **Non-Blocking UI:** C# reads the hardware data asynchronously (`async/await`) every 100ms, ensuring the graphical interface never freezes.
* **Data Binding:** The WPF interface updates automatically when the ViewModel detects a new voltage reading.

## 🛠️ Tech Stack

* **Language:** C++14/17, C# (.NET)
* **Framework:** WPF (Windows Presentation Foundation)
* **Tools:** Visual Studio, Git

## ⚙️ How to Run

1. Clone this repository.
2. Open the solution file in **Visual Studio**.
3. Build the solution (ensure the C++ DLL is configured to copy into the C# output folder).
4. Run the C# WPF project and click "Start Reading".
