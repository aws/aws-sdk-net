using Foundation;
using Security;
using System;


namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationSettings : IApplicationSettings
    {

        private const string ServiceName = @"AWS";

        public void SetValue(string key, string value, ApplicationSettingsMode mode)
        {
            if (RecordExists(key))
                RemoveValue(key, mode);

            var rec = new SecRecord(SecKind.GenericPassword)
            {
                Label = key,
                Account = key,
                Service = ServiceName,
                Accessible = SecAccessible.Always,
                Synchronizable = false,
                ValueData = NSData.FromString(value, NSStringEncoding.UTF8)
            };

            var err = SecKeyChain.Add(rec);

            if (err != SecStatusCode.Success)
            {
                throw new Exception(string.Format("Application Settings exception, Unable to store key {0}, got error: {1}", key, err.ToString()));
            }
        }

        public string GetValue(string key, ApplicationSettingsMode mode)
        {
            var rec = new SecRecord(SecKind.GenericPassword)
            {
                Label = key,
                Service = ServiceName,
                Account = key
            };

            SecStatusCode res;
            var match = SecKeyChain.QueryAsRecord(rec, out res);
            if (res != SecStatusCode.Success)
            {
                return string.Empty;
            }
            else
            {
                return NSString.FromData(match.ValueData, NSStringEncoding.UTF8);
            }
        }

        public void RemoveValue(string key, ApplicationSettingsMode mode)
        {
            var rec = new SecRecord(SecKind.GenericPassword)
            {
                Label = key,
                Service = ServiceName,
                Account = key
            };

            var res = SecKeyChain.Remove(rec);
        }

        
        private bool RecordExists(string key)
        {
            var rec = new SecRecord(SecKind.GenericPassword)
            {
                Service = ServiceName,
                Label = key,
                Account = key
            };

            SecStatusCode res;
            var match = SecKeyChain.QueryAsRecord(rec, out res);
            if (res == SecStatusCode.Success)
            {
                return true;
            }

            return false;
        }

        
    }
}