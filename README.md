# Stardew Valley Save File Uploader

This application runs in the background and monitors for the Stardew Valley game. If the game is running, it automatically uploads the save files to a specified API every 5 seconds(in prod it has to be longer, like 15 minutes). It scans for the save files and writes them to the console. In production, the console is hidden, and the application is configured to run every time the OS starts.

## Features

- Monitors for the Stardew Valley game.
- Automatically uploads save files to a specified API when the game is running.
- Scans for save files and prints them to the console.
- Configures itself to run on OS startup.
- In production, the console window is hidden.

## Requirements

- .NET Core SDK
- Stardew Valley installed on your system.

## Setup

1. **Clone the repository:**
   ```bash
   git clone <repository_url>
   cd <repository_directory>
