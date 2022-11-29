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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// The request was rejected because of the <code>ConnectionState</code> of the custom
    /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
    /// <a>DescribeCustomKeyStores</a> operation.
    /// 
    ///  
    /// <para>
    /// This exception is thrown under the following conditions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
    /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
    /// This operation is valid for all other <code>ConnectionState</code> values. To reconnect
    /// a custom key store in a <code>FAILED</code> state, disconnect it (<a>DisconnectCustomKeyStore</a>),
    /// then connect it (<code>ConnectCustomKeyStore</code>).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You requested the <a>CreateKey</a> operation in a custom key store that is not connected.
    /// This operations is valid only when the custom key store <code>ConnectionState</code>
    /// is <code>CONNECTED</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You requested the <a>DisconnectCustomKeyStore</a> operation on a custom key store
    /// with a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>DISCONNECTED</code>.
    /// This operation is valid for all other <code>ConnectionState</code> values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
    /// on a custom key store that is not disconnected. This operation is valid only when
    /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You requested the <a>GenerateRandom</a> operation in an CloudHSM key store that is
    /// not connected. This operation is valid only when the CloudHSM key store <code>ConnectionState</code>
    /// is <code>CONNECTED</code>. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class CustomKeyStoreInvalidStateException : AmazonKeyManagementServiceException
    {

        /// <summary>
        /// Constructs a new CustomKeyStoreInvalidStateException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public CustomKeyStoreInvalidStateException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of CustomKeyStoreInvalidStateException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CustomKeyStoreInvalidStateException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of CustomKeyStoreInvalidStateException
        /// </summary>
        /// <param name="innerException"></param>
        public CustomKeyStoreInvalidStateException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of CustomKeyStoreInvalidStateException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public CustomKeyStoreInvalidStateException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of CustomKeyStoreInvalidStateException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public CustomKeyStoreInvalidStateException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the CustomKeyStoreInvalidStateException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected CustomKeyStoreInvalidStateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
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
        }
#endif

    }
}