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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// This is the response object from the GetPoliciesStats operation.
    /// </summary>
    public partial class GetPoliciesStatsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessPolicyStats. 
        /// <para>
        /// Information about the data access policies in your account.
        /// </para>
        /// </summary>
        public AccessPolicyStats AccessPolicyStats { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicyStats property is set.
        /// </summary>
        internal bool IsSetAccessPolicyStats() => this.AccessPolicyStats != null;

        /// <summary>
        /// Gets and sets the property LifecyclePolicyStats. 
        /// <para>
        /// Information about the lifecycle policies in your account.
        /// </para>
        /// </summary>
        public LifecyclePolicyStats LifecyclePolicyStats { get; set; }

        /// <summary>
        /// Checks to see if the LifecyclePolicyStats property is set.
        /// </summary>
        internal bool IsSetLifecyclePolicyStats() => this.LifecyclePolicyStats != null;

        /// <summary>
        /// Gets and sets the property SecurityConfigStats. 
        /// <para>
        /// Information about the security configurations in your account.
        /// </para>
        /// </summary>
        public SecurityConfigStats SecurityConfigStats { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfigStats property is set.
        /// </summary>
        internal bool IsSetSecurityConfigStats() => this.SecurityConfigStats != null;

        /// <summary>
        /// Gets and sets the property SecurityPolicyStats. 
        /// <para>
        /// Information about the security policies in your account.
        /// </para>
        /// </summary>
        public SecurityPolicyStats SecurityPolicyStats { get; set; }

        /// <summary>
        /// Checks to see if the SecurityPolicyStats property is set.
        /// </summary>
        internal bool IsSetSecurityPolicyStats() => this.SecurityPolicyStats != null;

        /// <summary>
        /// Gets and sets the property TotalPolicyCount. 
        /// <para>
        /// The total number of OpenSearch Serverless security policies and configurations in
        /// your account.
        /// </para>
        /// </summary>
        public long? TotalPolicyCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalPolicyCount property is set.
        /// </summary>
        internal bool IsSetTotalPolicyCount() => this.TotalPolicyCount.HasValue;
    }
}
