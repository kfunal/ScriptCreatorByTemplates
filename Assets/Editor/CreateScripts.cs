using UnityEditor;
using static ScriptCreatorByTemplates.Constants.MenuPaths;
using static ScriptCreatorByTemplates.Constants.TemplatePaths;
using static ScriptCreatorByTemplates.Constants.Priorities;
using static ScriptCreatorByTemplates.Constants.DefaultScriptNames;

namespace ScriptCreatorByTemplates
{
    public static class CreateScripts
    {
        // Common method for creating script assets
        private static void CreateScriptAsset(string _templatePath, string _scriptName) => ProjectWindowUtil.CreateScriptAssetFromTemplateFile(_templatePath, _scriptName);

        //Other
        [MenuItem(MONOBEHAVIOUR_MENU_PATH, priority = MONOBEHAVIOUR_PRIORITY)]
        public static void CreateMonoBehaviourMenuItem() => CreateScriptAsset(MONOBEHAVIOUR_TEMPLATE_PATH, NEW_MONOBEHAVIOUR_SCRIPT);

        [MenuItem(INTERFACE_MENU_PATH, priority = INTERFACE_PRIORITY)]
        public static void CreateInterfaceMenuItem() => CreateScriptAsset(INTERFACE_TEMPLATE_PATH, NEW_INTERFACE_SCRIPT);

        //Scriptable Object
        [MenuItem(SCRIPTABLE_OBJECT_MENU_PATH, priority = SCRIPTABLE_OBJECT_PRIORITY)]
        public static void CreateScriptableObjectScriptMenuItem() => CreateScriptAsset(SCRIPTABLE_OBJECT_TEMPLATE_PATH, NEW_SCRIPTABLE_OBJECT_SCRIPT);

        [MenuItem(SINGLETON_SCRIPTABLE_OBJECT_MENU_PATH, priority = SINGLETON_SCRIPTABLE_OBJECT_PRIORITY)]
        public static void CreateSingletonScriptableObjectScriptMenuItem() => CreateScriptAsset(SINGLETON_SCRIPTABLE_OBJECT_TEMPLATE_PATH, NEW_SINGLETON_SCRIPTABLE_OBJECT_SCRIPT);

        //Class
        [MenuItem(SERIALIZABLE_CLASS_MENU_PATH, priority = SERIALIZABLE_CLASS_PRIORITY)]
        public static void CreateSerializableClassMenuItem() => CreateScriptAsset(SERIALIZABLE_CLASS_TEMPLATE_PATH, NEW_SERIALIZABLE_CLASS_SCRIPT);

        [MenuItem(CLASS_MENU_PATH, priority = CLASS_PRIORITY)]
        public static void CreateClassMenuItem() => CreateScriptAsset(CLASS_TEMPLATE_PATH, NEW_CLASS_SCRIPT);

        [MenuItem(CLASS_WITH_CONSTRUCTOR_MENU_PATH, priority = CLASS_WITH_CONSTRUCTOR_PRIORITY)]
        public static void CreateClassWithConstructorMenuItem() => CreateScriptAsset(CLASS_WITH_CONSTRUCTOR_TEMPLATE_PATH, NEW_CLASS_WITH_CONSTRUCTOR_SCRIPT);

        [MenuItem(STATIC_CLASS_MENU_PATH, priority = STATIC_CLASS_PRIORITY)]
        public static void CreateStaticClassMenuItem() => CreateScriptAsset(STATIC_CLASS_TEMPLATE_PATH, NEW_STATIC_CLASS_SCRIPT);

        [MenuItem(STATIC_CLASS_WITH_CONSTRUCTOR_MENU_PATH, priority = STATIC_CLASS_WITH_CONSTRUCTOR_PRIORITY)]
        public static void CreateStaticClassWithConstructorMenuItem() => CreateScriptAsset(STATIC_CLASS_WITH_CONSTRUCTOR_TEMPLATE_PATH, NEW_STATIC_CLASS_WITH_CONSTRUCTOR_SCRIPT);

        //Struct
        [MenuItem(SERIALIZABLE_STRUCT_MENU_PATH, priority = SERIALIZABLE_STRUCT_PRIORITY)]
        public static void CreateSerializableStructMenuItem() => CreateScriptAsset(SERIALIZABLE_STRUCT_TEMPLATE_PATH, NEW_SERIALIZABLE_STRUCT_SCRIPT);

        [MenuItem(STRUCT_MENU_PATH, priority = STRUCT_PRIORITY)]
        public static void CreateStructMenuItem() => CreateScriptAsset(STRUCT_TEMPLATE_PATH, NEW_STRUCT_SCRIPT);

        //Editor
        [MenuItem(CUSTOM_EDITOR_MENU_PATH, priority = CUSTOM_EDITOR_PRIORITY)]
        public static void CreateCustomEditorMenuItem() => CreateScriptAsset(CUSTOM_EDITOR_TEMPLATE_PATH, NEW_CUSTOM_EDITOR_SCRIPT);

        [MenuItem(CUSTOM_EDITOR_WINDOW_MENU_PATH, priority = CUSTOM_EDITOR_WINDOW_PRIORITY)]
        public static void CreateCustomEditorWindowMenuItem() => CreateScriptAsset(CUSTOM_EDITOR_WINDOW_TEMPLATE_PATH, NEW_CUSTOM_EDITOR_WINDOW_SCRIPT);

        //Game Manager
        [MenuItem(GAME_MANAGER_MENU_PATH, priority = GAME_MANAGER_PRIORITY)]
        public static void CreateGameManagerMenuItem() => CreateScriptAsset(GAME_MANAGER_TEMPLATE_PATH, NEW_GAME_MANAGER_SCRIPT);

        [MenuItem(SINGLETON_GAME_MANAGER_MENU_PATH, priority = SINGLETON_GAME_MANAGER_PRIORITY)]
        public static void CreateSingletonGameManagerMenuItem() => CreateScriptAsset(SINGLETON_GAME_MANAGER_TEMPLATE_PATH, NEW_GAME_MANAGER_SCRIPT);

        [MenuItem(SINGLETON_GAME_MANAGER_ONLY_INSTANCE_MENU_PATH, priority = SINGLETON_GAME_MANAGER_ONLY_INSTANCE_PRIORITY)]
        public static void CreateSingletonGameManagerOnlyInstanceMenuItem() => CreateScriptAsset(SINGLETON_GAME_MANAGER_ONLY_INSTANCE_TEMPLATE_PATH, NEW_GAME_MANAGER_SCRIPT);
    }

}
