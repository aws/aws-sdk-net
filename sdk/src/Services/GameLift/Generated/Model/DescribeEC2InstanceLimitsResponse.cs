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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the DescribeEC2InstanceLimits operation.
    /// </summary>
    public partial class DescribeEC2InstanceLimitsResponse : AmazonWebServiceResponse
    {
        private List<EC2InstanceLimit> _ec2InstanceLimits = new List<EC2InstanceLimit>();

        /// <summary>
        /// Gets and sets the property EC2InstanceLimits. 
        /// <para>
        /// The maximum number of instances for the specified instance type.
        /// </para>
        /// </summary>
        public List<EC2InstanceLimit> EC2InstanceLimits
        {
            get { return this._ec2InstanceLimits; }
            set { this._ec2InstanceLimits = value; }
        }

        // Check to see if EC2InstanceLimits property is set
        internal bool IsSetEC2InstanceLimits()
        {
            return this._ec2InstanceLimits != null && this._ec2InstanceLimits.Count > 0; 
        }

    }
}