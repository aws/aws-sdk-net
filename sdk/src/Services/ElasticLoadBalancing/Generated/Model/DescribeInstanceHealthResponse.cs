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
    /// Contains the output for DescribeInstanceHealth.
    /// </summary>
    public partial class DescribeInstanceHealthResponse : AmazonWebServiceResponse
    {
        private List<InstanceState> _instanceStates = new List<InstanceState>();

        /// <summary>
        /// Gets and sets the property InstanceStates. 
        /// <para>
        /// Information about the health of the instances.
        /// </para>
        /// </summary>
        public List<InstanceState> InstanceStates
        {
            get { return this._instanceStates; }
            set { this._instanceStates = value; }
        }

        // Check to see if InstanceStates property is set
        internal bool IsSetInstanceStates()
        {
            return this._instanceStates != null && this._instanceStates.Count > 0; 
        }

    }
}