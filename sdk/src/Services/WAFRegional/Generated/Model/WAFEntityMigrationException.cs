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

/*
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// The operation failed due to a problem with the migration. The failure cause is provided
    /// in the exception, in the <code>MigrationErrorType</code>: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>ENTITY_NOT_SUPPORTED</code> - The web ACL has an unsupported entity but the
    /// <code>IgnoreUnsupportedType</code> is not set to true.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ENTITY_NOT_FOUND</code> - The web ACL doesn't exist. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>S3_BUCKET_NO_PERMISSION</code> - You don't have permission to perform the <code>PutObject</code>
    /// action to the specified Amazon S3 bucket.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>S3_BUCKET_NOT_ACCESSIBLE</code> - The bucket policy doesn't allow AWS WAF to
    /// perform the <code>PutObject</code> action in the bucket.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>S3_BUCKET_NOT_FOUND</code> - The S3 bucket doesn't exist. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>S3_BUCKET_INVALID_REGION</code> - The S3 bucket is not in the same Region as
    /// the web ACL.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>S3_INTERNAL_ERROR</code> - AWS WAF failed to create the template in the S3
    /// bucket for another reason.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class WAFEntityMigrationException : AmazonWAFRegionalException
    {
        private string _migrationErrorReason;
        private MigrationErrorType _migrationErrorType;

        /// <summary>
        /// Constructs a new WAFEntityMigrationException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public WAFEntityMigrationException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of WAFEntityMigrationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public WAFEntityMigrationException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of WAFEntityMigrationException
        /// </summary>
        /// <param name="innerException"></param>
        public WAFEntityMigrationException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of WAFEntityMigrationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public WAFEntityMigrationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of WAFEntityMigrationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public WAFEntityMigrationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the WAFEntityMigrationException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected WAFEntityMigrationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.MigrationErrorReason = (string)info.GetValue("MigrationErrorReason", typeof(string));
            this.MigrationErrorType = (MigrationErrorType)info.GetValue("MigrationErrorType", typeof(MigrationErrorType));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
#if BCL35
        [System.Security.Permissions.SecurityPermission(
            System.Security.Permissions.SecurityAction.LinkDemand,
            Flags = System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
#endif
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("MigrationErrorReason", this.MigrationErrorReason);
            info.AddValue("MigrationErrorType", this.MigrationErrorType);
        }
#endif

        /// <summary>
        /// Gets and sets the property MigrationErrorReason.
        /// </summary>
        public string MigrationErrorReason
        {
            get { return this._migrationErrorReason; }
            set { this._migrationErrorReason = value; }
        }

        // Check to see if MigrationErrorReason property is set
        internal bool IsSetMigrationErrorReason()
        {
            return this._migrationErrorReason != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationErrorType.
        /// </summary>
        public MigrationErrorType MigrationErrorType
        {
            get { return this._migrationErrorType; }
            set { this._migrationErrorType = value; }
        }

        // Check to see if MigrationErrorType property is set
        internal bool IsSetMigrationErrorType()
        {
            return this._migrationErrorType != null;
        }

    }
}