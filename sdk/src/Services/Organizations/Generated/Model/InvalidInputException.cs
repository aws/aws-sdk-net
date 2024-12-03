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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// The requested operation failed because you provided invalid values for one or more
    /// of the request parameters. This exception includes a reason that contains additional
    /// information about the violated limit:
    /// 
    ///  <note> 
    /// <para>
    /// Some of the reasons in the following list might not be applicable to this specific
    /// API or operation.
    /// </para>
    ///  </note> <ul> <li> 
    /// <para>
    /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
    /// can't be modified.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INPUT_REQUIRED: You must include a value for all required parameters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
    /// account owner.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_ENUM: You specified an invalid value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
    /// invalid value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_PAGINATION_TOKEN: Get the value for the <c>NextToken</c> parameter from the
    /// response to a previous call of the operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
    /// or email) as a party.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
    /// required pattern.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_PRINCIPAL: You specified an invalid principal element in the policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
    /// with the reserved prefix <c>AWSServiceRoleFor</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
    /// for the organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
    /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
    /// use. System tags don’t count against your tags per resource limit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
    /// allowed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
    /// allowed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
    /// in the same root.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// NON_DETACHABLE_POLICY: You can't detach this Amazon Web Services Managed Policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class InvalidInputException : AmazonOrganizationsException
    {
        private InvalidInputExceptionReason _reason;

        /// <summary>
        /// Constructs a new InvalidInputException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InvalidInputException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of InvalidInputException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public InvalidInputException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of InvalidInputException
        /// </summary>
        /// <param name="innerException"></param>
        public InvalidInputException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of InvalidInputException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidInputException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of InvalidInputException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidInputException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InvalidInputException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InvalidInputException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Reason = (InvalidInputExceptionReason)info.GetValue("Reason", typeof(InvalidInputExceptionReason));
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
            info.AddValue("Reason", this.Reason);
        }
#endif

        /// <summary>
        /// Gets and sets the property Reason.
        /// </summary>
        public InvalidInputExceptionReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}