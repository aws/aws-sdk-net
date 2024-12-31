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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Indicates one of the following errors:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_PutConfigRule.html">PutConfigRule</a>,
    /// the rule cannot be created because the IAM role assigned to Config lacks permissions
    /// to perform the config:Put* action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_PutConfigRule.html">PutConfigRule</a>,
    /// the Lambda function cannot be invoked. Check the function ARN, and check the function's
    /// permissions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_PutOrganizationConfigRule.html">PutOrganizationConfigRule</a>,
    /// organization Config rule cannot be created because you do not have permissions to
    /// call IAM <c>GetRole</c> action or create a service-linked role.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_PutConformancePack.html">PutConformancePack</a>
    /// and <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_PutOrganizationConformancePack.html">PutOrganizationConformancePack</a>,
    /// a conformance pack cannot be created because you do not have the following permissions:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You do not have permission to call IAM <c>GetRole</c> action or create a service-linked
    /// role.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You do not have permission to read Amazon S3 bucket or call SSM:GetDocument.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// For <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_PutServiceLinkedConfigurationRecorder.html">PutServiceLinkedConfigurationRecorder</a>,
    /// a service-linked configuration recorder cannot be created because you do not have
    /// the following permissions: IAM <c>CreateServiceLinkedRole</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class InsufficientPermissionsException : AmazonConfigServiceException
    {

        /// <summary>
        /// Constructs a new InsufficientPermissionsException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InsufficientPermissionsException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of InsufficientPermissionsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public InsufficientPermissionsException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of InsufficientPermissionsException
        /// </summary>
        /// <param name="innerException"></param>
        public InsufficientPermissionsException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of InsufficientPermissionsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InsufficientPermissionsException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of InsufficientPermissionsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InsufficientPermissionsException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InsufficientPermissionsException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InsufficientPermissionsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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