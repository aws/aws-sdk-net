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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Performing this operation violates a minimum or maximum value limit. For example,
    /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
    /// or creating too many accounts to the organization, or attaching too many policies
    /// to an account, OU, or root. This exception includes a reason that contains additional
    /// information about the violated limit:
    /// 
    ///  <note> 
    /// <para>
    /// Some of the reasons in the following list might not be applicable to this specific
    /// API or operation.
    /// </para>
    ///  </note> <ul> <li> 
    /// <para>
    /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
    /// from the organization. You can't remove the management account. Instead, after you
    /// remove all member accounts, delete the organization itself.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
    /// from the organization that doesn't yet have enough information to exist as a standalone
    /// account. This account requires you to first complete phone verification. Follow the
    /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
    /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
    /// that you can create in one day.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ACCOUNT_CREATION_NOT_COMPLETE: Your account setup isn't complete or your account isn't
    /// fully active. You must complete the account setup before you create an organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
    /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
    /// Web Services Support</a> to request an increase in your limit. 
    /// </para>
    ///  
    /// <para>
    /// Or the number of invitations that you tried to send would cause you to exceed the
    /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
    /// Services Support to request an increase in the number of accounts.
    /// </para>
    ///  <note> 
    /// <para>
    /// Deleted and closed accounts still count toward your limit.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// If you get this exception when running a command immediately after creating the organization,
    /// wait one hour and try again. After an hour, if the command continues to fail with
    /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
    /// Services Support</a>.
    /// </para>
    ///  </important> </li> <li> 
    /// <para>
    /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
    /// account of the organization as a delegated administrator for an Amazon Web Services
    /// service integrated with Organizations. You can designate only a member account as
    /// a delegated administrator.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
    /// close the management account for the organization, you must first either remove or
    /// close all member accounts in the organization. Follow standard account closure process
    /// using root credentials.​ 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
    /// that is registered as a delegated administrator for a service integrated with your
    /// organization. To complete this operation, you must first deregister this account as
    /// a delegated administrator. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
    /// days. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
    /// that you can close at a time. ​ 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
    /// in the specified region, you must enable all features mode.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
    /// Web Services account as a delegated administrator for an Amazon Web Services service
    /// that already has a delegated administrator. To complete this operation, you must first
    /// deregister any existing delegated administrators for this service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
    /// period of time. You must resubmit the request and generate a new verfication code.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
    /// you can send in one day.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
    /// method is associated with the account. Amazon Web Services does not support cards
    /// issued by financial institutions in Russia or Belarus. For more information, see <a
    /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
    /// your Amazon Web Services payments</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
    /// you first must migrate the organization's management account to the marketplace that
    /// corresponds to the management account's address. For example, accounts with India
    /// addresses must be associated with the AISPL marketplace. All accounts in an organization
    /// must be associated with the same marketplace.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
    /// Regions in China. To create an organization, the master must have a valid business
    /// license. For more information, contact customer support.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
    /// a valid contact address and phone number for the management account. Then try the
    /// operation again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
    /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
    /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
    /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
    /// account, you first must associate a valid payment instrument, such as a credit card,
    /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
    /// leave an organization when all required account information has not yet been provided</a>
    /// in the <i>Organizations User Guide.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
    /// more delegated administrators than allowed for the service principal. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
    /// of a certain type that can be attached to an entity at one time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
    /// account, you first must associate a valid payment instrument, such as a credit card,
    /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
    /// leave an organization when all required account information has not yet been provided</a>
    /// in the <i>Organizations User Guide.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
    /// entity that would cause the entity to have fewer than the minimum number of policies
    /// of a certain type required.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
    /// requires the organization to be configured to support all features. An organization
    /// that supports only consolidated billing features can't perform this operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
    /// deep.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
    /// in an organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
    /// the maximum size.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
    /// you can have in an organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
    /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
    /// are not compliant with the tag policy requirements for this account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
    /// period before you can remove it from the organization. If you get an error that indicates
    /// that a wait period is required, try again in a few days.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class ConstraintViolationException : AmazonOrganizationsException
    {
        private ConstraintViolationExceptionReason _reason;

        /// <summary>
        /// Constructs a new ConstraintViolationException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ConstraintViolationException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of ConstraintViolationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ConstraintViolationException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of ConstraintViolationException
        /// </summary>
        /// <param name="innerException"></param>
        public ConstraintViolationException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of ConstraintViolationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ConstraintViolationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ConstraintViolationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ConstraintViolationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ConstraintViolationException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ConstraintViolationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Reason = (ConstraintViolationExceptionReason)info.GetValue("Reason", typeof(ConstraintViolationExceptionReason));
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
            info.AddValue("Reason", this.Reason);
        }
#endif

        /// <summary>
        /// Gets and sets the property Reason.
        /// </summary>
        public ConstraintViolationExceptionReason Reason
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