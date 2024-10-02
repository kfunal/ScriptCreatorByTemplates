namespace ScriptCreatorByTemplates.Constants
{
    public static class Priorities
    {
        public const int MONOBEHAVIOUR_PRIORITY = 1;
        public const int INTERFACE_PRIORITY = 2;

        public const int SCRIPTABLE_OBJECT_PRIORITY = 3;
        public const int SINGLETON_SCRIPTABLE_OBJECT_PRIORITY = 4;

        public const int SERIALIZABLE_CLASS_PRIORITY = 5;
        public const int CLASS_PRIORITY = 6;
        public const int CLASS_WITH_CONSTRUCTOR_PRIORITY = 7;
        public const int STATIC_CLASS_PRIORITY = 7;
        public const int STATIC_CLASS_WITH_CONSTRUCTOR_PRIORITY = 8;
        public const int SERIALIZABLE_STRUCT_PRIORITY = 9;
        public const int STRUCT_PRIORITY = 10;

        public const int CUSTOM_EDITOR_PRIORITY = 11;
        public const int CUSTOM_EDITOR_WINDOW_PRIORITY = 12;

        public const int GAME_MANAGER_PRIORITY = 13;
        public const int SINGLETON_GAME_MANAGER_PRIORITY = 14;
        public const int SINGLETON_GAME_MANAGER_ONLY_INSTANCE_PRIORITY = 15;
    }
}
