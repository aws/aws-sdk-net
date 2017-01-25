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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeSSLPolicies operation.
    /// </summary>
    public partial class DescribeSSLPoliciesResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<SslPolicy> _sslPolicies = new List<SslPolicy>();

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// The marker to use when requesting the next set of results. If there are no additional
        /// results, the string is empty.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property SslPolicies. 
        /// <para>
        /// Information about the policies.
        /// </para>
        /// </summary>
        public List<SslPolicy> SslPolicies
        {
            get { return this._sslPolicies; }
            set { this._sslPolicies = value; }
        }

        // Check to see if SslPolicies property is set
        internal bool IsSetSslPolicies()
        {
            return this._sslPolicies != null && this._sslPolicies.Count > 0; 
        }

    }
}