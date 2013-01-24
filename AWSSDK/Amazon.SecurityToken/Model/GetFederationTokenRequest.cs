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
    /// <para>The GetFederationToken action returns a set of temporary credentials for a federated user with the user name and policy specified in
    /// the request. The credentials consist of an Access Key ID, a Secret Access Key, and a security token. Credentials created by IAM users are
    /// valid for the specified duration, between 15 minutes and 36 hours; credentials created using account credentials have a maximum duration of
    /// one hour.</para> <para>The federated user who holds these credentials has any permissions allowed by the intersection of the specified
    /// policy and any resource or user policies that apply to the caller of the GetFederationToken API, and any resource policies that apply to the
    /// federated user's Amazon Resource Name (ARN). For more information about how token permissions work, see Controlling Permissions in Temporary
    /// Credentials in <i>Using IAM</i> . For information about using GetFederationToken to create temporary credentials, see Creating Temporary
    /// Credentials to Enable Access for Federated Users in <i>Using IAM</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetFederationToken"/>
    public class GetFederationTokenRequest : AmazonWebServiceRequest
    {
        private string name;
        private string policy;
        private int? durationSeconds;

        /// <summary>
        /// The name of the federated user associated with the credentials. For information about limitations on user names, go to <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations on IAM Entities</a> in <i>Using
        /// IAM</i>.
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

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public GetFederationTokenRequest WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;       
        }

        /// <summary>
        /// A policy specifying the permissions to associate with the credentials. The caller can delegate their own permissions by specifying a policy,
        /// and both policies will be checked when a service call is made. For more information about how permissions work in the context of temporary
        /// credentials, see <a href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/TokenPermissions.html" target="_blank">Controlling
        /// Permissions in Temporary Credentials</a> in <i>Using IAM</i>.
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
        public GetFederationTokenRequest WithPolicy(string policy)
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
        /// The duration, in seconds, that the session should last. Acceptable durations for federation sessions range from 900s (15 minutes) to 129600s
        /// (36 hours), with 43200s (12 hours) as the default. Sessions for AWS account owners are restricted to a maximum of 3600s (one hour). If the
        /// duration is longer than one hour, the session for AWS account owners defaults to one hour.
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

        /// <summary>
        /// Sets the DurationSeconds property
        /// </summary>
        /// <param name="durationSeconds">The value to set for the DurationSeconds property </param>
        /// <returns>this instance</returns>
        public GetFederationTokenRequest WithDurationSeconds(int durationSeconds)
        {
            this.durationSeconds = durationSeconds;
            return this;
        }
            

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this.durationSeconds.HasValue;       
        }
    }
}
    
