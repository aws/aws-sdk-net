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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// This is the response object from the GetPoliciesStats operation.
    /// </summary>
    public partial class GetPoliciesStatsResponse : AmazonWebServiceResponse
    {
        private AccessPolicyStats _accessPolicyStats;
        private SecurityConfigStats _securityConfigStats;
        private SecurityPolicyStats _securityPolicyStats;
        private long? _totalPolicyCount;

        /// <summary>
        /// Gets and sets the property AccessPolicyStats. 
        /// <para>
        /// Information about the data access policies in your account.
        /// </para>
        /// </summary>
        public AccessPolicyStats AccessPolicyStats
        {
            get { return this._accessPolicyStats; }
            set { this._accessPolicyStats = value; }
        }

        // Check to see if AccessPolicyStats property is set
        internal bool IsSetAccessPolicyStats()
        {
            return this._accessPolicyStats != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfigStats. 
        /// <para>
        /// Information about the security configurations in your account.
        /// </para>
        /// </summary>
        public SecurityConfigStats SecurityConfigStats
        {
            get { return this._securityConfigStats; }
            set { this._securityConfigStats = value; }
        }

        // Check to see if SecurityConfigStats property is set
        internal bool IsSetSecurityConfigStats()
        {
            return this._securityConfigStats != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityPolicyStats. 
        /// <para>
        /// Information about the security policies in your account.
        /// </para>
        /// </summary>
        public SecurityPolicyStats SecurityPolicyStats
        {
            get { return this._securityPolicyStats; }
            set { this._securityPolicyStats = value; }
        }

        // Check to see if SecurityPolicyStats property is set
        internal bool IsSetSecurityPolicyStats()
        {
            return this._securityPolicyStats != null;
        }

        /// <summary>
        /// Gets and sets the property TotalPolicyCount. 
        /// <para>
        /// The total number of OpenSearch Serverless security policies and configurations in
        /// your account.
        /// </para>
        /// </summary>
        public long TotalPolicyCount
        {
            get { return this._totalPolicyCount.GetValueOrDefault(); }
            set { this._totalPolicyCount = value; }
        }

        // Check to see if TotalPolicyCount property is set
        internal bool IsSetTotalPolicyCount()
        {
            return this._totalPolicyCount.HasValue; 
        }

    }
}