/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Net;
using System.Text.RegularExpressions;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal.PlatformServices;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using ThirdParty.RuntimeBackports;

namespace Amazon.Util.Internal
{
    public static partial class InternalSDKUtils
    {
        #region UserAgent
        static string _overrideVersionNumber;
        static string _customData;
        const string USER_AGENT_VERSION = "ua/2.1";

        // Define a regular expression to match disallowed characters
        private const string DisallowedCharactersRegexPattern = "[^ /!#$%&'*+-.^_`|~\\w\\d]";

#if NET8_0_OR_GREATER
        [GeneratedRegex(DisallowedCharactersRegexPattern)]
        private static partial Regex DisallowedCharactersRegex();
#else
        private static Regex DisallowedCharactersRegex() => _disallowedCharactersRegex;
        private static readonly Regex _disallowedCharactersRegex = new Regex(DisallowedCharactersRegexPattern, RegexOptions.Compiled);
#endif

        public static void SetUserAgent(string productName, string versionNumber)
        {
            SetUserAgent(productName, versionNumber, null);
        }

        public static void SetUserAgent(string productName, string versionNumber, string customData)
        {
            _userAgentBaseName = productName;
            _overrideVersionNumber = versionNumber;
            _customData = customData;
        }

        /// <summary>
        /// Replace disallowed characters by a hyphen in <paramref name="userAgent"/>
        /// </summary>
        /// <param name="userAgent"> Unsanitized user agent string</param>
        /// <returns> Sanitized user agent string </returns>
        internal static string ReplaceInvalidUserAgentCharacters(string userAgent)
        {
            // Use the regular expression to replace disallowed characters by a hyphen
            var validUserAgent = DisallowedCharactersRegex().Replace(userAgent, "-");

            return validUserAgent;
        }

        /// <summary>
        /// Build user agent string statically. This method is currently used by PowerShell and high level libraries.
        /// </summary>
        /// <param name="serviceSdkVersion"> Version of the service </param>
        /// <returns> User agent header string </returns>
        public static string BuildUserAgentString(string serviceSdkVersion)
        {
            return BuildUserAgentString(string.Empty, serviceSdkVersion);
        }

        /// <summary>
        /// Build user agent string statically. This method is currently used by the .NET SDK.
        /// </summary>
        /// <param name="serviceId"> Service id of the service being called </param>
        /// <param name="serviceSdkVersion"> Version of the service </param>
        /// <returns> User agent header string </returns>
        public static string BuildUserAgentString(string serviceId, string serviceSdkVersion)
        {
            var sb = new StringBuilder();
            sb.Append(_userAgentBaseName);
            if (!string.IsNullOrEmpty(_overrideVersionNumber))
            {
                sb.AppendFormat("/{0}", _overrideVersionNumber);
            }
            else if(!string.IsNullOrEmpty(serviceSdkVersion))
            {
                sb.AppendFormat("/{0}", serviceSdkVersion);
            }

            sb.AppendFormat(" {0}", USER_AGENT_VERSION);

            var environmentInfo = ServiceFactory.Instance.GetService<IEnvironmentInfo>();
            sb.AppendFormat(" os/{0}", environmentInfo.PlatformUserAgent);
            sb.AppendFormat(" lang/{0}", environmentInfo.FrameworkUserAgent);

            var execEnv = GetExecutionEnvironmentUserAgentString();
            if (!string.IsNullOrEmpty(execEnv))
            {
                sb.AppendFormat(" {0}", execEnv);
            }

            sb.AppendFormat(" md/aws-sdk-dotnet-core#{0}", CoreVersionNumber);

            var internalUA = GetInternalUserAgentString();
            if(!string.IsNullOrEmpty(internalUA))
            {
                sb.AppendFormat(" {0}", internalUA);
            }

            if(!string.IsNullOrEmpty(serviceId))
            {
                sb.AppendFormat(" api/{0}", serviceId);
                if(!string.IsNullOrEmpty(serviceSdkVersion))
                {
                    sb.Append("#");
                    sb.Append(serviceSdkVersion);
                }
            }

            if (!string.IsNullOrEmpty(_customData))
            {
                sb.AppendFormat(" {0}", _customData);
            }

            if (IsRunningNativeAot())
            {
                sb.Append(" ft/aot");
            }

            return sb.ToString();
        }

