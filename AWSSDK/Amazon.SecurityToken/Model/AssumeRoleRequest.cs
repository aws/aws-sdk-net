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
    /// see Roles in <i>Using IAM</i> .
    /// </para> <para> For federation, you can, for example, grant single sign-on access to the AWS Management Console. If you already have an
    /// identity and authentication system in your corporate network, you don't have to recreate user identities in AWS in order to grant those user
    /// identities access to AWS. Instead, after a user has been authenticated, you call <c>AssumeRole</c> (and specify the role with the
    /// appropriate permissions) to get temporary security credentials for that user. With those temporary security credentials, you construct a
    /// sign-in URL that users can use to access the console. For more information, see Scenarios for Granting Temporary Access in <i>AWS Security
    /// Token Service</i> .
    /// </para> <para> The temporary security credentials are valid for the duration that you specified when calling <c>AssumeRole</c> , which
    /// can be from 900 seconds (15 minutes) to 3600 seconds (1 hour). The default is 1 hour. </para> <para> The temporary security credentials that
    /// are returned from the <c>AssumeRoleWithWebIdentity</c> response have the permissions that are associated with the access policy of the role
    /// being assumed and any policies that are associated with the AWS resource being accessed. You can further restrict the permissions of the
    /// temporary security credentials by passing a policy in the request. The resulting permissions are an intersection of the role's access policy
    /// and the policy that you passed. These policies and any applicable resource-based policies are evaluated when calls to AWS service APIs are
    /// made using the temporary security credentials. </para> <para> To assume a role, your AWS account must be trusted by the role. The trust
    /// relationship is defined in the role's trust policy when the IAM role is created. You must also have a policy that allows you to call
    /// <c>sts:AssumeRole</c> .
    /// </para> <para> <b>Important:</b> You cannot call <c>Assumerole</c> by using AWS account credentials; access will be denied. You must use
    /// IAM user credentials or temporary security credentials to call <c>AssumeRole</c> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.AssumeRole"/>
    public class AssumeRoleRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the RoleArn property
        /// </summary>
        /// <param name="roleArn">The value to set for the RoleArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleRequest WithRoleArn(string roleArn)
        {
            this.roleArn = roleArn;
            return this;
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

        /// <summary>
        /// Sets the RoleSessionName property
        /// </summary>
        /// <param name="roleSessionName">The value to set for the RoleSessionName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleRequest WithRoleSessionName(string roleSessionName)
        {
            this.roleSessionName = roleSessionName;
            return this;
        }
            

        // Check to see if RoleSessionName property is set
        internal bool IsSetRoleSessionName()
        {
            return this.roleSessionName != null;
        }

        /// <summary>
        /// A supplemental policy that is associated with the temporary security credentials from the <c>AssumeRole</c> call. The resulting permissions
        /// of the temporary security credentials are an intersection of this policy and the access policy that is associated with the role. Use this
        /// policy to further restrict the permissions of the temporary security credentials.
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

        /// <summary>
        /// Sets the Policy property
        /// </summary>
        /// <param name="policy">The value to set for the Policy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleRequest WithPolicy(string policy)
        {
            this.policy = policy;
            return this;
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

        /// <summary>
        /// Sets the DurationSeconds property
        /// </summary>
        /// <param name="durationSeconds">The value to set for the DurationSeconds property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleRequest WithDurationSeconds(int durationSeconds)
        {
            this.durationSeconds = durationSeconds;
            return this;
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

        /// <summary>
        /// Sets the ExternalId property
        /// </summary>
        /// <param name="externalId">The value to set for the ExternalId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleRequest WithExternalId(string externalId)
        {
            this.externalId = externalId;
            return this;
        }
            

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this.externalId != null;
        }
    }
}
    
