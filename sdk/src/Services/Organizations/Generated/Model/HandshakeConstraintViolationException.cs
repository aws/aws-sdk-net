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
    /// The requested operation would violate the constraint identified in the reason code.
    /// 
    ///  <note> 
    /// <para>
    /// Some of the reasons in the following list might not be applicable to this specific
    /// API or operation:
    /// </para>
    ///  </note> <ul> <li> 
    /// <para>
    /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
    /// accounts in an organization. Note that deleted and closed accounts still count toward
    /// your limit.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you get this exception immediately after creating the organization, wait one hour
    /// and try again. If after an hour it continues to fail with this error, contact <a href="https://console.aws.amazon.com/support/home#/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </important> </li> <li> 
    /// <para>
    /// ALREADY_IN_AN_ORGANIZATION: The handshake request is invalid because the invited account
    /// is already a member of an organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
    /// you can send in one day.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES: You can't issue new invitations to join
    /// an organization while it's in the process of enabling all features. You can resume
    /// inviting accounts after you finalize the process when all accounts have agreed to
    /// the change.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ORGANIZATION_ALREADY_HAS_ALL_FEATURES: The handshake request is invalid because the
    /// organization has already enabled all features.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ORGANIZATION_IS_ALREADY_PENDING_ALL_FEATURES_MIGRATION: The handshake request is invalid
    /// because the organization has already started the process to enable all features.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ORGANIZATION_FROM_DIFFERENT_SELLER_OF_RECORD: The request failed because the account
    /// is from a different marketplace than the accounts in the organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ORGANIZATION_MEMBERSHIP_CHANGE_RATE_LIMIT_EXCEEDED: You attempted to change the membership
    /// of an account too quickly after its previous change.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// PAYMENT_INSTRUMENT_REQUIRED: You can't complete the operation with an account that
    /// doesn't have a payment instrument, such as a credit card, associated with it.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class HandshakeConstraintViolationException : AmazonOrganizationsException
    {
        private HandshakeConstraintViolationExceptionReason _reason;

        /// <summary>
        /// Constructs a new HandshakeConstraintViolationException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public HandshakeConstraintViolationException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of HandshakeConstraintViolationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public HandshakeConstraintViolationException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of HandshakeConstraintViolationException
        /// </summary>
        /// <param name="innerException"></param>
        public HandshakeConstraintViolationException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of HandshakeConstraintViolationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public HandshakeConstraintViolationException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of HandshakeConstraintViolationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public HandshakeConstraintViolationException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the HandshakeConstraintViolationException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected HandshakeConstraintViolationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Reason = (HandshakeConstraintViolationExceptionReason)info.GetValue("Reason", typeof(HandshakeConstraintViolationExceptionReason));
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
        public HandshakeConstraintViolationExceptionReason Reason
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