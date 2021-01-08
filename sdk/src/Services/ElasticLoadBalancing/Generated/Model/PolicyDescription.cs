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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Information about a policy.
    /// </summary>
    public partial class PolicyDescription
    {
        private List<PolicyAttributeDescription> _policyAttributeDescriptions = new List<PolicyAttributeDescription>();
        private string _policyName;
        private string _policyTypeName;

        /// <summary>
        /// Gets and sets the property PolicyAttributeDescriptions. 
        /// <para>
        /// The policy attributes.
        /// </para>
        /// </summary>
        public List<PolicyAttributeDescription> PolicyAttributeDescriptions
        {
            get { return this._policyAttributeDescriptions; }
            set { this._policyAttributeDescriptions = value; }
        }

        // Check to see if PolicyAttributeDescriptions property is set
        internal bool IsSetPolicyAttributeDescriptions()
        {
            return this._policyAttributeDescriptions != null && this._policyAttributeDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyTypeName. 
        /// <para>
        /// The name of the policy type.
        /// </para>
        /// </summary>
        public string PolicyTypeName
        {
            get { return this._policyTypeName; }
            set { this._policyTypeName = value; }
        }

        // Check to see if PolicyTypeName property is set
        internal bool IsSetPolicyTypeName()
        {
            return this._policyTypeName != null;
        }

    }
}