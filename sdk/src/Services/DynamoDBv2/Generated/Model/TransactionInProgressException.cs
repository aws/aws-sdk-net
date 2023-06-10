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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// The transaction with the given request token is already in progress.
    /// 
    ///  
    /// <para>
    ///  Recommended Settings 
    /// </para>
    ///  <note> 
    /// <para>
    ///  This is a general recommendation for handling the <code>TransactionInProgressException</code>.
    /// These settings help ensure that the client retries will trigger completion of the
    /// ongoing <code>TransactWriteItems</code> request. 
    /// </para>
    ///  </note> <ul> <li> 
    /// <para>
    ///  Set <code>clientExecutionTimeout</code> to a value that allows at least one retry
    /// to be processed after 5 seconds have elapsed since the first attempt for the <code>TransactWriteItems</code>
    /// operation. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Set <code>socketTimeout</code> to a value a little lower than the <code>requestTimeout</code>
    /// setting. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>requestTimeout</code> should be set based on the time taken for the individual
    /// retries of a single HTTP request for your use case, but setting it to 1 second or
    /// higher should work well to reduce chances of retries and <code>TransactionInProgressException</code>
    /// errors. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Use exponential backoff when retrying and tune backoff if needed. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  Assuming <a href="https://github.com/aws/aws-sdk-java/blob/fd409dee8ae23fb8953e0bb4dbde65536a7e0514/aws-java-sdk-core/src/main/java/com/amazonaws/retry/PredefinedRetryPolicies.java#L97">default
    /// retry policy</a>, example timeout settings based on the guidelines above are as follows:
    /// 
    /// </para>
    ///  
    /// <para>
    /// Example timeline:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// 0-1000 first attempt
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1000-1500 first sleep/delay (default retry policy uses 500 ms as base delay for 4xx
    /// errors)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1500-2500 second attempt
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 2500-3500 second sleep/delay (500 * 2, exponential backoff)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 3500-4500 third attempt
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 4500-6500 third sleep/delay (500 * 2^2)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 6500-7500 fourth attempt (this can trigger inline recovery since 5 seconds have elapsed
    /// since the first attempt reached TC)
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class TransactionInProgressException : AmazonDynamoDBException
    {

        /// <summary>
        /// Constructs a new TransactionInProgressException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public TransactionInProgressException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of TransactionInProgressException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public TransactionInProgressException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of TransactionInProgressException
        /// </summary>
        /// <param name="innerException"></param>
        public TransactionInProgressException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of TransactionInProgressException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public TransactionInProgressException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of TransactionInProgressException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public TransactionInProgressException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the TransactionInProgressException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected TransactionInProgressException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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