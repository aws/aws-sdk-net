using System;
using System.Collections.Generic;

namespace ThirdParty.iOS4Unity
{
    public static class Runtime
    {
        private static object _contructorLock = new object(), _objectLock = new object();

        private static readonly Dictionary<Type, Func<IntPtr, object>> _constructors = new Dictionary<Type, Func<IntPtr, object>>
        {
            {typeof(AdBannerView), h=>new AdBannerView(h)},
            { typeof(NSBundle), h => new NSBundle(h) },
            { typeof(NSData), h => new NSData(h) },
            { typeof(NSDictionary), h => new NSDictionary(h) },
            { typeof(NSMutableDictionary), h => new NSMutableDictionary(h) },
            { typeof(NSError), h => new NSError(h) },
            { typeof(NSLocale), h => new NSLocale(h) },
            { typeof(NSNotification), h => new NSNotification(h) },
            { typeof(NSNotificationCenter), h => new NSNotificationCenter(h) },
            { typeof(NSNumberFormatter), h => new NSNumberFormatter(h) },
            { typeof(NSObject), h => new NSObject(h) },
            { typeof(NSTimeZone), h => new NSTimeZone(h) },
            { typeof(SKPayment), h => new SKPayment(h) },
            { typeof(SKPaymentQueue), h => new SKPaymentQueue(h) },
            { typeof(SKPaymentTransaction), h => new SKPaymentTransaction(h) },
            { typeof(SKProduct), h => new SKProduct(h) },
            { typeof(SKProductsRequest), h => new SKProductsRequest(h) },
            { typeof(SKProductsResponse), h => new SKProductsResponse(h) },
            { typeof(UIActionSheet), h => new UIActionSheet(h) },
            { typeof(UIActivityViewController), h => new UIActivityViewController(h) },
            { typeof(UIAlertView), h => new UIAlertView(h) },
            { typeof(UIApplication), h => new UIApplication(h) },
            { typeof(UIDevice), h => new UIDevice(h) },
            { typeof(UIImage), h => new UIImage(h) },
			{ typeof(UILocalNotification), h => new UILocalNotification(h) },
            { typeof(UIScreen), h => new UIScreen(h) },
            { typeof(UIScreenMode), h => new UIScreenMode(h) },
            { typeof(UIUserNotificationSettings), h => new UIUserNotificationSettings(h) },
            { typeof(UIView), h => new UIView(h) },
            { typeof(UIViewController), h => new UIViewController(h) },
            { typeof(UIWindow), h => new UIWindow(h) },
        };

        private static readonly Dictionary<IntPtr, object> _objects = new Dictionary<IntPtr, object>();

        public static void RegisterType<T>(Func<IntPtr, object> constructor) where T : NSObject
        {
            lock (_contructorLock)
            {
                _constructors[typeof(T)] = constructor;
            }
        }

        public static T GetNSObject<T>(IntPtr handle) where T : NSObject
        {
            if (handle == IntPtr.Zero)
                return null;

            //For our unit tests, we need to validate that the object is in the constructor list
#if DEBUG
            Func<IntPtr, object> constructor;
            lock (_contructorLock)
            {
                if (!_constructors.TryGetValue(typeof(T), out constructor))
                {
                    throw new NotImplementedException("Type's constructor not registered: " + typeof(T));
                }
            }
#endif

            lock (_objectLock)
            {
                object obj;
                if (_objects.TryGetValue(handle, out obj))
                    return (T)obj;
            }

            return ConstructNSObject<T>(handle);
        }

        private static T ConstructNSObject<T>(IntPtr handle) where T : NSObject
        {
            Func<IntPtr, object> constructor;
            lock (_contructorLock)
            {
                if (!_constructors.TryGetValue(typeof(T), out constructor))
                {
                    throw new NotImplementedException("Type's constructor not registered: " + typeof(T));
                }
            }
            return (T)constructor(handle);
        }

        public static void RegisterNSObject(NSObject obj)
        {
            if (obj == null || obj.Handle == IntPtr.Zero)
                return;

            lock (_objectLock)
            {
                _objects[obj.Handle] = obj;
            }
        }

        public static void UnregisterNSObject(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
                return;

            lock (_objectLock)
            {
                _objects.Remove(handle);
            }
        }
    }
}