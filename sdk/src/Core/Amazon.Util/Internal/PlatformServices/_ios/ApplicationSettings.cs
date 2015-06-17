using Foundation;
using Security;
using System;


namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationSettings : IApplicationSettings
    {
        public void SetValue(string key, string value, ApplicationSettingsMode mode)
        {
            var rec = new SecRecord(SecKind.GenericPassword)
            {
                Generic = NSData.FromString(key)
            };

            //if the record already existings we will delete them, so that we dont get duplicate error, alternatively you can use the update api as well.
            SecStatusCode res;
            var match = SecKeyChain.QueryAsRecord(rec, out res);
            if (res == SecStatusCode.Success)
            {
                SecKeyChain.Remove(match);
            }

            rec = new SecRecord(SecKind.GenericPassword)
            {
                Generic = NSData.FromString(key, NSStringEncoding.UTF8),
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
                Generic = NSData.FromString(key)
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
    }
}