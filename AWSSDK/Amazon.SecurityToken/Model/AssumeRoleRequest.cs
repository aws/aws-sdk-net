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
    /// <para> The <c>AssumeRole</c> action returns a set of temporary security credentials that you can use to access resources that are defined in
    /// the role's policy. The returned credentials consist of an Access Key ID, a Secret Access Key, and a security token. </para> <para>
    /// <b>Important:</b> Only IAM users can assume a role. If you use AWS account credentials to call AssumeRole, access is denied. </para> <para>
    /// The credentials are valid for the duration that you specified when calling <c>AssumeRole</c> , which can be from 15 minutes to 1 hour.
    /// </para> <para> When you assume a role, you have the privileges that are defined in the role. You can further restrict the privileges by
    /// passing a policy when calling <c>AssumeRole</c> .
    /// </para> <para> To assume a role, you must be an IAM user from a trusted entity and have permission to call <c>AssumeRole</c> .
    /// Trusted entites are defined when the IAM role is created. Permission to call <c>AssumeRole</c> is defined in your or your group's
    /// IAM policy. </para>
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
        /// A supplemental policy that can be associated with the temporary security credentials. The caller can restrict the permissions that are
        /// available on the role's temporary security credentials to maintain the least amount of privileges. When a service call is made with the
        /// temporary security credentials, both the role's permission policy and supplemental policy are checked. For more information about how
        /// permissions work in the context of temporary credentials, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/TokenPermissions.html" target="_blank">Controlling Permissions in Temporary
        /// Credentials</a>.
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
        /// value is set to 3600 seconds (1 hour).
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
        /// A unique identifier that is generated by a third party for each of their customers. Customers specify the external ID when they create a
        /// role. Each time the third party assumes the role, they must pass the customer's correct external ID. The external ID is useful in order to
        /// help third parties associate a role with the correct customer so that when a customer uses a third party, the third party only accesses the
        /// roles that were created by that customer. For more information about the external ID, see <a
        /// href="http://docs.amazonwebservices.com/STS/latest/UsingSTS/sts-delegating-externalid.html" target="_blank">About the External ID</a> in
        /// <i>Using Temporary Security Credentials</i>.
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
    
