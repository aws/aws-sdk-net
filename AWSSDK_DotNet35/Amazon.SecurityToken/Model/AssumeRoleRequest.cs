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
    /// Container for the parameters to the AssumeRole operation.
    /// <para> Returns a set of temporary security credentials (consisting of an access key ID, a secret access key, and a security token) that you
    /// can use to access AWS resources that you might not normally have access to. Typically, you use <c>AssumeRole</c> for cross-account access or
    /// federation. </para> <para> For cross-account access, imagine that you own multiple accounts and need to access resources in each account.
    /// You could create long-term credentials in each account to access those resources. However, managing all those credentials and remembering
    /// which one can access which account can be time consuming. Instead, you can create one set of long-term credentials in one account and then
    /// use temporary security credentials to access all the other accounts by assuming roles in those accounts. For more information about roles,
    /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Roles</a> in <i>Using IAM</i> . </para> <para> For
    /// federation, you can, for example, grant single sign-on access to the AWS Management Console. If you already have an identity and
    /// authentication system in your corporate network, you don't have to recreate user identities in AWS in order to grant those user identities
    /// access to AWS. Instead, after a user has been authenticated, you call <c>AssumeRole</c> (and specify the role with the appropriate
    /// permissions) to get temporary security credentials for that user. With those temporary security credentials, you construct a sign-in URL
    /// that users can use to access the console. For more information, see <a
    /// href="http://docs.aws.amazon.com/STS/latest/UsingSTS/STSUseCases.html" >Scenarios for Granting Temporary Access</a> in <i>AWS Security Token
    /// Service</i> . </para> <para> The temporary security credentials are valid for the duration that you specified when calling <c>AssumeRole</c>
    /// , which can be from 900 seconds (15 minutes) to 3600 seconds (1 hour). The default is 1 hour. </para> <para>Optionally, you can pass an AWS
    /// IAM access policy to this operation. The temporary security credentials that are returned by the operation have the permissions that are
    /// associated with the access policy of the role that is being assumed, except for any permissions explicitly denied by the policy you pass.
    /// This gives you a way to further restrict the permissions for the federated user. These policies and any applicable resource-based policies
    /// are evaluated when calls to AWS are made using the temporary security credentials. </para> <para> To assume a role, your AWS account must be
    /// trusted by the role. The trust relationship is defined in the role's trust policy when the IAM role is created. You must also have a policy
    /// that allows you to call <c>sts:AssumeRole</c> . </para> <para> <b>Important:</b> You cannot call <c>AssumeRole</c> by using AWS account
    /// credentials; access will be denied. You must use IAM user credentials or temporary security credentials to call <c>AssumeRole</c> . </para>
    /// 
    /// </summary>
    public partial class AssumeRoleRequest : AmazonSecurityTokenServiceRequest
    {
        private string roleArn;
        private string roleSessionName;
        private string policy;
        private int? durationSeconds;
        private string externalId;


        /// <summary>
        /// The Amazon Resource Name (ARN) of the role that the caller is assuming.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>20 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this.roleArn; }
            set { this.roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this.roleArn != null;
        }

        /// <summary>
        /// An identifier for the assumed role session. The session name is included as part of the <c>AssumedRoleUser</c>.
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
        public string RoleSessionName
        {
            get { return this.roleSessionName; }
            set { this.roleSessionName = value; }
        }

        // Check to see if RoleSessionName property is set
        internal bool IsSetRoleSessionName()
        {
            return this.roleSessionName != null;
        }

        /// <summary>
        /// An AWS IAM policy in JSON format. The temporary security credentials that are returned by the operation have the permissions that are
        /// associated with the access policy of the role being assumed, except for any permissions explicitly denied by the policy you pass. This gives
        /// you a way to further restrict the permissions for the federated user. These policies and any applicable resource-based policies are
        /// evaluated when calls to AWS are made using the temporary security credentials.
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
        /// The duration, in seconds, of the role session. The value can range from 900 seconds (15 minutes) to 3600 seconds (1 hour). By default, the
        /// value is set to 3600 seconds.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>900 - 3600</description>
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

        /// <summary>
        /// A unique identifier that is used by third parties to assume a role in their customers' accounts. For each role that the third party can
        /// assume, they should instruct their customers to create a role with the external ID that the third party generated. Each time the third party
        /// assumes the role, they must pass the customer's external ID. The external ID is useful in order to help third parties bind a role to the
        /// customer who created it. For more information about the external ID, see <a
        /// href="http://docs.aws.amazon.com/STS/latest/UsingSTS/sts-delegating-externalid.html" target="_blank">About the External ID</a> in <i>Using
        /// Temporary Security Credentials</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>2 - 96</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@:-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this.externalId; }
            set { this.externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this.externalId != null;
        }

    }
}
    
