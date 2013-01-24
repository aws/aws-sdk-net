/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Amazon.Util
{
    internal static class PaginatedResourceFactory
    {
        internal static object Create(PaginatedResourceInfo pri)
        {
            pri.Verify();

            MethodInfo openCreateMethod = typeof(PaginatedResourceFactory).GetMethod(
                "Create", 
                BindingFlags.Static | BindingFlags.NonPublic,
                null,
                new Type[] {typeof(object), typeof(string), typeof(object), typeof(string), typeof(string), typeof(string) },
                null);
            
            Type clientType = pri.Client.GetType();
            MethodInfo fetcherMethod = clientType.GetMethod(pri.MethodName);
            Type responseType = fetcherMethod.ReturnType;
            Type listItemType = GetPropertyTypeFromPath(responseType, pri.ItemListPropertyPath);
            MethodInfo closedCreateMethod = openCreateMethod.MakeGenericMethod(listItemType.GetGenericArguments());

            return closedCreateMethod.Invoke(null, new object[] { pri.Client, pri.MethodName, pri.Request, pri.TokenRequestPropertyPath, pri.TokenResponsePropertyPath, pri.ItemListPropertyPath });
        }

        private static PaginatedResource<ItemType> Create<ItemType>
            (object client, string methodName, object request, string tokenRequestPropertyPath, string tokenResponsePropertyPath, string itemListPropertyPath)
        {
            Type clientType = client.GetType();
            MethodInfo fetcherMethod = clientType.GetMethod(methodName);

            Type itemType = typeof(ItemType);
            Type responseType = fetcherMethod.ReturnType;
            Type requestType = fetcherMethod.GetParameters()[0].ParameterType;
            
            MethodInfo openGetFuncTypeMethod = typeof(PaginatedResourceFactory).GetMethod("GetFuncType", BindingFlags.Static | BindingFlags.NonPublic);
            MethodInfo closedGetFuncTypeMethod = openGetFuncTypeMethod.MakeGenericMethod(new Type[] { requestType, responseType });
            Type funcType = (Type)closedGetFuncTypeMethod.Invoke(null, null);
            Delegate d = Delegate.CreateDelegate(funcType, client, fetcherMethod, false);

            MethodInfo[] publicMethods = typeof(PaginatedResourceFactory).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
            MethodInfo closedCreateMethod = FindMethod(publicMethods, "Create", 3).MakeGenericMethod(new Type[] { itemType, requestType, responseType });

            return (PaginatedResource<ItemType>)closedCreateMethod.Invoke(null, new object[] { d, request, tokenRequestPropertyPath, tokenResponsePropertyPath, itemListPropertyPath });
        }

        private static PaginatedResource<ItemType> Create<ItemType>
            (Delegate d, object request, string tokenRequestPropertyPath, string tokenResponsePropertyPath, string itemListPropertyPath)
        {
            Type itemType = typeof(ItemType);
            Type responseType = d.Method.ReturnType;
            Type requestType = d.Method.GetParameters()[0].ParameterType;

            MethodInfo[] openCreateMethods = typeof(PaginatedResourceFactory).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
            MethodInfo closedCreateMethod = FindMethod(openCreateMethods,"Create",3).MakeGenericMethod(new Type[] { itemType, requestType, responseType });

            return (PaginatedResource<ItemType>)closedCreateMethod.Invoke(null, new object[] { d, request, tokenRequestPropertyPath, tokenResponsePropertyPath, itemListPropertyPath });
        }

        private static PaginatedResource<ItemType> Create<ItemType, RequestType, ResponseType>
            (Func<RequestType, ResponseType> call, RequestType request, string tokenRequestPropertyPath, string tokenResponsePropertyPath, string itemListPropertyPath)
        {
            Func<string, Marker<ItemType>> fetcher =
                token =>
                {
                    List<ItemType> currentItems;
                    string nextToken;

                    SetPropertyValueAtPath(request, tokenRequestPropertyPath, token);
                    ResponseType nextSet = call(request);

                    nextToken = GetPropertyValueFromPath<string>(nextSet, tokenResponsePropertyPath);
                    currentItems = GetPropertyValueFromPath<List<ItemType>>(nextSet, itemListPropertyPath);

                    return new Marker<ItemType>(currentItems, nextToken);
                };
            return new PaginatedResource<ItemType>(fetcher);
        }

        private static MethodInfo FindMethod(MethodInfo[] methods, string name, int typeArity)
        {
            List<MethodInfo> namedMethods = new List<MethodInfo>();

            foreach (MethodInfo method in methods)
            {
                if (method.Name.Equals(name))
                {
                    namedMethods.Add(method);
                }
            }

            return FindTypeArity(namedMethods, typeArity);
        }
        private static MethodInfo FindTypeArity(List<MethodInfo> methods, int typeArity)
        {
            MethodInfo ret = null;

            foreach (MethodInfo method in methods)
            {
                if (method.IsGenericMethod && method.GetGenericArguments().Length == typeArity)
                {
                    ret = method;
                    break;
                }
            }

            return ret;
        }
  
        private static void SetPropertyValueAtPath(object instance, string path, string value)
        {
            String[] propPath = path.Split('.');
            object currentValue = instance;
            Type currentType = instance.GetType();
            PropertyInfo currentProperty = null;
            int i = 0;
            for (; i < propPath.Length - 1; i++)
            {
                string property = propPath[i];
                currentProperty = currentType.GetProperty(property);
                currentValue = currentProperty.GetValue(currentValue, null);
                currentType = currentProperty.PropertyType;
            }
            currentProperty = currentType.GetProperty(propPath[i]);
            currentProperty.SetValue(currentValue, value, null);
        }
        private static T GetPropertyValueFromPath<T>(object instance, string path)
        {
            String[] propPath = path.Split('.');
            object currentValue = instance;
            Type currentType = instance.GetType();
            PropertyInfo currentProperty = null;
            MethodInfo openCastMethod = typeof(PaginatedResourceFactory).GetMethod("Cast", BindingFlags.Static | BindingFlags.NonPublic);
            foreach (string property in propPath)
            {
                MethodInfo closedCastMethod = openCastMethod.MakeGenericMethod(new Type[] { currentType });
                currentProperty = currentType.GetProperty(property);
                currentValue = currentProperty.GetValue(closedCastMethod.Invoke(null, new object[] { currentValue }), null);
                currentType = currentProperty.PropertyType;
            }
            return (T)currentValue;
        }
        internal static Type GetPropertyTypeFromPath(Type start, string path)
        {
            String[] propPath = path.Split('.');
            Type currentType = start;
            PropertyInfo currentProperty = null;
            foreach (string property in propPath)
            {
                currentProperty = currentType.GetProperty(property);
                currentType = currentProperty.PropertyType;
            }
            return currentType;
        }

        private static Type GetFuncType<T,U>()
        {
            return typeof(Func<T,U>);
        }
        internal static T Cast<T>(object o)
        {
            return (T)o;
        }
    }

    internal class PaginatedResourceInfo
    {
        private string tokenRequestPropertyPath;
        private string tokenResponsePropertyPath;

        internal object Client
        {
            get;
            set;
        }
        internal string MethodName
        {
            get;
            set;
        }
        internal object Request
        {
            get;
            set;
        }
        internal string TokenRequestPropertyPath
        {
            get 
            {
                string ret = tokenRequestPropertyPath;
                if (String.IsNullOrEmpty(ret))
                {
                    ret = "NextToken";
                }
                return ret;
            }
            set { tokenRequestPropertyPath = value; }
        }
        internal string TokenResponsePropertyPath
        {
            get
            {
                string ret = tokenResponsePropertyPath;
                if (String.IsNullOrEmpty(ret))
                {
                    ret = "{0}";
                    if (Client != null && !String.IsNullOrEmpty(MethodName))
                    {
                        MethodInfo mi = Client.GetType().GetMethod(MethodName);
                        if (mi != null)
                        {
                            Type responseType = mi.ReturnType;
                            string baseName = responseType.Name;
                            if (baseName.EndsWith("Response"))
                            {
                                baseName = baseName.Substring(0, baseName.Length-8);
                            }
                            if (responseType.GetProperty(String.Format("{0}Result", baseName)) != null)
                            {
                                ret = String.Format(ret,String.Format("{0}Result.{1}", baseName, "{0}"));
                            }
                        }
                    }
                    ret = String.Format(ret, "NextToken");
                }
                return ret;
            }
            set { tokenResponsePropertyPath = value; }
        }
        internal string ItemListPropertyPath
        {
            get;
            set;
        }

        internal PaginatedResourceInfo WithClient(object client)
        {
            Client = client;
            return this;
        }

        internal PaginatedResourceInfo WithMethodName(string methodName)
        {
            MethodName = methodName;
            return this;
        }

        internal PaginatedResourceInfo WithRequest(object request)
        {
            Request = request;
            return this;
        }

        internal PaginatedResourceInfo WithTokenRequestPropertyPath(string tokenRequestPropertyPath)
        {
            TokenRequestPropertyPath = tokenRequestPropertyPath;
            return this;
        }

        internal PaginatedResourceInfo WithTokenResponsePropertyPath(string tokenResponsePropertyPath)
        {
            TokenResponsePropertyPath = tokenResponsePropertyPath;
            return this;
        }

        internal PaginatedResourceInfo WithItemListPropertyPath(string itemListPropertyPath)
        {
            ItemListPropertyPath = itemListPropertyPath;
            return this;
        }

        internal void Verify()
        {
            //Client is set
            if (Client == null)
            {
                throw new ArgumentException("PaginatedResourceInfo.Client needs to be set.");
            }

            //MethodName exists on Client and takes one arguement.
            Type clientType = Client.GetType();
            MethodInfo mi = clientType.GetMethod(MethodName);
            if (mi == null)
            {
                throw new ArgumentException(String.Format("{0} has no method called {1}", clientType.Name, MethodName));
            }
            if (mi.GetParameters().Length != 1)
            {
                throw new ArgumentException(String.Format("{1} on {0} has incompatable signiture", clientType.Name, MethodName));
            }

            //Request is valid type.
            Type requestType = mi.GetParameters()[0].ParameterType;
            try
            {
                MethodInfo openCastMethod = typeof(PaginatedResourceFactory).GetMethod("Cast", BindingFlags.Static | BindingFlags.NonPublic);
                MethodInfo closedCastMethod = openCastMethod.MakeGenericMethod(new Type[] { requestType });
                closedCastMethod.Invoke(null, new object[] { Request });
            }
            catch (Exception)
            {
                throw new ArgumentException("PaginatedResourcInfo.Request is an incompatible type.");
            }

            //Properties exist 
            Type responseType = mi.ReturnType;
            VerifyProperty("TokenRequestPropertyPath", requestType, TokenRequestPropertyPath, typeof(string));
            VerifyProperty("TokenResponsePropertyPath", responseType, TokenResponsePropertyPath, typeof(string));
            VerifyProperty("ItemListPropertyPath", responseType, ItemListPropertyPath, typeof(string), true);
        }
        private void VerifyProperty(string propName, Type start, string path, Type expectedType)
        {
            VerifyProperty(propName, start, path, expectedType, false);
        }
        private void VerifyProperty(string propName, Type start, string path, Type expectedType, bool skipTypecheck)
        {
            Type type = null;
            if (String.IsNullOrEmpty(path))
            {
                throw new ArgumentException(String.Format("{0} must contain a value.", propName));
            }
            try
            {
                type = PaginatedResourceFactory.GetPropertyTypeFromPath(start, path);
            }
            catch (Exception)
            {
                throw new ArgumentException(String.Format("{0} does not exist on {1}", path, start.Name));
            }
            if (!skipTypecheck && type != expectedType)
            {
                throw new ArgumentException(String.Format("{0} on {1} is not of type {2}", path, start.Name, expectedType.Name));
            }
        }
    }
}
