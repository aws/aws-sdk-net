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
    /// Contains the output of DescribeLoadBalancerPolicyTypes.
    /// </summary>
    public partial class DescribeLoadBalancerPolicyTypesResponse : AmazonWebServiceResponse
    {
        private List<PolicyTypeDescription> _policyTypeDescriptions = new List<PolicyTypeDescription>();

        /// <summary>
        /// Gets and sets the property PolicyTypeDescriptions. 
        /// <para>
        /// Information about the policy types.
        /// </para>
        /// </summary>
        public List<PolicyTypeDescription> PolicyTypeDescriptions
        {
            get { return this._policyTypeDescriptions; }
            set { this._policyTypeDescriptions = value; }
        }

        // Check to see if PolicyTypeDescriptions property is set
        internal bool IsSetPolicyTypeDescriptions()
        {
            return this._policyTypeDescriptions != null && this._policyTypeDescriptions.Count > 0; 
        }

    }
}