        #endregion

        public static void ApplyValuesV2<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>(T target, IDictionary<string, object> propertyValues)
        {
            if (propertyValues == null || propertyValues.Count == 0)
                return;
            var targetType = typeof(T);
            foreach (var kvp in propertyValues)
            {
                var property = targetType.GetProperty(kvp.Key);
                if (property == null)
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Unable to find property {0} on type {1}.", kvp.Key, targetType.FullName));

                try
                {
                    var propertyTypeInfo = property.PropertyType;
                    if (propertyTypeInfo.IsEnum)
                    {
                        var enumValue = Enum.Parse(propertyTypeInfo, kvp.Value.ToString(), true);
                        property.SetValue(target, enumValue, null);
                    }
                    else
                    {
                        property.SetValue(target, kvp.Value, null);
                    }
                }
                catch (Exception e)
                {
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Unable to set property {0} on type {1}: {2}", kvp.Key, targetType.FullName, e.Message));
                }
            }
        }

        // Depending on how System.Types are loaded they are not guaranteed to be compare as equal even when they
        // are the same type. In particular an interface loaded from a Type.GetInterfaces() call will not compare
        // equal to the same interface loaded via typeof(<interface-name>).
        //
        // This method was needed a result of the removal of SDK's TypeInfo wrapper done as part of the trimmable work.
        public static bool AreTypesEqual(Type type1, Type type2)
        {
            if (type1.Assembly != type2.Assembly)
                return false;
            if (type1.Namespace != type2.Namespace)
                return false;
            if (type1.Name != type2.Name)
                return false;

            return true;
        }

        public static void AddToDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Dictionary already contains item with key {0}", key));
            dictionary[key] = value;
        }

