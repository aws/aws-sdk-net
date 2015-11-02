using System;
using System.Collections.Generic;

#if XAMARIN
using MonoTouch;
#else
using AOT;
#endif

namespace ThirdParty.iOS4Unity
{
    public static class Callbacks
    {
        private static readonly Dictionary<string, Delegate> _delegates = new Dictionary<string, Delegate>();
        private static readonly Dictionary<IntPtr, Dictionary<IntPtr, Methods>> _callbacks = new Dictionary<IntPtr, Dictionary<IntPtr, Methods>>();

        private class Methods
        {
            public Action Action;
            public IntPtrHandler ActionIntPtr;
            public IntPtrHandler2 ActionIntPtrIntPtr;
            public IntPtrHandler3 ActionIntPtrIntPtrIntPtr;
            public EventHandler EventHandler;
            public EventHandler<ButtonEventArgs> EventHandlerInt;
            public readonly object Object;

            public Methods(object obj)
            {
                Object = obj;
            }
        }

        private static Methods GetMethods(NSObject obj, string selector)
        {
            Dictionary<IntPtr, Methods> dictionary;
            if (!_callbacks.TryGetValue(obj.Handle, out dictionary))
            {
                _callbacks[obj.Handle] = dictionary = new Dictionary<IntPtr, Methods>();
            }

            IntPtr selectorHandle = ObjC.GetSelector(selector);

            Methods methods;
            if (!dictionary.TryGetValue(selectorHandle, out methods))
            {
                dictionary[selectorHandle] = methods = new Methods(obj);
            }

            return methods;
        }

        public static void Subscribe(NSObject obj, string selector, IntPtrHandler callback)
        {
            var methods = GetMethods(obj, selector);
            methods.ActionIntPtr += callback;

            if (!_delegates.ContainsKey(selector))
            {
                IntPtrHandler3 del = OnCallback;
                if (!ObjC.AddMethod(obj.ClassHandle, Selector.GetHandle(selector), del, "v@:@"))
                {
                    throw new InvalidOperationException("AddMethod failed for selector " + selector);
                }
                else
                {
                    _delegates[selector] = del;
                }
            }
        }

        public static void Subscribe(NSObject obj, string selector, EventHandler callback)
        {
            var methods = GetMethods(obj, selector);
            methods.EventHandler += callback;

            if (!_delegates.ContainsKey(selector))
            {
                IntPtrHandler3 del = OnCallback;
                if (!ObjC.AddMethod(obj.ClassHandle, Selector.GetHandle(selector), del, "v@:@"))
                {
                    throw new InvalidOperationException("AddMethod failed for selector " + selector);
                }
                else
                {
                    _delegates[selector] = del;
                }
            }
        }

        public static void Subscribe(NSObject obj, string selector, EventHandler<ButtonEventArgs> callback)
        {
            var methods = GetMethods(obj, selector);
            methods.EventHandlerInt += callback;

            if (!_delegates.ContainsKey(selector))
            {
                Action<IntPtr, IntPtr, IntPtr, int> del = OnCallbackInt;
                if (!ObjC.AddMethod(obj.ClassHandle, Selector.GetHandle(selector), del, "v@:@l"))
                {
                    throw new InvalidOperationException("AddMethod failed for selector " + selector);
                }
                else
                {
                    _delegates[selector] = del;
                }
            }
        }

        public static void Subscribe(NSObject obj, string selector, IntPtrHandler2 callback)
        {
            var methods = GetMethods(obj, selector);
            methods.ActionIntPtrIntPtr += callback;

            if (!_delegates.ContainsKey(selector))
            {
                IntPtrHandler4 del = OnCallbackIntPtrIntPtr;
                if (!ObjC.AddMethod(obj.ClassHandle, Selector.GetHandle(selector), del, "v@:@@"))
                {
                    throw new InvalidOperationException("AddMethod failed for selector " + selector);
                }
                else
                {
                    _delegates[selector] = del;
                }
            }
        }

