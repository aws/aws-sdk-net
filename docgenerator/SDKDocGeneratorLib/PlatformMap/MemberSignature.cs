using System;

namespace SDKDocGenerator.PlatformMap
{
    /// <summary>
    /// Generates stable, platform-independent signatures for SDK members.
    /// These signatures are used as keys in the platform availability map.
    ///
    /// Signature format follows NDoc convention:
    /// - Types: T:FullyQualifiedName
    /// - Methods: M:FullyQualifiedName.MethodName(ParamType1,ParamType2)
    /// - Properties: P:FullyQualifiedName.PropertyName
    /// - Fields: F:FullyQualifiedName.FieldName
    /// - Events: E:FullyQualifiedName.EventName
    /// - Constructors: M:FullyQualifiedName.#ctor(ParamType1,ParamType2)
    ///
    /// All signature generation delegates to NDocUtilities to ensure consistency
    /// with XML documentation lookup signatures.
    /// </summary>
    public static class MemberSignature
    {
        #region Type Signatures

        /// <summary>
        /// Generates signature for a type.
        /// Format: T:Amazon.S3.Model.GetObjectRequest
        /// </summary>
        public static string ForType(TypeWrapper type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            // Delegate to NDocUtilities for consistent signature generation
            return NDocUtilities.DetermineTypeSignature(type);
        }

        #endregion

        #region Method Signatures

        /// <summary>
        /// Generates signature for a method.
        /// Format: M:Amazon.S3.AmazonS3Client.GetObject(Amazon.S3.Model.GetObjectRequest)
        ///
        /// Handles:
        /// - Generic methods: M:Type.Method``1(System.String,``0)
        /// - Generic type parameters: M:Type`1.Method(`0)
        /// - Out parameters: M:Type.Method(System.Int32@)
        /// - Overloads: Distinguished by parameter types
        /// </summary>
        public static string ForMethod(MethodInfoWrapper method)
        {
            if (method == null)
                throw new ArgumentNullException(nameof(method));

            // Delegate to NDocUtilities for consistent signature generation
            return NDocUtilities.DetermineNDocNameLookupSignature(method);
        }

        #endregion

        #region Property Signatures

        /// <summary>
        /// Generates signature for a property.
        /// Format: P:Amazon.Runtime.ClientConfig.ReadWriteTimeout
        ///
        /// Note: Uses DeclaringType, not the current type, so inherited properties
        /// (like ReadWriteTimeout on BedrockRuntimeConfig) map to their declaration
        /// (ClientConfig.ReadWriteTimeout).
        /// </summary>
        public static string ForProperty(PropertyInfoWrapper property)
        {
            if (property == null)
                throw new ArgumentNullException(nameof(property));

            // Delegate to NDocUtilities for consistent signature generation
            return NDocUtilities.DeterminePropertySignature(property);
        }

        #endregion

        #region Field Signatures

        /// <summary>
        /// Generates signature for a field.
        /// Format: F:Amazon.S3.Model.Region.USEast1
        /// </summary>
        public static string ForField(FieldInfoWrapper field)
        {
            if (field == null)
                throw new ArgumentNullException(nameof(field));

            // Delegate to NDocUtilities for consistent signature generation
            return NDocUtilities.DetermineFieldSignature(field);
        }

        #endregion

        #region Event Signatures

        /// <summary>
        /// Generates signature for an event.
        /// Format: E:Amazon.S3.Transfer.TransferUtility.UploadProgressEvent
        /// </summary>
        public static string ForEvent(EventInfoWrapper eventInfo)
        {
            if (eventInfo == null)
                throw new ArgumentNullException(nameof(eventInfo));

            // Delegate to NDocUtilities for consistent signature generation
            return NDocUtilities.DetermineEventSignature(eventInfo);
        }

        #endregion

        #region Constructor Signatures

        /// <summary>
        /// Generates signature for a constructor.
        /// Format: M:Amazon.S3.AmazonS3Client.#ctor(System.String,System.String)
        /// </summary>
        public static string ForConstructor(ConstructorInfoWrapper constructor)
        {
            if (constructor == null)
                throw new ArgumentNullException(nameof(constructor));

            // Delegate to NDocUtilities for consistent signature generation
            return NDocUtilities.DetermineConstructorSignature(constructor);
        }

        #endregion

        #region Utilities

        /// <summary>
        /// Extracts the member type prefix from a signature.
        /// Returns: "T", "M", "P", "F", or "E"
        /// </summary>
        public static string GetMemberType(string signature)
        {
            if (string.IsNullOrEmpty(signature) || signature.Length < 2 || signature[1] != ':')
                throw new ArgumentException("Invalid signature format", nameof(signature));

            return signature.Substring(0, 1);
        }

        /// <summary>
        /// Extracts the fully qualified member name from a signature.
        /// Example: "M:Amazon.S3.Client.GetObject(Request)" → "Amazon.S3.Client.GetObject"
        /// </summary>
        public static string GetMemberName(string signature)
        {
            if (string.IsNullOrEmpty(signature) || signature.Length < 2 || signature[1] != ':')
                throw new ArgumentException("Invalid signature format", nameof(signature));

            var nameStart = 2; // Skip "T:", "M:", etc.
            var nameEnd = signature.IndexOfAny(new[] { '(', '<' }, nameStart);

            return nameEnd == -1
                ? signature.Substring(nameStart)
                : signature.Substring(nameStart, nameEnd - nameStart);
        }

        /// <summary>
        /// Extracts the type portion from a member signature.
        /// Example: "P:Amazon.Runtime.ClientConfig.ReadWriteTimeout" → "Amazon.Runtime.ClientConfig"
        /// </summary>
        public static string GetDeclaringTypeName(string signature)
        {
            var memberName = GetMemberName(signature);
            var lastDot = memberName.LastIndexOf('.');
            return lastDot >= 0 ? memberName.Substring(0, lastDot) : memberName;
        }

        /// <summary>
        /// Extracts just the method/member name from a full signature.
        /// Example: "M:Amazon.S3.Client.GetObject(Request)" → "GetObject"
        /// </summary>
        public static string ExtractMethodName(string signature)
        {
            var fullName = GetMemberName(signature);
            var lastDot = fullName.LastIndexOf('.');
            return lastDot >= 0 ? fullName.Substring(lastDot + 1) : fullName;
        }

        #endregion
    }
}
