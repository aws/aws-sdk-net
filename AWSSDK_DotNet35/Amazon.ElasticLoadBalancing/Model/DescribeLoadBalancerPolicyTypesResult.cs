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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> The output for the DescribeLoadBalancerPolicyTypes action. </para>
    /// </summary>
    public partial class DescribeLoadBalancerPolicyTypesResult : AmazonWebServiceResponse
    {
        
        private List<PolicyTypeDescription> policyTypeDescriptions = new List<PolicyTypeDescription>();


        /// <summary>
        /// List of policy type description structures of the specified policy type. If no policy type names are specified, returns the description of
        /// all the policy types defined by Elastic Load Balancing service.
        ///  
        /// </summary>
        public List<PolicyTypeDescription> PolicyTypeDescriptions
        {
            get { return this.policyTypeDescriptions; }
            set { this.policyTypeDescriptions = value; }
        }

        // Check to see if PolicyTypeDescriptions property is set
        internal bool IsSetPolicyTypeDescriptions()
        {
            return this.policyTypeDescriptions.Count > 0;
        }
    }
}
