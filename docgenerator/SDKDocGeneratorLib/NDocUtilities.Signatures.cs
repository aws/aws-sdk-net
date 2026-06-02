using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SDKDocGenerator
{
    public static partial class NDocUtilities
    {
        public static string DetermineNDocNameLookupSignature(MethodInfo info, string docId)
        {
            return DetermineNDocNameLookupSignature(new MethodInfoWrapper(info, docId));
        }

        public static string DetermineNDocNameLookupSignature(MethodInfoWrapper info)
        {
            var type = info.DeclaringType;
            var fullName = type.FullName ?? type.Namespace + "." + type.Name;
            var typeGenericParameters = type.GetGenericArguments();
            var parameters = new StringBuilder();
            foreach (var param in info.GetParameters())
            {
                if (parameters.Length > 0)
                    parameters.Append(",");
                DetermineParameterName(param.ParameterType, parameters, typeGenericParameters);
                if (param.IsOut)
                {
                    parameters.Append("@");
                }
            }

            var genericTag = "";
            if (info.IsGenericMethod)
            {
                genericTag = "``" + info.GetGenericArguments().Length;
            }

            var signature = parameters.Length > 0
                ? string.Format("M:{0}.{1}{2}({3})", fullName, info.Name, genericTag, parameters)
                : string.Format("M:{0}.{1}{2}", fullName, info.Name, genericTag);

            return signature;
        }

        #region NDoc Signature Generation Helpers

        // These methods generate NDoc-style member signatures used for:
        // 1. Documentation lookup (original use case)
        // 2. Platform availability mapping (added 2026 for unified platform map feature)
        //
        // The signature format is standardized across the .NET ecosystem and must not change
        // without considering backwards compatibility with existing documentation XML files.

        /// <summary>
        /// Generates NDoc signature for a type.
        /// Format: T:Amazon.S3.Model.GetObjectRequest
        /// </summary>
        public static string DetermineTypeSignature(TypeWrapper type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));
            return "T:" + type.FullName;
        }

        /// <summary>
        /// Generates NDoc signature for a property.
        /// Format: P:Amazon.Runtime.ClientConfig.ReadWriteTimeout
        /// Note: Uses DeclaringType for inherited properties.
        /// </summary>
        public static string DeterminePropertySignature(PropertyInfoWrapper property)
        {
            if (property == null)
                throw new ArgumentNullException(nameof(property));
            return string.Format("P:{0}.{1}", property.DeclaringType.FullName, property.Name);
        }

        /// <summary>
        /// Generates NDoc signature for a field.
        /// Format: F:Amazon.S3.Model.Region.USEast1
        /// </summary>
        public static string DetermineFieldSignature(FieldInfoWrapper field)
        {
            if (field == null)
                throw new ArgumentNullException(nameof(field));
            return string.Format("F:{0}.{1}", field.DeclaringType.FullName, field.Name);
        }

        /// <summary>
        /// Generates NDoc signature for an event.
        /// Format: E:Amazon.S3.Transfer.TransferUtility.UploadProgressEvent
        /// </summary>
        public static string DetermineEventSignature(EventInfoWrapper eventInfo)
        {
            if (eventInfo == null)
                throw new ArgumentNullException(nameof(eventInfo));
            return string.Format("E:{0}.{1}", eventInfo.DeclaringType.FullName, eventInfo.Name);
        }

        /// <summary>
        /// Generates NDoc signature for a constructor.
        /// Format: M:Amazon.S3.AmazonS3Client.#ctor(System.String,System.String)
        /// </summary>
        public static string DetermineConstructorSignature(ConstructorInfoWrapper constructor)
        {
            if (constructor == null)
                throw new ArgumentNullException(nameof(constructor));

            var type = constructor.DeclaringType;
            var parameters = new StringBuilder();
            var typeGenericParameters = type.GetGenericArguments();
            foreach (var param in constructor.GetParameters())
            {
                if (parameters.Length > 0)
                    parameters.Append(",");
                DetermineParameterName(param.ParameterType, parameters, typeGenericParameters);
                if (param.IsOut)
                {
                    parameters.Append("@");
                }
            }

            var formattedParameters = parameters.Length > 0
                ? string.Format("({0})", parameters)
                : parameters.ToString();

            return string.Format("M:{0}.#ctor{1}", type.FullName, formattedParameters);
        }

        /// <summary>
        /// Helper to determine parameter type name for NDoc signatures.
        /// Handles generic parameters, generic types, arrays, and regular types.
        /// </summary>
        public static void DetermineParameterName(TypeWrapper parameterTypeInfo, StringBuilder parameters, IList<TypeWrapper> typeGenericParameters)
        {
            if (parameterTypeInfo.IsGenericParameter)
            {
                var typeGenericParameterIndex = typeGenericParameters.IndexOf(parameterTypeInfo);
                var isClassGenericParameter = typeGenericParameterIndex >= 0;

                if (isClassGenericParameter)
                    parameters.AppendFormat("`{0}", typeGenericParameterIndex);
                else
                    parameters.AppendFormat("``{0}", 0);
            }
            else if (parameterTypeInfo.IsGenericType)
            {
                parameters
                    .Append(parameterTypeInfo.GenericTypeName)
                    .Append("{");
                IList<TypeWrapper> args = parameterTypeInfo.GenericTypeArguments();

                for (var i = 0; i < args.Count; i++)
                {
                    if (i != 0)
                    {
                        parameters.Append(",");
                    }
                    DetermineParameterName(args[i], parameters, typeGenericParameters);
                }
                parameters.Append("}");
            }
            else if (parameterTypeInfo.IsArray)
            {
                // Handle array parameters
                var elementType = parameterTypeInfo.GetElementType();
                DetermineParameterName(elementType, parameters, typeGenericParameters);
                parameters.Append("[]");
            }
            else
            {
                parameters.Append(parameterTypeInfo.FullName);
            }
        }

        #endregion
    }
}
