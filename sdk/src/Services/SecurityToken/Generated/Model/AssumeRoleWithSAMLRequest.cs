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
    /// Container for the parameters to the AssumeRoleWithSAML operation.
    /// Returns a set of temporary security credentials for users who have been authenticated
    /// via a SAML authentication response. This operation provides a mechanism for tying
    /// an enterprise identity store or directory to role-based AWS access without user-specific
    /// credentials or configuration. For a comparison of <code>AssumeRoleWithSAML</code>
    /// with the other APIs that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
    /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
    /// 
    ///  
    /// <para>
    /// The temporary security credentials returned by this operation consist of an access
    /// key ID, a secret access key, and a security token. Applications can use these temporary
    /// security credentials to sign calls to AWS services.
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
    /// 12 hours. To learn how to view the maximum value for your role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
    /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
    /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
    /// API operations or the <code>assume-role*</code> CLI operations but does not apply
    /// when you use those operations to create a console URL. For more information, see <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using IAM
    /// Roles</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The temporary security credentials created by <code>AssumeRoleWithSAML</code> can
    /// be used to make API calls to any AWS service with the following exception: you cannot
    /// call the STS service's <code>GetFederationToken</code> or <code>GetSessionToken</code>
    /// APIs.
    /// </para>
    ///  
    /// <para>
    /// Optionally, you can pass an IAM access policy to this operation. If you choose not
    /// to pass a policy, the temporary security credentials that are returned by the operation
    /// have the permissions that are defined in the access policy of the role that is being
    /// assumed. If you pass a policy to this operation, the temporary security credentials
    /// that are returned by the operation have the permissions that are allowed by the intersection
    /// of both the access policy of the role that is being assumed, <i> <b>and</b> </i> the
    /// policy that you pass. This means that both policies must grant the permission for
    /// the action to be allowed. This gives you a way to further restrict the permissions
    /// for the resulting temporary security credentials. You cannot use the passed policy
    /// to grant permissions that are in excess of those allowed by the access policy of the
    /// role that is being assumed. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_assumerole.html">Permissions
    /// for AssumeRole, AssumeRoleWithSAML, and AssumeRoleWithWebIdentity</a> in the <i>IAM
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Before your application can call <code>AssumeRoleWithSAML</code>, you must configure
    /// your SAML identity provider (IdP) to issue the claims required by AWS. Additionally,
    /// you must use AWS Identity and Access Management (IAM) to create a SAML provider entity
    /// in your AWS account that represents your identity provider, and create an IAM role
    /// that specifies this SAML provider in its trust policy. 
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
    /// assertion. We recommend that you use a NameIDType that is not associated with any
    /// personally identifiable information (PII). For example, you could instead use the
    /// Persistent Identifier (<code>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent</code>).
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
    /// SAML 2.0-based Federation</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml.html">Creating
    /// SAML Identity Providers</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml_relying-party.html">Configuring
    /// a Relying Party and Claims</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-idp_saml.html">Creating
    /// a Role for SAML 2.0 Federation</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssumeRoleWithSAMLRequest : AmazonSecurityTokenServiceRequest
    {
        private int? _durationSeconds;
        private string _policy;
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
        /// operation fails. To learn how to view the maximum value for your role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
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
        /// Gets and sets the property Policy. 
        /// <para>
        /// An IAM policy in JSON format.
        /// </para>
        ///  
        /// <para>
        /// The policy parameter is optional. If you pass a policy, the temporary security credentials
        /// that are returned by the operation have the permissions that are allowed by both the
        /// access policy of the role that is being assumed, <i> <b>and</b> </i> the policy that
        /// you pass. This gives you a way to further restrict the permissions for the resulting
        /// temporary security credentials. You cannot use the passed policy to grant permissions
        /// that are in excess of those allowed by the access policy of the role that is being
        /// assumed. For more information, <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_assumerole.html">Permissions
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
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider in IAM that describes the IdP.
        /// </para>
        /// </summary>
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
        /// For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml-IdP-tasks.html">Configuring
        /// a Relying Party and Adding Claims</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
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