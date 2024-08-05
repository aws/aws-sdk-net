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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// The request was rejected for one of the following reasons: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The encryption algorithm or signing algorithm specified for the operation is incompatible
    /// with the type of key material in the KMS key <c>(KeySpec</c>).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
    /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
    /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
    /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
    /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
    /// of a KMS key, use the <a>DescribeKey</a> operation.
    /// </para>
    ///  
    /// <para>
    /// To find the encryption or signing algorithms supported for a particular KMS key, use
    /// the <a>DescribeKey</a> operation.
    /// </para>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class InvalidKeyUsageException : AmazonKeyManagementServiceException
    {

        /// <summary>
        /// Constructs a new InvalidKeyUsageException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InvalidKeyUsageException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of InvalidKeyUsageException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public InvalidKeyUsageException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of InvalidKeyUsageException
        /// </summary>
        /// <param name="innerException"></param>
        public InvalidKeyUsageException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of InvalidKeyUsageException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidKeyUsageException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of InvalidKeyUsageException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidKeyUsageException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InvalidKeyUsageException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InvalidKeyUsageException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
#endif

    }
}