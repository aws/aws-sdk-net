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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// The operation failed because the specified policy is not in the proper format. 
    /// 
    ///  
    /// <para>
    /// The policy is subject to the following restrictions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can attach only one policy with each <code>PutPermissionPolicy</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The policy must include an <code>Effect</code>, <code>Action</code> and <code>Principal</code>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Effect</code> must specify <code>Allow</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>Action</code> in the policy must be <code>waf:UpdateWebACL</code>, <code>waf-regional:UpdateWebACL</code>,
    /// <code>waf:GetRuleGroup</code> and <code>waf-regional:GetRuleGroup</code> . Any extra
    /// or wildcard actions in the policy will be rejected.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The policy cannot include a <code>Resource</code> parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The ARN in the request must be a valid WAF RuleGroup ARN and the RuleGroup must exist
    /// in the same region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The user making the request must be the owner of the RuleGroup.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your policy must be composed using IAM Policy version 2012-10-17.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class WAFInvalidPermissionPolicyException : AmazonWAFException
    {

        /// <summary>
        /// Constructs a new WAFInvalidPermissionPolicyException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public WAFInvalidPermissionPolicyException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of WAFInvalidPermissionPolicyException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public WAFInvalidPermissionPolicyException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of WAFInvalidPermissionPolicyException
        /// </summary>
        /// <param name="innerException"></param>
        public WAFInvalidPermissionPolicyException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of WAFInvalidPermissionPolicyException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public WAFInvalidPermissionPolicyException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of WAFInvalidPermissionPolicyException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public WAFInvalidPermissionPolicyException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the WAFInvalidPermissionPolicyException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected WAFInvalidPermissionPolicyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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