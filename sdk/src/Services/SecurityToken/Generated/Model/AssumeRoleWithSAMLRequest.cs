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
    /// Container for the parameters to the AssumeRoleWithSAML operation.
    /// Returns a set of temporary security credentials for users who have been authenticated
    /// via a SAML authentication response. This operation provides a mechanism for tying
    /// an enterprise identity store or directory to role-based AWS access without user-specific
    /// credentials or configuration. For a comparison of <code>AssumeRoleWithSAML</code>
    /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
    /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
    /// 
    ///  
    /// <para>
    /// The temporary security credentials returned by this operation consist of an access
    /// key ID, a secret access key, and a security token. Applications can use these temporary
    /// security credentials to sign calls to AWS services.
    /// </para>
    ///  
    /// <para>
    ///  <b>Session Duration</b> 
    /// </para>
    ///  
    /// <para>
    /// By default, the temporary security credentials created by <code>AssumeRoleWithSAML</code>
    /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
    /// parameter to specify the duration of your session. Your role session lasts for the
    /// duration that you specify, or until the time specified in the SAML authentication
    /// response's <code>SessionNotOnOrAfter</code> value, whichever is shorter. You can provide
    /// a <code>DurationSeconds</code> value from 900 seconds (15 minutes) up to the maximum
    /// session duration setting for the role. This setting can have a value from 1 hour to
    /// 12 hours. To learn how to view the maximum value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
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
    /// The temporary security credentials created by <code>AssumeRoleWithSAML</code> can
    /// be used to make API calls to any AWS service with the following exception: you cannot
    /// call the STS <code>GetFederationToken</code> or <code>GetSessionToken</code> API operations.
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
    /// Calling <code>AssumeRoleWithSAML</code> does not require the use of AWS security credentials.
    /// The identity of the caller is validated by using keys in the metadata document that
    /// is uploaded for the SAML provider entity for your identity provider. 
    /// </para>
    ///  <important> 
    /// <para>
    /// Calling <code>AssumeRoleWithSAML</code> can result in an entry in your AWS CloudTrail
    /// logs. The entry includes the value in the <code>NameID</code> element of the SAML
    /// assertion. We recommend that you use a <code>NameIDType</code> that is not associated
    /// with any personally identifiable information (PII). For example, you could instead
    /// use the persistent identifier (<code>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent</code>).
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Tags</b> 
    /// </para>
    ///  
    /// <para>
    /// (Optional) You can configure your IdP to pass attributes into your SAML assertion
    /// as session tags. Each session tag consists of a key name and an associated value.
    /// For more information about session tags, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
    /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can pass up to 50 session tags. The plain text session tag keys can’t exceed 128
    /// characters and the values can’t exceed 256 characters. For these and additional limits,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-limits.html#reference_iam-limits-entity-length">IAM
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
    /// You can pass a session tag with the same key as a tag that is attached to the role.
    /// When you do, session tags override the role's tags with the same key.
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
    ///  <b>SAML Configuration</b> 
    /// </para>
    ///  
    /// <para>
    /// Before your application can call <code>AssumeRoleWithSAML</code>, you must configure
    /// your SAML identity provider (IdP) to issue the claims required by AWS. Additionally,
    /// you must use AWS Identity and Access Management (IAM) to create a SAML provider entity
    /// in your AWS account that represents your identity provider. You must also create an
    /// IAM role that specifies this SAML provider in its trust policy. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
    /// SAML 2.0-based Federation</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml.html">Creating
    /// SAML Identity Providers</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml_relying-party.html">Configuring
    /// a Relying Party and Claims</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-idp_saml.html">Creating
    /// a Role for SAML 2.0 Federation</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssumeRoleWithSAMLRequest : AmazonSecurityTokenServiceRequest
    {
        private int? _durationSeconds;
        private string _policy;
        private List<PolicyDescriptorType> _policyArns = new List<PolicyDescriptorType>();
        private string _principalArn;
        private string _roleArn;
        private string _samlAssertion;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, of the role session. Your role session lasts for the duration
        /// that you specify for the <code>DurationSeconds</code> parameter, or until the time
        /// specified in the SAML authentication response's <code>SessionNotOnOrAfter</code> value,
        /// whichever is shorter. You can provide a <code>DurationSeconds</code> value from 900
        /// seconds (15 minutes) up to the maximum session duration setting for the role. This
        /// setting can have a value from 1 hour to 12 hours. If you specify a value higher than
        /// this setting, the operation fails. For example, if you specify a session duration
        /// of 12 hours, but your administrator set the maximum session duration to 6 hours, your
        /// operation fails. To learn how to view the maximum value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
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
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider in IAM that describes the IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that the caller is assuming.
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
        /// Gets and sets the property SAMLAssertion. 
        /// <para>
        /// The base-64 encoded SAML authentication response provided by the IdP.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml-IdP-tasks.html">Configuring
        /// a Relying Party and Adding Claims</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=100000)]
        public string SAMLAssertion
        {
            get { return this._samlAssertion; }
            set { this._samlAssertion = value; }
        }

        // Check to see if SAMLAssertion property is set
        internal bool IsSetSAMLAssertion()
        {
            return this._samlAssertion != null;
        }

    }
}