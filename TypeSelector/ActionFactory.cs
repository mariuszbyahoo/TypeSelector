using System;

namespace TypeSelector
{
    public static class ActionFactory
    {
        public static IAction GetAction(string typeName)
        {
            // Create new action 
            Type actionType = Type.GetType(typeName, true, true);
            var actionInstance = Activator.CreateInstance(actionType);
            IAction action = actionInstance as IAction;
            return action;
        }
    }
}