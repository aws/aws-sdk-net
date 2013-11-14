/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Returns a set of temporary security credentials (consisting of an access key ID, a secret access key, and a security token) for a
    /// federated user. A typical use is in a proxy application that is getting temporary security credentials on behalf of distributed applications
    /// inside a corporate network. Because you must call the <c>GetFederationToken</c> action using the long-term security credentials of an IAM
    /// user, this call is appropriate in contexts where those credentials can be safely stored, usually in a server-based application. </para>
    /// <para> <b>Note:</b> Do not use this call in mobile applications or client-based web applications that directly get temporary security
    /// credentials. For those types of applications, use <c>AssumeRoleWithWebIdentity</c> . </para> <para>The <c>GetFederationToken</c> action must
    /// be called by using the long-term AWS security credentials of the AWS account or an IAM user. Credentials that are created by IAM users are
    /// valid for the specified duration, between 900 seconds (15 minutes) and 129600 seconds (36 hours); credentials that are created by using
    /// account credentials have a maximum duration of 3600 seconds (1 hour). </para> <para>Optionally, you can pass an AWS IAM access policy to
    /// this operation. The temporary security credentials that are returned by the operation have the permissions that are associated with the
    /// entity that is making the <c>GetFederationToken</c> call, except for any permissions explicitly denied by the policy you pass. This gives
    /// you a way to further restrict the permissions for the federated user. These policies and any applicable resource-based policies are
    /// evaluated when calls to AWS are made using the temporary security credentials. </para> <para> For more information about how permissions
    /// work, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/TokenPermissions.html" >Controlling Permissions in Temporary
    /// Credentials</a> in <i>Using Temporary Security Credentials</i> . For information about using <c>GetFederationToken</c> to create temporary
    /// security credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingFedTokens.html" >Creating Temporary Credentials
    /// to Enable Access for Federated Users</a> in <i>Using Temporary Security Credentials</i> . </para>
    /// </summary>
    public partial class GetFederationTokenRequest : AmazonSecurityTokenServiceRequest
    {
        private string name;
        private string policy;
        private int? durationSeconds;


        /// <summary>
        /// The name of the federated user. The name is used as an identifier for the temporary security credentials (such as <c>Bob</c>). For example,
        /// you can reference the federated user name in a resource-based policy, such as in an Amazon S3 bucket policy.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>2 - 32</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// An AWS IAM policy in JSON format. By default, federated users have no permissions; they do not inherit any from the IAM user. When you
        /// specify a policy, the federated user's permissions are based on the specified policy and the IAM user's policy. If you don't specify a
        /// policy, federated users can only access AWS resources that explicitly allow those federated users in a resource policy, such as in an Amazon
        /// S3 bucket policy.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 2048</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this.policy; }
            set { this.policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this.policy != null;
        }

        /// <summary>
        /// The duration, in seconds, that the session should last. Acceptable durations for federation sessions range from 900 seconds (15 minutes) to
        /// 129600 seconds (36 hours), with 43200 seconds (12 hours) as the default. Sessions for AWS account owners are restricted to a maximum of 3600
        /// seconds (one hour). If the duration is longer than one hour, the session for AWS account owners defaults to one hour.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>900 - 129600</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int DurationSeconds
        {
            get { return this.durationSeconds ?? default(int); }
            set { this.durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this.durationSeconds.HasValue;
        }

    }
}
    
