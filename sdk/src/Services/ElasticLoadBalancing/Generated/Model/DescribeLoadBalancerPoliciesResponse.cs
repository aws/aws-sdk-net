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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Contains the output of DescribeLoadBalancerPolicies.
    /// </summary>
    public partial class DescribeLoadBalancerPoliciesResponse : AmazonWebServiceResponse
    {
        private List<PolicyDescription> _policyDescriptions = new List<PolicyDescription>();

        /// <summary>
        /// Gets and sets the property PolicyDescriptions. 
        /// <para>
        /// Information about the policies.
        /// </para>
        /// </summary>
        public List<PolicyDescription> PolicyDescriptions
        {
            get { return this._policyDescriptions; }
            set { this._policyDescriptions = value; }
        }

        // Check to see if PolicyDescriptions property is set
        internal bool IsSetPolicyDescriptions()
        {
            return this._policyDescriptions != null && this._policyDescriptions.Count > 0; 
        }

    }
}