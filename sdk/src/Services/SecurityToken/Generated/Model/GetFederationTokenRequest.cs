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
    /// Container for the parameters to the GetFederationToken operation.
    /// Returns a set of temporary security credentials (consisting of an access key ID, a
    /// secret access key, and a security token) for a federated user. A typical use is in
    /// a proxy application that gets temporary security credentials on behalf of distributed
    /// applications inside a corporate network. You must call the <code>GetFederationToken</code>
    /// operation using the long-term security credentials of an IAM user. As a result, this
    /// call is appropriate in contexts where those credentials can be safely stored, usually
    /// in a server-based application. For a comparison of <code>GetFederationToken</code>
    /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
    /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// You can create a mobile-based or browser-based app that can authenticate users using
    /// a web identity provider like Login with Amazon, Facebook, Google, or an OpenID Connect-compatible
    /// identity provider. In this case, we recommend that you use <a href="http://aws.amazon.com/cognito/">Amazon
    /// Cognito</a> or <code>AssumeRoleWithWebIdentity</code>. For more information, see <a
    /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
    /// Through a Web-based Identity Provider</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can also call <code>GetFederationToken</code> using the security credentials of
    /// an AWS account root user, but we do not recommend it. Instead, we recommend that you
    /// create an IAM user for the purpose of the proxy application. Then attach a policy
    /// to the IAM user that limits federated users to only the actions and resources that
    /// they need to access. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html">IAM
    /// Best Practices</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// The temporary credentials are valid for the specified duration, from 900 seconds (15
    /// minutes) up to a maximum of 129,600 seconds (36 hours). The default is 43,200 seconds
    /// (12 hours). Temporary credentials that are obtained by using AWS account root user
    /// credentials have a maximum duration of 3,600 seconds (1 hour).
    /// </para>
    ///  
    /// <para>
    /// The temporary security credentials created by <code>GetFederationToken</code> can
    /// be used to make API calls to any AWS service with the following exceptions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You cannot use these credentials to call any IAM API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot call any STS API operations except <code>GetCallerIdentity</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// You must pass an IAM permissions policy to <code>GetFederationToken</code>. When you
    /// pass a policy to this operation, the resulting temporary credentials are defined by
    /// the intersection of your IAM user policies and the passed policy . The passed policy
    /// defines the permissions of the <i>federated user</i>. AWS allows the federated user's
    /// request only when both the attached policy and the IAM user policy explicitly allow
    /// the federated user to perform the requested action. The passed policy cannot grant
    /// more permissions than those that are defined in the IAM user policy. For more information
    /// about how permissions work, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_getfederationtoken.html">Permissions
    /// for GetFederationToken</a>. For information about using <code>GetFederationToken</code>
    /// to create temporary security credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getfederationtoken">GetFederationToken—Federation
    /// Through a Custom Identity Broker</a>. 
    /// </para>
    /// </summary>
    public partial class GetFederationTokenRequest : AmazonSecurityTokenServiceRequest
    {
        private int? _durationSeconds;
        private string _name;
        private string _policy;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetFederationTokenRequest() { }

        /// <summary>
        /// Instantiates GetFederationTokenRequest with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the federated user. The name is used as an identifier for the temporary security credentials (such as <code>Bob</code>). For example, you can reference the federated user name in a resource-based policy, such as in an Amazon S3 bucket policy. The regex used to validate this parameter is a string of characters consisting of upper- and lower-case alphanumeric characters with no spaces. You can also include underscores or any of the following characters: =,.@-</param>
        public GetFederationTokenRequest(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, that the session should last. Acceptable durations for federation
        /// sessions range from 900 seconds (15 minutes) to 129,600 seconds (36 hours), with 43,200
        /// seconds (12 hours) as the default. Sessions obtained using AWS account root user credentials
        /// are restricted to a maximum of 3,600 seconds (one hour). If the specified duration
        /// is longer than one hour, the session obtained by using root user credentials defaults
        /// to one hour.
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=129600)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the federated user. The name is used as an identifier for the temporary
        /// security credentials (such as <code>Bob</code>). For example, you can reference the
        /// federated user name in a resource-based policy, such as in an Amazon S3 bucket policy.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=32)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// An IAM policy in JSON format. You must pass an IAM permissions policy to <code>GetFederationToken</code>.
        /// When you pass a policy to this operation, the resulting temporary credentials are
        /// defined by the intersection of your IAM user policies and the policy that you pass.
        /// The passed policy defines the permissions of the <i>federated user</i>. AWS allows
        /// the federated user's request only when both the attached policy and the IAM user policy
        /// explicitly allow the federated user to perform the requested action. The passed policy
        /// cannot grant more permissions than those that are defined in the IAM user policy.
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
        /// The policy plaintext must be 2048 bytes or shorter. However, an internal conversion
        /// compresses it into a packed binary format with a separate limit. The <code>PackedPolicySize</code>
        /// response element indicates by percentage how close to the upper size limit the policy
        /// is, where 100 percent is the maximum allowed size.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about how permissions work, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_getfederationtoken.html">Permissions
        /// for GetFederationToken</a>.
        /// </para>
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

    }
}