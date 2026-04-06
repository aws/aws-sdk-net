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
    }
}
