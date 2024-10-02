# Script Creator By Templates

## Project Description
This tool allows you to create scripts based on 16 predefined templates directly in Unity. The tool integrates into the Assets menu, enabling users to generate new scripts easily via the right-click context menu.

## Features
- **16 script templates:** Quickly generate scripts using predefined templates tailored for common development scenarios.
- **User-friendly menu integration:** Scripts can be created directly under the Assets menu via a Create Script option.
- **Time-saving:** Common code structures are provided in a ready-to-use format, making script creation faster.

## Usage
1. Right-click in the Assets window in Unity.
2. Select **Create Script** from the context menu.
3. Choose a template to generate the script, which will be automatically created in the project directory.

## Important Notes
Some templates may produce errors upon script creation in this project. Below are examples of common issues specific to this tool:

- **ScriptableObject:** The `fileName` and `menuName` parameters of the `CreateAssetMenu` attribute should not be left empty. If these fields are left blank, it may result in errors when attempting to create the script.
  
- **Custom Editor:** When generating a custom editor script, the `typeof()` parameter in the `CustomEditor` attribute should not be left empty. It is important to specify the type of the target class for the custom editor, as leaving it blank may cause errors during script creation. This allows users to define the target editor class based on their workflow.

- **Custom Editor Window:** When creating a custom editor window, the `MenuItem` attribute parameter in the `ShowWindow` method should not be left empty. If this parameter is left blank, it may prevent the window from opening correctly, resulting in an error when the user tries to access the custom editor window.

## Templates
The project includes the following script templates:
- **MonoBehaviour Script:** A standard script based on Unity's MonoBehaviour class.
- **Interface:** A template for defining a new interface.
- **ScriptableObject:** A template for creating a class that inherits from ScriptableObject.
- **Singleton ScriptableObject:** A singleton pattern implementation for ScriptableObject.
- **Serializable Class:** A class marked as serializable for Unity's serialization system.
- **Basic Class:** A basic class definition without additional functionality.
- **Class with Constructor:** A class that includes a constructor method.
- **Static Class:** A class with static members, allowing static functionality.
- **Static Class with Constructor:** A static class that includes a constructor.
- **Serializable Struct:** A struct that can be serialized by Unity.
- **Basic Struct:** A basic struct definition.
- **Custom Editor:** A class for creating custom inspectors in Unity.
- **Custom Editor Window:** A template for creating custom editor windows in Unity.
- **Game Manager:** A simple Game Manager class for managing game state.
- **Singleton Game Manager:** A singleton Game Manager class that persists across scenes using `DontDestroyOnLoad`.
- **Singleton Game Manager (Without DontDestroyOnLoad):** A singleton Game Manager class that does not use `DontDestroyOnLoad`, accessible only through the Instance.

## Installation
To integrate this tool into your Unity project, follow these steps:
1. Clone or download the repository:
   ```bash
   git clone https://github.com/kfunal/ScriptCreatorByTemplates.git

## Contributing and License
Feel free to contribute by submitting pull requests or opening issues. This project is licensed under the MIT License. See the LICENSE file for more information.