        public static void FillDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator, Dictionary<TKey, TValue> targetDictionary)
        {
            foreach (var item in items)
            {
                var key = keyGenerator(item);
                var value = valueGenerator(item);
                AddToDictionary(targetDictionary, key, value);
            }
        }

        public static Dictionary<TKey, TValue> ToDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator)
        {
            return ToDictionary<T, TKey, TValue>(items, keyGenerator, valueGenerator, comparer: null);
        }
        public static Dictionary<TKey, TValue> ToDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator, IEqualityComparer<TKey> comparer)
        {
            Dictionary<TKey, TValue> dictionary;
            if (comparer == null)
                dictionary = new Dictionary<TKey, TValue>();
            else
                dictionary = new Dictionary<TKey, TValue>(comparer);

            FillDictionary(items, keyGenerator, valueGenerator, dictionary);

            return dictionary;
        }

        public static bool TryFindByValue<TKey, TValue>(
            IDictionary<TKey, TValue> dictionary, TValue value, IEqualityComparer<TValue> valueComparer,
            out TKey key)
        {
            if (dictionary != null)
            {
                foreach (var kvp in dictionary)
                {
                    var candidateValue = kvp.Value;
                    if (valueComparer.Equals(value, candidateValue))
                    {
                        key = kvp.Key;
                        return true;
                    }
                }
            }

            key = default(TKey);
            return false;
        }

        internal static string EXECUTION_ENVIRONMENT_ENVVAR = "AWS_EXECUTION_ENV";
        internal static string GetExecutionEnvironment()
        {
            return Environment.GetEnvironmentVariable(EXECUTION_ENVIRONMENT_ENVVAR);
        }

        internal static string INTERNAL_ENVIRONMENT_ENVVAR = "AWS_INTERNAL_ENV";
        internal static string GetInternalEnvironment()
        {
            return Environment.GetEnvironmentVariable(INTERNAL_ENVIRONMENT_ENVVAR);
        }

        private static string GetExecutionEnvironmentUserAgentString()
        {
            string userAgentString = "";
            
            string executionEnvValue = GetExecutionEnvironment();
            if (!string.IsNullOrEmpty(executionEnvValue))
            {
                userAgentString = string.Format(CultureInfo.InvariantCulture, "exec-env/{0}", executionEnvValue);
            }

            return userAgentString;
        }

        private static string GetInternalUserAgentString()
        {
            string userAgentString = "";

            string executionEnvValue = GetInternalEnvironment();
            if (!string.IsNullOrEmpty(executionEnvValue))
            {
                userAgentString = string.Format(CultureInfo.InvariantCulture, "{0}", executionEnvValue);
            }

            return userAgentString;
        }

        /// <summary>
        /// Tests if the filePath is rooted with the directoryPath when resolved. The filePath and
        /// directoryPath do not need to exist to call this method.
        /// </summary>
        /// <param name="filePath">The filePath to test against the directoryPath.</param>
        /// <param name="directoryPath">The directoryPath to use as root in the test.</param>
        /// <returns>true if directoryPath is root of filePath else false</returns>
        public static bool IsFilePathRootedWithDirectoryPath(string filePath, string directoryPath)
        {
            //Construct a local directory path that always ends with the directory separator char. This
            //ensures our directory starts with test doesn't allow files that start with the directory
            //to be popped off the path to fake out the test: 
            //LocalDirectory = a\b\c
            //FilePath = a\b\c\..\ctest.txt            

            var dirTestPath = directoryPath;
            if (!dirTestPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                dirTestPath += Path.DirectorySeparatorChar;
            }

            var dirInfo = new DirectoryInfo(dirTestPath);
            var fileInfo = new FileInfo(filePath);

            //Test if the target file is a child of directoryPath
            return fileInfo.FullName.StartsWith(dirInfo.FullName);
        }

        /// <summary>
        /// Returns true if the SDK is being run in an NativeAOT environment.
        /// </summary>
        /// <returns></returns>
        public static bool IsRunningNativeAot()
        {
#if NET8_0_OR_GREATER
            // If dynamic code is not supported we are most likely running in an AOT environment. 
            return !RuntimeFeature.IsDynamicCodeSupported;
#else
            return false;
#endif
        }

        //Since .net 35 doesn't have Zip functionality, this is a custom implementation that does the same thing as LINQ's zip method.
        internal static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
        {
            using (var enumerator1 = first.GetEnumerator())
            using (var enumerator2 = second.GetEnumerator())
            {
                while (enumerator1.MoveNext() && enumerator2.MoveNext())
                {
                    yield return resultSelector(enumerator1.Current, enumerator2.Current);
                }
            }
        }

        #region IsSet methods

        /*
            Set
              Collection
                True -> set to empty AlwaysSend*
                False -> set to empty collection type
              Value type
                True and field has no value -> set to default(T)
                False -> set to null

            Get
              Collection
                Field is AlwaysSend* OR has items -> True
                Otherwise -> False
              Value type
                Field is any value -> True
                Null -> False
         */

        public static void SetIsSet<T>(bool isSet, ref Nullable<T> field)
            where T : struct
        {
            if (isSet)
            {
                if (!field.HasValue)
                {
                    field = default(T);
                }
            }
            else
            {
                field = null;
            }
        }
        public static void SetIsSet<T>(bool isSet, ref List<T> field)
        {
            if (isSet)
                field = new AlwaysSendList<T>(field);
            else
                field = AWSConfigs.InitializeCollections ? new List<T>() : null;
        }
        public static void SetIsSet<TKey, TValue>(bool isSet, ref Dictionary<TKey, TValue> field)
        {
            if (isSet)
                field = new AlwaysSendDictionary<TKey, TValue>(field);
            else
                field = AWSConfigs.InitializeCollections ? new Dictionary<TKey, TValue>() : null;
        }

        public static bool GetIsSet<T>(Nullable<T> field)
            where T : struct
        {
            return (field.HasValue);
        }
        public static bool GetIsSet<T>(List<T> field)
        {
            if (field == null)
                return false;

            if (field.Count > 0 || !AWSConfigs.InitializeCollections)
                return true;

            var sl = field as AlwaysSendList<T>;
            if (sl != null)
                return true;

            return false;
        }
        public static bool GetIsSet<TKey, TVvalue>(Dictionary<TKey, TVvalue> field)
        {
            if (field == null)
                return false;

            if (field.Count > 0 || !AWSConfigs.InitializeCollections)
                return true;

            var sd = field as AlwaysSendDictionary<TKey, TVvalue>;
            if (sd != null)
                return true;

            return false;
        }

        #endregion
    }
}
