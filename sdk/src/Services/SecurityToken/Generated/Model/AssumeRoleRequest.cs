/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the AssumeRole operation.
    /// Returns a set of temporary security credentials (consisting of an access key ID, a
    /// secret access key, and a security token) that you can use to access AWS resources
    /// that you might not normally have access to. Typically, you use <code>AssumeRole</code>
    /// for cross-account access or federation. For a comparison of <code>AssumeRole</code>
    /// with the other APIs that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
    /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
    /// 
    ///  
    /// <para>
    ///  <b>Important:</b> You cannot call <code>AssumeRole</code> by using AWS root account
    /// credentials; access is denied. You must use credentials for an IAM user or an IAM
    /// role to call <code>AssumeRole</code>. 
    /// </para>
    ///  
    /// <para>
    /// For cross-account access, imagine that you own multiple accounts and need to access
    /// resources in each account. You could create long-term credentials in each account
    /// to access those resources. However, managing all those credentials and remembering
    /// which one can access which account can be time consuming. Instead, you can create
    /// one set of long-term credentials in one account and then use temporary security credentials
    /// to access all the other accounts by assuming roles in those accounts. For more information
    /// about roles, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">IAM
    /// Roles (Delegation and Federation)</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// For federation, you can, for example, grant single sign-on access to the AWS Management
    /// Console. If you already have an identity and authentication system in your corporate
    /// network, you don't have to recreate user identities in AWS in order to grant those
    /// user identities access to AWS. Instead, after a user has been authenticated, you call
    /// <code>AssumeRole</code> (and specify the role with the appropriate permissions) to
    /// get temporary security credentials for that user. With those temporary security credentials,
    /// you construct a sign-in URL that users can use to access the console. For more information,
    /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html#sts-introduction">Common
    /// Scenarios for Temporary Credentials</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// By default, the temporary security credentials created by <code>AssumeRole</code>
    /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
    /// parameter to specify the duration of your session. You can provide a value from 900
    /// seconds (15 minutes) up to the maximum session duration setting for the role. This
    /// setting can have a value from 1 hour to 12 hours. To learn how to view the maximum
    /// value for your role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
    /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
    /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
    /// API operations or the <code>assume-role*</code> CLI operations but does not apply
    /// when you use those operations to create a console URL. For more information, see <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using IAM
    /// Roles</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The temporary security credentials created by <code>AssumeRole</code> can be used
    /// to make API calls to any AWS service with the following exception: you cannot call
    /// the STS service's <code>GetFederationToken</code> or <code>GetSessionToken</code>
    /// APIs.
    /// </para>
    ///  
    /// <para>
    /// Optionally, you can pass an IAM access policy to this operation. If you choose not
    /// to pass a policy, the temporary security credentials that are returned by the operation
    /// have the permissions that are defined in the access policy of the role that is being
    /// assumed. If you pass a policy to this operation, the temporary security credentials
    /// that are returned by the operation have the permissions that are allowed by both the
    /// access policy of the role that is being assumed, <i> <b>and</b> </i> the policy that
    /// you pass. This gives you a way to further restrict the permissions for the resulting
    /// temporary security credentials. You cannot use the passed policy to grant permissions
    /// that are in excess of those allowed by the access policy of the role that is being
    /// assumed. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_assumerole.html">Permissions
    /// for AssumeRole, AssumeRoleWithSAML, and AssumeRoleWithWebIdentity</a> in the <i>IAM
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To assume a role, your AWS account must be trusted by the role. The trust relationship
    /// is defined in the role's trust policy when the role is created. That trust policy
    /// states which accounts are allowed to delegate access to this account's role. 
    /// </para>
    ///  
    /// <para>
    /// The user who wants to access the role must also have permissions delegated from the
    /// role's administrator. If the user is in a different account than the role, then the
    /// user's administrator must attach a policy that allows the user to call AssumeRole
    /// on the ARN of the role in the other account. If the user is in the same account as
    /// the role, then you can either attach a policy to the user (identical to the previous
    /// different account user), or you can add the user as a principal directly in the role's
    /// trust policy. In this case, the trust policy acts as the only resource-based policy
    /// in IAM, and users in the same account as the role do not need explicit permission
    /// to assume the role. For more information about trust policies and resource-based policies,
    /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
    /// Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Using MFA with AssumeRole</b> 
    /// </para>
    ///  
    /// <para>
    /// You can optionally include multi-factor authentication (MFA) information when you
    /// call <code>AssumeRole</code>. This is useful for cross-account scenarios in which
    /// you want to make sure that the user who is assuming the role has been authenticated
    /// using an AWS MFA device. In that scenario, the trust policy of the role being assumed
    /// includes a condition that tests for MFA authentication; if the caller does not include
    /// valid MFA information, the request to assume the role is denied. The condition in
    /// a trust policy that tests for MFA authentication might look like the following example.
    /// </para>
    ///  
    /// <para>
    ///  <code>"Condition": {"Bool": {"aws:MultiFactorAuthPresent": true}}</code> 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/MFAProtectedAPI.html">Configuring
    /// MFA-Protected API Access</a> in the <i>IAM User Guide</i> guide.
    /// </para>
    ///  
    /// <para>
    /// To use MFA with <code>AssumeRole</code>, you pass values for the <code>SerialNumber</code>
    /// and <code>TokenCode</code> parameters. The <code>SerialNumber</code> value identifies
    /// the user's hardware or virtual MFA device. The <code>TokenCode</code> is the time-based
    /// one-time password (TOTP) that the MFA devices produces. 
    /// </para>
    /// </summary>
    public partial class AssumeRoleRequest : AmazonSecurityTokenServiceRequest
    {
        private int? _durationSeconds;
        private string _externalId;
        private string _policy;
        private string _roleArn;
        private string _roleSessionName;
        private string _serialNumber;
        private string _tokenCode;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, of the role session. The value can range from 900 seconds
        /// (15 minutes) up to the maximum session duration setting for the role. This setting
        /// can have a value from 1 hour to 12 hours. If you specify a value higher than this
        /// setting, the operation fails. For example, if you specify a session duration of 12
        /// hours, but your administrator set the maximum session duration to 6 hours, your operation
        /// fails. To learn how to view the maximum value for your role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, the value is set to 3600 seconds. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>DurationSeconds</code> parameter is separate from the duration of a console
        /// session that you might request using the returned credentials. The request to the
        /// federation endpoint for a console sign-in token takes a <code>SessionDuration</code>
        /// parameter that specifies the maximum length of the console session. For more information,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_enable-console-custom-url.html">Creating
        /// a URL that Enables Federated Users to Access the AWS Management Console</a> in the
        /// <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public int DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// A unique identifier that is used by third parties when assuming roles in their customers'
        /// accounts. For each role that the third party can assume, they should instruct their
        /// customers to ensure the role's trust policy checks for the external ID that the third
        /// party generated. Each time the third party assumes the role, they should pass the
        /// customer's external ID. The external ID is useful in order to help third parties bind
        /// a role to the customer who created it. For more information about the external ID,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user_externalid.html">How
        /// to Use an External ID When Granting Access to Your AWS Resources to a Third Party</a>
        /// in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validated this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@:/-
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// An IAM policy in JSON format.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If you pass a policy, the temporary security credentials
        /// that are returned by the operation have the permissions that are allowed by both (the
        /// intersection of) the access policy of the role that is being assumed, <i>and</i> the
        /// policy that you pass. This gives you a way to further restrict the permissions for
        /// the resulting temporary security credentials. You cannot use the passed policy to
        /// grant permissions that are in excess of those allowed by the access policy of the
        /// role that is being assumed. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_assumerole.html">Permissions
        /// for AssumeRole, AssumeRoleWithSAML, and AssumeRoleWithWebIdentity</a> in the <i>IAM
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The format for this parameter, as described by its regex pattern, is a string of characters
        /// up to 2048 characters in length. The characters can be any ASCII character from the
        /// space character to the end of the valid character list (\u0020-\u00FF). It can also
        /// include the tab (\u0009), linefeed (\u000A), and carriage return (\u000D) characters.
        /// </para>
        ///  <note> 
        /// <para>
        /// The policy plain text must be 2048 bytes or shorter. However, an internal conversion
        /// compresses it into a packed binary format with a separate limit. The PackedPolicySize
        /// response element indicates by percentage how close to the upper size limit the policy
        /// is, with 100% equaling the maximum allowed size.
        /// </para>
        ///  </note>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role to assume.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleSessionName. 
        /// <para>
        /// An identifier for the assumed role session.
        /// </para>
        ///  
        /// <para>
        /// Use the role session name to uniquely identify a session when the same role is assumed
        /// by different principals or for different reasons. In cross-account scenarios, the
        /// role session name is visible to, and can be logged by the account that owns the role.
        /// The role session name is also used in the ARN of the assumed role principal. This
        /// means that subsequent cross-account API requests using the temporary security credentials
        /// will expose the role session name to the external account in their CloudTrail logs.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-
        /// </para>
        /// </summary>
        public string RoleSessionName
        {
            get { return this._roleSessionName; }
            set { this._roleSessionName = value; }
        }

        // Check to see if RoleSessionName property is set
        internal bool IsSetRoleSessionName()
        {
            return this._roleSessionName != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The identification number of the MFA device that is associated with the user who is
        /// making the <code>AssumeRole</code> call. Specify this value if the trust policy of
        /// the role being assumed includes a condition that requires MFA authentication. The
        /// value is either the serial number for a hardware device (such as <code>GAHT12345678</code>)
        /// or an Amazon Resource Name (ARN) for a virtual device (such as <code>arn:aws:iam::123456789012:mfa/user</code>).
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property TokenCode. 
        /// <para>
        /// The value provided by the MFA device, if the trust policy of the role being assumed
        /// requires MFA (that is, if the policy includes a condition that tests for MFA). If
        /// the role being assumed requires MFA and if the <code>TokenCode</code> value is missing
        /// or expired, the <code>AssumeRole</code> call returns an "access denied" error.
        /// </para>
        ///  
        /// <para>
        /// The format for this parameter, as described by its regex pattern, is a sequence of
        /// six numeric digits.
        /// </para>
        /// </summary>
        public string TokenCode
        {
            get { return this._tokenCode; }
            set { this._tokenCode = value; }
        }

        // Check to see if TokenCode property is set
        internal bool IsSetTokenCode()
        {
            return this._tokenCode != null;
        }

    }
}