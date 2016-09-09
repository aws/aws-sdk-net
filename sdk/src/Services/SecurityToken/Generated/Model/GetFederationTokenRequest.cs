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
    /// applications inside a corporate network. Because you must call the <code>GetFederationToken</code>
    /// action using the long-term security credentials of an IAM user, this call is appropriate
    /// in contexts where those credentials can be safely stored, usually in a server-based
    /// application. For a comparison of <code>GetFederationToken</code> with the other APIs
    /// that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
    /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    ///  If you are creating a mobile-based or browser-based app that can authenticate users
    /// using a web identity provider like Login with Amazon, Facebook, Google, or an OpenID
    /// Connect-compatible identity provider, we recommend that you use <a href="http://aws.amazon.com/cognito/">Amazon
    /// Cognito</a> or <code>AssumeRoleWithWebIdentity</code>. For more information, see <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
    /// Through a Web-based Identity Provider</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The <code>GetFederationToken</code> action must be called by using the long-term AWS
    /// security credentials of an IAM user. You can also call <code>GetFederationToken</code>
    /// using the security credentials of an AWS root account, but we do not recommended it.
    /// Instead, we recommend that you create an IAM user for the purpose of the proxy application
    /// and then attach a policy to the IAM user that limits federated users to only the actions
    /// and resources that they need access to. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html">IAM
    /// Best Practices</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// The temporary security credentials that are obtained by using the long-term credentials
    /// of an IAM user are valid for the specified duration, from 900 seconds (15 minutes)
    /// up to a maximium of 129600 seconds (36 hours). The default is 43200 seconds (12 hours).
    /// Temporary credentials that are obtained by using AWS root account credentials have
    /// a maximum duration of 3600 seconds (1 hour).
    /// </para>
    ///  
    /// <para>
    /// The temporary security credentials created by <code>GetFederationToken</code> can
    /// be used to make API calls to any AWS service with the following exceptions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You cannot use these credentials to call any IAM APIs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot call any STS APIs.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// The permissions for the temporary security credentials returned by <code>GetFederationToken</code>
    /// are determined by a combination of the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The policy or policies that are attached to the IAM user whose credentials are used
    /// to call <code>GetFederationToken</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The policy that is passed as a parameter in the call.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The passed policy is attached to the temporary security credentials that result from
    /// the <code>GetFederationToken</code> API call--that is, to the <i>federated user</i>.
    /// When the federated user makes an AWS request, AWS evaluates the policy attached to
    /// the federated user in combination with the policy or policies attached to the IAM
    /// user whose credentials were used to call <code>GetFederationToken</code>. AWS allows
    /// the federated user's request only when both the federated user <i> <b>and</b> </i>
    /// the IAM user are explicitly allowed to perform the requested action. The passed policy
    /// cannot grant more permissions than those that are defined in the IAM user policy.
    /// </para>
    ///  
    /// <para>
    /// A typical use case is that the permissions of the IAM user whose credentials are used
    /// to call <code>GetFederationToken</code> are designed to allow access to all the actions
    /// and resources that any federated user will need. Then, for individual users, you pass
    /// a policy to the operation that scopes down the permissions to a level that's appropriate
    /// to that individual user, using a policy that allows only a subset of permissions that
    /// are granted to the IAM user. 
    /// </para>
    ///  
    /// <para>
    /// If you do not pass a policy, the resulting temporary security credentials have no
    /// effective permissions. The only exception is when the temporary security credentials
    /// are used to access a resource that has a resource-based policy that specifically allows
    /// the federated user to access the resource.
    /// </para>
    ///  
    /// <para>
    /// For more information about how permissions work, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_getfederationtoken.html">Permissions
    /// for GetFederationToken</a>. For information about using <code>GetFederationToken</code>
    /// to create temporary security credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getfederationtoken">GetFederationToken—Federation
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
        /// <param name="name">The name of the federated user. The name is used as an identifier for the temporary security credentials (such as <code>Bob</code>). For example, you can reference the federated user name in a resource-based policy, such as in an Amazon S3 bucket policy. The format for this parameter, as described by its regex pattern, is a string of characters consisting of upper- and lower-case alphanumeric characters with no spaces. You can also include underscores or any of the following characters: =,.@-</param>
        public GetFederationTokenRequest(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, that the session should last. Acceptable durations for federation
        /// sessions range from 900 seconds (15 minutes) to 129600 seconds (36 hours), with 43200
        /// seconds (12 hours) as the default. Sessions obtained using AWS account (root) credentials
        /// are restricted to a maximum of 3600 seconds (one hour). If the specified duration
        /// is longer than one hour, the session obtained by using AWS account (root) credentials
        /// defaults to one hour.
        /// </para>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the federated user. The name is used as an identifier for the temporary
        /// security credentials (such as <code>Bob</code>). For example, you can reference the
        /// federated user name in a resource-based policy, such as in an Amazon S3 bucket policy.
        /// </para>
        ///  
        /// <para>
        /// The format for this parameter, as described by its regex pattern, is a string of characters
        /// consisting of upper- and lower-case alphanumeric characters with no spaces. You can
        /// also include underscores or any of the following characters: =,.@-
        /// </para>
        /// </summary>
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
        /// An IAM policy in JSON format that is passed with the <code>GetFederationToken</code>
        /// call and evaluated along with the policy or policies that are attached to the IAM
        /// user whose credentials are used to call <code>GetFederationToken</code>. The passed
        /// policy is used to scope down the permissions that are available to the IAM user, by
        /// allowing only a subset of the permissions that are granted to the IAM user. The passed
        /// policy cannot grant more permissions than those granted to the IAM user. The final
        /// permissions for the federated user are the most restrictive set based on the intersection
        /// of the passed policy and the IAM user policy.
        /// </para>
        ///  
        /// <para>
        /// If you do not pass a policy, the resulting temporary security credentials have no
        /// effective permissions. The only exception is when the temporary security credentials
        /// are used to access a resource that has a resource-based policy that specifically allows
        /// the federated user to access the resource.
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
        /// <para>
        /// For more information about how permissions work, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_getfederationtoken.html">Permissions
        /// for GetFederationToken</a>.
        /// </para>
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

    }
}