        public static void Subscribe(NSObject obj, string selector, IntPtrHandler3 callback)
        {
            var methods = GetMethods(obj, selector);
            methods.ActionIntPtrIntPtrIntPtr += callback;

            if (!_delegates.ContainsKey(selector))
            {
                IntPtrHandler5 del = OnCallbackIntPtrIntPtrIntPtr;
                if (!ObjC.AddMethod(obj.ClassHandle, Selector.GetHandle(selector), del, "v@:@@@"))
                {
                    throw new InvalidOperationException("AddMethod failed for selector " + selector);
                }
                else
                {
                    _delegates[selector] = del;
                }
            }
        }

        public static void Unsubscribe(NSObject obj, string selector, Action callback)
        {
            var methods = GetMethods(obj, selector);
            methods.Action -= callback;
        }

        public static void Unsubscribe(NSObject obj, string selector, IntPtrHandler callback)
        {
            var methods = GetMethods(obj, selector);
            methods.ActionIntPtr -= callback;
        }

        public static void Unsubscribe(NSObject obj, string selector, IntPtrHandler2 callback)
        {
            var methods = GetMethods(obj, selector);
            methods.ActionIntPtrIntPtr -= callback;
        }

        public static void Unsubscribe(NSObject obj, string selector, IntPtrHandler3 callback)
        {
            var methods = GetMethods(obj, selector);
            methods.ActionIntPtrIntPtrIntPtr -= callback;
        }

        public static void Unsubscribe(NSObject obj, string selector, EventHandler callback)
        {
            var methods = GetMethods(obj, selector);
            methods.EventHandler -= callback;
        }

        public static void Unsubscribe(NSObject obj, string selector, EventHandler<ButtonEventArgs> callback)
        {
            var methods = GetMethods(obj, selector);
            methods.EventHandlerInt -= callback;
        }

        public static void UnsubscribeAll(NSObject obj)
        {
            _callbacks.Remove(obj.Handle);
        }

        [MonoPInvokeCallback(typeof(IntPtrHandler3))]
        private static void OnCallback(IntPtr @this, IntPtr selector, IntPtr arg1)
        {
            Dictionary<IntPtr, Methods> dictionary;
            if (_callbacks.TryGetValue(@this, out dictionary))
            {
                Methods methods;
                if (dictionary.TryGetValue(selector, out methods))
                {
                    var action = methods.Action;
                    if (action != null)
                        action();

                    var actionIntPtr = methods.ActionIntPtr;
                    if (actionIntPtr != null)
                        actionIntPtr(arg1);

                    var eventHandler = methods.EventHandler;
                    if (eventHandler != null)
                        eventHandler(methods.Object, EventArgs.Empty);
                }
            }
        }

        [MonoPInvokeCallback(typeof(Action<IntPtr, IntPtr, IntPtr, int>))]
        private static void OnCallbackInt(IntPtr @this, IntPtr selector, IntPtr arg1, int arg2)
        {
            Dictionary<IntPtr, Methods> dictionary;
            if (_callbacks.TryGetValue(@this, out dictionary))
            {
                Methods methods;
                if (dictionary.TryGetValue(selector, out methods))
                {
                    var eventHandler = methods.EventHandlerInt;
                    if (eventHandler != null)
                    {
                        eventHandler(methods.Object, new ButtonEventArgs { Index = arg2 });
                    }
                }
            }
        }

        [MonoPInvokeCallback(typeof(IntPtrHandler4))]
        private static void OnCallbackIntPtrIntPtr(IntPtr @this, IntPtr selector, IntPtr arg1, IntPtr arg2)
        {
            Dictionary<IntPtr, Methods> dictionary;
            if (_callbacks.TryGetValue(@this, out dictionary))
            {
                Methods methods;
                if (dictionary.TryGetValue(selector, out methods))
                {
                    var action = methods.ActionIntPtrIntPtr;
                    if (action != null)
                    {
                        action(arg1, arg2);
                    }
                }
            }
        }

        [MonoPInvokeCallback(typeof(IntPtrHandler5))]
        private static void OnCallbackIntPtrIntPtrIntPtr(IntPtr @this, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3)
        {
            Dictionary<IntPtr, Methods> dictionary;
            if (_callbacks.TryGetValue(@this, out dictionary))
            {
                Methods methods;
                if (dictionary.TryGetValue(selector, out methods))
                {
                    var action = methods.ActionIntPtrIntPtrIntPtr;
                    if (action != null)
                    {
                        action(arg1, arg2, arg3);
                    }
                }
            }
        }
    }
}