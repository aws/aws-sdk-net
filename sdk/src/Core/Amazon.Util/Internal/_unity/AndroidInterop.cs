/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace Amazon.Util.Internal
{
    /// <summary>
    /// This class is used to make Android Java calls as an alternative to using Android macro's
    /// The class uses reflection but doesnto cache the PropertyInfo and MethodInfo, 
    /// so it should be sparingly used so as not to impact performance.
    /// </summary>
    public class AndroidInterop
    {
        /// <summary>
        /// The API makes a call to a static java method on a class and returns a typed parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static T CallStaticJavaMethod<T>(string className, string methodName, params object[] parameters)
        {
            Type androidJavaClassType = InternalSDKUtils.GetTypeFromUnityEngine("AndroidJavaClass");
            if (androidJavaClassType != null)
            {
                var javaUnityHelper = Activator.CreateInstance(androidJavaClassType, className);
                var callStaticMethod = androidJavaClassType.GetMethods()
                  .Where(x => x.Name == "CallStatic")
                  .FirstOrDefault();
                if (callStaticMethod != null)
                {
                    return (T)callStaticMethod.Invoke(javaUnityHelper, new object[] { methodName, parameters });
                }
            }
            return default(T);
        }

        /// <summary>
        /// The API makes a call to a static java method on a class and returns an object of Type AndroidJavaObject
        /// </summary>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public static object GetJavaObjectStatically(string className, string methodName)
        {
            Type androidJavaClassType = InternalSDKUtils.GetTypeFromUnityEngine("AndroidJavaClass");
            Type androidJavaObjectType = InternalSDKUtils.GetTypeFromUnityEngine("AndroidJavaObject");
            if (androidJavaClassType != null)
            {
                var javaClass = Activator.CreateInstance(androidJavaClassType, className);
                var callStaticMethod = androidJavaClassType.GetMethods()
                    .Where(x => x.Name == "CallStatic")
                    .First(x => x.ContainsGenericParameters);

                var genericStaticMethod = callStaticMethod.MakeGenericMethod(androidJavaObjectType);

                return genericStaticMethod.Invoke(javaClass, new object[] { methodName, new object[] { } });
            }
            return null;
        }

        /// <summary>
        /// This API makes a call to a method on an Object by passing the specified parameters and returns a typed parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="androidJavaObject"></param>
        /// <param name="methodName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static T CallMethod<T>(object androidJavaObject, string methodName, params object[] parameters)
        {
            var method = androidJavaObject.GetType().GetMethods().Where(x => x.Name == "Call").First(x => x.ContainsGenericParameters);
            var genericMethod = method.MakeGenericMethod(typeof(T));
            return (T)genericMethod.Invoke(androidJavaObject, new object[] { methodName, parameters });
        }

        /// <summary>
        /// This API makes a call to a method on an Object by passing the specified parameters and returns an object of type AndroidJavaObject
        /// </summary>
        /// <param name="androidJavaObject"></param>
        /// <param name="methodName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static object CallMethod(object androidJavaObject, string methodName, params object[] parameters)
        {
            Type androidJavaObjectType = InternalSDKUtils.GetTypeFromUnityEngine("AndroidJavaObject");
            var method = androidJavaObject.GetType().GetMethods()
                .Where(x => x.Name == "Call")
                .First(x => x.ContainsGenericParameters);
            var genericMethod = method.MakeGenericMethod(androidJavaObjectType);
            return genericMethod.Invoke(androidJavaObject, new object[] { methodName, parameters });
        }

        /// <summary>
        /// This API get a typed value from a static field 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public static T GetStaticJavaField<T>(string className, string methodName)
        {
            Type androidJavaClassType = InternalSDKUtils.GetTypeFromUnityEngine("AndroidJavaClass");
            if (androidJavaClassType != null)
            {
                var javaUnityHelper = Activator.CreateInstance(androidJavaClassType, className);
                var staticGetter = androidJavaClassType.GetMethod("GetStatic");
                var genericGetter = staticGetter.MakeGenericMethod(typeof(T));

                if (genericGetter != null)
                {
                    return (T)genericGetter.Invoke(javaUnityHelper, new object[] { methodName });
                }
            }

            return default(T);
        }

        /// <summary>
        /// This API returns a value of type AndroidJavaObject from a static field
        /// </summary>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public static object GetStaticJavaField(string className, string methodName)
        {
            Type androidJavaClassType = InternalSDKUtils.GetTypeFromUnityEngine("AndroidJavaClass");
            Type androidJavaObjectType = InternalSDKUtils.GetTypeFromUnityEngine("AndroidJavaObject");
            if (androidJavaClassType != null)
            {
                var javaUnityHelper = Activator.CreateInstance(androidJavaClassType, className);
                var staticGetter = androidJavaClassType.GetMethod("GetStatic");
                var genericGetter = staticGetter.MakeGenericMethod(androidJavaObjectType);

                if (genericGetter != null)
                {
                    return genericGetter.Invoke(javaUnityHelper, new object[] { methodName });
                }
            }
            return null;
        }

        /// <summary>
        /// This API returns a value of type AndroidJavaObject from a field on an android java object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="androidJavaObject"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public static T GetJavaField<T>(object androidJavaObject, string methodName)
        {
            var method = androidJavaObject.GetType().GetMethods().Where(x => x.Name == "Get").First(x => x.ContainsGenericParameters);
            var genericMethod = method.MakeGenericMethod(typeof(T));
            return (T)genericMethod.Invoke(androidJavaObject, new object[] { methodName });
        }

        /// <summary>
        /// Returns an AndroidJavaObject 
        /// </summary>
        /// <returns></returns>
        public static object GetAndroidContext()
        {
            return GetStaticJavaField("com.unity3d.player.UnityPlayer", "currentActivity");
        }

    }
}
