# 🚜 Agricultural Simulation Game with FPGA & Unity 

This repository contains the complete implementation of an educational tractor simulation game that integrates an FPGA DE10-Lite board with Unity 3D to deliver a real-time, interactive agricultural environment. Developed as part of a 4th-semester engineering project, it aims to bridge embedded systems with virtual simulation.

## 🎯 Project Overview

As part of a precision agriculture initiative, this simulation enables users to control a virtual tractor using physical switches and buttons connected to an FPGA. The FPGA processes user inputs and communicates with the Unity game via serial communication, creating an immersive and realistic gameplay experience.


## 🔧 Technologies Used
- FPGA (DE10-Lite) with VHDL for logic implementation
- Gumnut Processor for interfacing
- 7-segment display for feedback
- Unity 3D for simulation environment
- FTDI Serial Communication between FPGA and Unity

## 📁 Repository Contents

- `Unity/` – Unity 3D project files (tractor model, environment, game logic)
- `VHDL/` – VHDL code for FPGA logic, including movement and accelerometer
- `Gumnut/` – Source code for Gumnut processor implementation and interfacing
- `SerialCommunication/` – Scripts and protocol used to sync FPGA with Unity

## 📷 Preview

![image](https://github.com/user-attachments/assets/4b96a5b5-5bb2-43d3-9ac1-91ac740969af)


---

Feel free to explore each folder for detailed implementation and contributions from both hardware and software perspectives.
