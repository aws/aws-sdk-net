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
    /// Container for the parameters to the AssumeRoleWithWebIdentity operation.
    /// Returns a set of temporary security credentials for users who have been authenticated
    /// in a mobile or web application with a web identity provider. Example providers include
    /// Amazon Cognito, Login with Amazon, Facebook, Google, or any OpenID Connect-compatible
    /// identity provider.
    /// 
    ///  <note> 
    /// <para>
    /// For mobile applications, we recommend that you use Amazon Cognito. You can use Amazon
    /// Cognito with the <a href="http://aws.amazon.com/sdkforios/">AWS SDK for iOS Developer
    /// Guide</a> and the <a href="http://aws.amazon.com/sdkforandroid/">AWS SDK for Android
    /// Developer Guide</a> to uniquely identify a user. You can also supply the user with
    /// a consistent identity throughout the lifetime of an application.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Amazon Cognito, see <a href="https://docs.aws.amazon.com/mobile/sdkforandroid/developerguide/cognito-auth.html#d0e840">Amazon
    /// Cognito Overview</a> in <i>AWS SDK for Android Developer Guide</i> and <a href="https://docs.aws.amazon.com/mobile/sdkforios/developerguide/cognito-auth.html#d0e664">Amazon
    /// Cognito Overview</a> in the <i>AWS SDK for iOS Developer Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Calling <code>AssumeRoleWithWebIdentity</code> does not require the use of AWS security
    /// credentials. Therefore, you can distribute an application (for example, on mobile
    /// devices) that requests temporary security credentials without including long-term
    /// AWS credentials in the application. You also don't need to deploy server-based proxy
    /// services that use long-term AWS credentials. Instead, the identity of the caller is
    /// validated by using a token from the web identity provider. For a comparison of <code>AssumeRoleWithWebIdentity</code>
    /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
    /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The temporary security credentials returned by this API consist of an access key ID,
    /// a secret access key, and a security token. Applications can use these temporary security
    /// credentials to sign calls to AWS service API operations.
    /// </para>
    ///  
    /// <para>
    ///  <b>Session Duration</b> 
    /// </para>
    ///  
    /// <para>
    /// By default, the temporary security credentials created by <code>AssumeRoleWithWebIdentity</code>
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
    /// The temporary security credentials created by <code>AssumeRoleWithWebIdentity</code>
    /// can be used to make API calls to any AWS service with the following exception: you
    /// cannot call the STS <code>GetFederationToken</code> or <code>GetSessionToken</code>
    /// API operations.
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
    ///  <b>Tags</b> 
    /// </para>
    ///  
    /// <para>
    /// (Optional) You can configure your IdP to pass attributes into your web identity token
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
    /// When you do, the session tag overrides the role tag with the same key.
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
    ///  <b>Identities</b> 
    /// </para>
    ///  
    /// <para>
    /// Before your application can call <code>AssumeRoleWithWebIdentity</code>, you must
    /// have an identity token from a supported identity provider and create a role that the
    /// application can assume. The role that your application assumes must trust the identity
    /// provider that is associated with the identity token. In other words, the identity
    /// provider must be specified in the role's trust policy. 
    /// </para>
    ///  <important> 
    /// <para>
    /// Calling <code>AssumeRoleWithWebIdentity</code> can result in an entry in your AWS
    /// CloudTrail logs. The entry includes the <a href="http://openid.net/specs/openid-connect-core-1_0.html#Claims">Subject</a>
    /// of the provided Web Identity Token. We recommend that you avoid using any personally
    /// identifiable information (PII) in this field. For example, you could instead use a
    /// GUID or a pairwise identifier, as <a href="http://openid.net/specs/openid-connect-core-1_0.html#SubjectIDTypes">suggested
    /// in the OIDC specification</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about how to use web identity federation and the <code>AssumeRoleWithWebIdentity</code>
    /// API, see the following resources: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc_manual.html">Using
    /// Web Identity Federation API Operations for Mobile Apps</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
    /// Through a Web-based Identity Provider</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://aws.amazon.com/blogs/aws/the-aws-web-identity-federation-playground/">
    /// Web Identity Federation Playground</a>. Walk through the process of authenticating
    /// through Login with Amazon, Facebook, or Google, getting temporary security credentials,
    /// and then using those credentials to make a request to AWS. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/sdkforios/">AWS SDK for iOS Developer Guide</a> and
    /// <a href="http://aws.amazon.com/sdkforandroid/">AWS SDK for Android Developer Guide</a>.
    /// These toolkits contain sample apps that show how to invoke the identity providers.
    /// The toolkits then show how to use the information from these providers to get and
    /// use temporary security credentials. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/articles/web-identity-federation-with-mobile-applications">Web
    /// Identity Federation with Mobile Applications</a>. This article discusses web identity
    /// federation and shows an example of how to use web identity federation to get access
    /// to content in Amazon S3. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssumeRoleWithWebIdentityRequest : AmazonSecurityTokenServiceRequest
    {
        private int? _durationSeconds;
        private string _policy;
        private List<PolicyDescriptorType> _policyArns = new List<PolicyDescriptorType>();
        private string _providerId;
        private string _roleArn;
        private string _roleSessionName;
        private string _webIdentityToken;

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
        /// Gets and sets the property ProviderId. 
        /// <para>
        /// The fully qualified host component of the domain name of the identity provider.
        /// </para>
        ///  
        /// <para>
        /// Specify this value only for OAuth 2.0 access tokens. Currently <code>www.amazon.com</code>
        /// and <code>graph.facebook.com</code> are the only supported identity providers for
        /// OAuth 2.0 access tokens. Do not include URL schemes and port numbers.
        /// </para>
        ///  
        /// <para>
        /// Do not specify this value for OpenID Connect ID tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=2048)]
        public string ProviderId
        {
            get { return this._providerId; }
            set { this._providerId = value; }
        }

        // Check to see if ProviderId property is set
        internal bool IsSetProviderId()
        {
            return this._providerId != null;
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
        /// Gets and sets the property RoleSessionName. 
        /// <para>
        /// An identifier for the assumed role session. Typically, you pass the name or identifier
        /// that is associated with the user who is using your application. That way, the temporary
        /// security credentials that your application will use are associated with that user.
        /// This session name is included as part of the ARN and assumed role ID in the <code>AssumedRoleUser</code>
        /// response element.
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
        /// Gets and sets the property WebIdentityToken. 
        /// <para>
        /// The OAuth 2.0 access token or OpenID Connect ID token that is provided by the identity
        /// provider. Your application must get this token by authenticating the user who is using
        /// your application with a web identity provider before the application makes an <code>AssumeRoleWithWebIdentity</code>
        /// call. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=2048)]
        public string WebIdentityToken
        {
            get { return this._webIdentityToken; }
            set { this._webIdentityToken = value; }
        }

        // Check to see if WebIdentityToken property is set
        internal bool IsSetWebIdentityToken()
        {
            return this._webIdentityToken != null;
        }

    }
}