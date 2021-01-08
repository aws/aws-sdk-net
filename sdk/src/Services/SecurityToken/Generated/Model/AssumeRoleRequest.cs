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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the AssumeRole operation.
    /// Returns a set of temporary security credentials that you can use to access AWS resources
    /// that you might not normally have access to. These temporary credentials consist of
    /// an access key ID, a secret access key, and a security token. Typically, you use <code>AssumeRole</code>
    /// within your account or for cross-account access. For a comparison of <code>AssumeRole</code>
    /// with other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
    /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// You cannot use AWS account root user credentials to call <code>AssumeRole</code>.
    /// You must use credentials for an IAM user or an IAM role to call <code>AssumeRole</code>.
    /// </para>
    ///  </important> 
    /// <para>
    /// For cross-account access, imagine that you own multiple accounts and need to access
    /// resources in each account. You could create long-term credentials in each account
    /// to access those resources. However, managing all those credentials and remembering
    /// which one can access which account can be time consuming. Instead, you can create
    /// one set of long-term credentials in one account. Then use temporary security credentials
    /// to access all the other accounts by assuming roles in those accounts. For more information
    /// about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
    /// Roles</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Session Duration</b> 
    /// </para>
    ///  
    /// <para>
    /// By default, the temporary security credentials created by <code>AssumeRole</code>
    /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
    /// parameter to specify the duration of your session. You can provide a value from 900
    /// seconds (15 minutes) up to the maximum session duration setting for the role. This
    /// setting can have a value from 1 hour to 12 hours. To learn how to view the maximum
    /// value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
    /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
    /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
    /// API operations or the <code>assume-role*</code> CLI commands. However the limit does
    /// not apply when you use those operations to create a console URL. For more information,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
    /// IAM Roles</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// The temporary security credentials created by <code>AssumeRole</code> can be used
    /// to make API calls to any AWS service with the following exception: You cannot call
    /// the AWS STS <code>GetFederationToken</code> or <code>GetSessionToken</code> API operations.
    /// </para>
    ///  
    /// <para>
    /// (Optional) You can pass inline or managed <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">session
    /// policies</a> to this operation. You can pass a single JSON policy document to use
    /// as an inline session policy. You can also specify up to 10 managed policies to use
    /// as managed session policies. The plain text that you use for both inline and managed
    /// session policies can't exceed 2,048 characters. Passing policies to this operation
    /// returns new temporary credentials. The resulting session's permissions are the intersection
    /// of the role's identity-based policy and the session policies. You can use the role's
    /// temporary credentials in subsequent AWS API calls to access resources in the account
    /// that owns the role. You cannot use session policies to grant more permissions than
    /// those allowed by the identity-based policy of the role that is being assumed. For
    /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
    /// Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To assume a role from a different account, your AWS account must be trusted by the
    /// role. The trust relationship is defined in the role's trust policy when the role is
    /// created. That trust policy states which accounts are allowed to delegate that access
    /// to users in the account. 
    /// </para>
    ///  
    /// <para>
    /// A user who wants to access a role in a different account must also have permissions
    /// that are delegated from the user account administrator. The administrator must attach
    /// a policy that allows the user to call <code>AssumeRole</code> for the ARN of the role
    /// in the other account. If the user is in the same account as the role, then you can
    /// do either of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Attach a policy to the user (identical to the previous user in a different account).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Add the user as a principal directly in the role's trust policy.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In this case, the trust policy acts as an IAM resource-based policy. Users in the
    /// same account as the role do not need explicit permission to assume the role. For more
    /// information about trust policies and resource-based policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
    /// Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Tags</b> 
    /// </para>
    ///  
    /// <para>
    /// (Optional) You can pass tag key-value pairs to your session. These tags are called
    /// session tags. For more information about session tags, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
    /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// An administrator must grant you the permissions necessary to pass session tags. The
    /// administrator can also create granular permissions to allow you to pass only specific
    /// session tags. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/tutorial_attribute-based-access-control.html">Tutorial:
    /// Using Tags for Attribute-Based Access Control</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can set the session tags as transitive. Transitive tags persist during role chaining.
    /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html#id_session-tags_role-chaining">Chaining
    /// Roles with Session Tags</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Using MFA with AssumeRole</b> 
    /// </para>
    ///  
    /// <para>
    /// (Optional) You can include multi-factor authentication (MFA) information when you
    /// call <code>AssumeRole</code>. This is useful for cross-account scenarios to ensure
    /// that the user that assumes the role has been authenticated with an AWS MFA device.
    /// In that scenario, the trust policy of the role being assumed includes a condition
    /// that tests for MFA authentication. If the caller does not include valid MFA information,
    /// the request to assume the role is denied. The condition in a trust policy that tests
    /// for MFA authentication might look like the following example.
    /// </para>
    ///  
    /// <para>
    ///  <code>"Condition": {"Bool": {"aws:MultiFactorAuthPresent": true}}</code> 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/MFAProtectedAPI.html">Configuring
    /// MFA-Protected API Access</a> in the <i>IAM User Guide</i> guide.
    /// </para>
    ///  
    /// <para>
    /// To use MFA with <code>AssumeRole</code>, you pass values for the <code>SerialNumber</code>
    /// and <code>TokenCode</code> parameters. The <code>SerialNumber</code> value identifies
    /// the user's hardware or virtual MFA device. The <code>TokenCode</code> is the time-based
    /// one-time password (TOTP) that the MFA device produces. 
    /// </para>
    /// </summary>
    public partial class AssumeRoleRequest : AmazonSecurityTokenServiceRequest
    {
        private int? _durationSeconds;
        private string _externalId;
        private string _policy;
        private List<PolicyDescriptorType> _policyArns = new List<PolicyDescriptorType>();
        private string _roleArn;
        private string _roleSessionName;
        private string _serialNumber;
        private List<Tag> _tags = new List<Tag>();
        private string _tokenCode;
        private List<string> _transitiveTagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, of the role session. The value can range from 900 seconds
        /// (15 minutes) up to the maximum session duration setting for the role. This setting
        /// can have a value from 1 hour to 12 hours. If you specify a value higher than this
        /// setting, the operation fails. For example, if you specify a session duration of 12
        /// hours, but your administrator set the maximum session duration to 6 hours, your operation
        /// fails. To learn how to view the maximum value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, the value is set to <code>3600</code> seconds. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>DurationSeconds</code> parameter is separate from the duration of a console
        /// session that you might request using the returned credentials. The request to the
        /// federation endpoint for a console sign-in token takes a <code>SessionDuration</code>
        /// parameter that specifies the maximum length of the console session. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_enable-console-custom-url.html">Creating
        /// a URL that Enables Federated Users to Access the AWS Management Console</a> in the
        /// <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=900, Max=43200)]
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
        /// A unique identifier that might be required when you assume a role in another account.
        /// If the administrator of the account to which the role belongs provided you with an
        /// external ID, then provide that value in the <code>ExternalId</code> parameter. This
        /// value can be any string, such as a passphrase or account number. A cross-account role
        /// is usually set up to trust everyone in an account. Therefore, the administrator of
        /// the trusting account might send an external ID to the administrator of the trusted
        /// account. That way, only someone with the ID can assume the role, rather than everyone
        /// in the account. For more information about the external ID, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user_externalid.html">How
        /// to Use an External ID When Granting Access to Your AWS Resources to a Third Party</a>
        /// in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@:/-
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=1224)]
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
        /// An IAM policy in JSON format that you want to use as an inline session policy.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. Passing policies to this operation returns new temporary
        /// credentials. The resulting session's permissions are the intersection of the role's
        /// identity-based policy and the session policies. You can use the role's temporary credentials
        /// in subsequent AWS API calls to access resources in the account that owns the role.
        /// You cannot use session policies to grant more permissions than those allowed by the
        /// identity-based policy of the role that is being assumed. For more information, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The plain text that you use for both inline and managed session policies can't exceed
        /// 2,048 characters. The JSON policy characters can be any ASCII character from the space
        /// character to the end of the valid character list (\u0020 through \u00FF). It can also
        /// include the tab (\u0009), linefeed (\u000A), and carriage return (\u000D) characters.
        /// </para>
        ///  <note> 
        /// <para>
        /// An AWS conversion compresses the passed session policies and session tags into a packed
        /// binary format that has a separate limit. Your request can fail for this limit even
        /// if your plain text meets the other requirements. The <code>PackedPolicySize</code>
        /// response element indicates by percentage how close the policies and tags for your
        /// request are to the upper size limit. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property PolicyArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the IAM managed policies that you want to use
        /// as managed session policies. The policies must exist in the same account as the role.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. You can provide up to 10 managed policy ARNs. However,
        /// the plain text that you use for both inline and managed session policies can't exceed
        /// 2,048 characters. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the AWS General Reference.
        /// </para>
        ///  <note> 
        /// <para>
        /// An AWS conversion compresses the passed session policies and session tags into a packed
        /// binary format that has a separate limit. Your request can fail for this limit even
        /// if your plain text meets the other requirements. The <code>PackedPolicySize</code>
        /// response element indicates by percentage how close the policies and tags for your
        /// request are to the upper size limit. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Passing policies to this operation returns new temporary credentials. The resulting
        /// session's permissions are the intersection of the role's identity-based policy and
        /// the session policies. You can use the role's temporary credentials in subsequent AWS
        /// API calls to access resources in the account that owns the role. You cannot use session
        /// policies to grant more permissions than those allowed by the identity-based policy
        /// of the role that is being assumed. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public List<PolicyDescriptorType> PolicyArns
        {
            get { return this._policyArns; }
            set { this._policyArns = value; }
        }

        // Check to see if PolicyArns property is set
        internal bool IsSetPolicyArns()
        {
            return this._policyArns != null && this._policyArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role to assume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// means that subsequent cross-account API requests that use the temporary security credentials
        /// will expose the role session name to the external account in their AWS CloudTrail
        /// logs.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
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
        [AWSProperty(Min=9, Max=256)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of session tags that you want to pass. Each session tag consists of a key name
        /// and an associated value. For more information about session tags, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Tagging
        /// AWS STS Sessions</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. You can pass up to 50 session tags. The plain text session
        /// tag keys can’t exceed 128 characters, and the values can’t exceed 256 characters.
        /// For these and additional limits, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-limits.html#reference_iam-limits-entity-length">IAM
        /// and STS Character Limits</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// An AWS conversion compresses the passed session policies and session tags into a packed
        /// binary format that has a separate limit. Your request can fail for this limit even
        /// if your plain text meets the other requirements. The <code>PackedPolicySize</code>
        /// response element indicates by percentage how close the policies and tags for your
        /// request are to the upper size limit. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can pass a session tag with the same key as a tag that is already attached to
        /// the role. When you do, session tags override a role tag with the same key. 
        /// </para>
        ///  
        /// <para>
        /// Tag key–value pairs are not case sensitive, but case is preserved. This means that
        /// you cannot have separate <code>Department</code> and <code>department</code> tag keys.
        /// Assume that the role has the <code>Department</code>=<code>Marketing</code> tag and
        /// you pass the <code>department</code>=<code>engineering</code> session tag. <code>Department</code>
        /// and <code>department</code> are not saved as separate tags, and the session tag passed
        /// in the request takes precedence over the role tag.
        /// </para>
        ///  
        /// <para>
        /// Additionally, if you used temporary credentials to perform this operation, the new
        /// session inherits any transitive session tags from the calling session. If you pass
        /// a session tag with the same key as an inherited tag, the operation fails. To view
        /// the inherited tags for a session, see the AWS CloudTrail logs. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/session-tags.html#id_session-tags_ctlogs">Viewing
        /// Session Tags in CloudTrail</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
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
        [AWSProperty(Min=6, Max=6)]
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

        /// <summary>
        /// Gets and sets the property TransitiveTagKeys. 
        /// <para>
        /// A list of keys for session tags that you want to set as transitive. If you set a tag
        /// key as transitive, the corresponding key and value passes to subsequent sessions in
        /// a role chain. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html#id_session-tags_role-chaining">Chaining
        /// Roles with Session Tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. When you set session tags as transitive, the session policy
        /// and session tags packed binary limit is not affected.
        /// </para>
        ///  
        /// <para>
        /// If you choose not to specify a transitive tag key, then no tags are passed from this
        /// session to any subsequent sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> TransitiveTagKeys
        {
            get { return this._transitiveTagKeys; }
            set { this._transitiveTagKeys = value; }
        }

        // Check to see if TransitiveTagKeys property is set
        internal bool IsSetTransitiveTagKeys()
        {
            return this._transitiveTagKeys != null && this._transitiveTagKeys.Count > 0; 
        }

    }
}