using System;

namespace ThirdParty.iOS4Unity
{
    public class UIUserNotificationSettings : NSObject
    {
        private static readonly IntPtr _classHandle;

        static UIUserNotificationSettings()
        {
            _classHandle = ObjC.GetClass("UIUserNotificationSettings");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        public UIUserNotificationSettings()
        {
            ObjC.MessageSendIntPtr(Handle, Selector.Init);
        }

        internal UIUserNotificationSettings(IntPtr handle)
            : base(handle)
        {
        }

        public static UIUserNotificationSettings GetSettingsForTypes(UIUserNotificationType types)
        {
            //NOTE: right now we don't have support for categories, it required UIUserNotificationCategory, which is a somewhat advanced scenario I'd say
            IntPtr handle = ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("settingsForTypes:categories:"), (uint)types, IntPtr.Zero);
            return Runtime.GetNSObject<UIUserNotificationSettings>(handle);
        }

        public UIUserNotificationType Types
        {
            get { return (UIUserNotificationType)ObjC.MessageSendUInt(Handle, Selector.GetHandle("types")); }
        }
    }

    [CLSCompliant(false)]
    public enum UIUserNotificationType : uint
    {
        None = 0,
        Badge = 1,
        Sound = 2,
        Alert = 4
    }
}
