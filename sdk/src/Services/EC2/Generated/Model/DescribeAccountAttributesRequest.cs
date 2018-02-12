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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAccountAttributes operation.
    /// Describes attributes of your AWS account. The following are the supported account
    /// attributes:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>supported-platforms</code>: Indicates whether your account can launch instances
    /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>max-instances</code>: The maximum number of On-Demand Instances that you can
    /// run.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
    /// groups that you can assign to a network interface.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
    /// can allocate for use with EC2-Classic. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
    /// you can allocate for use with EC2-VPC.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeAccountAttributesRequest : AmazonEC2Request
    {
        private List<string> _attributeNames = new List<string>();

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// One or more account attribute names.
        /// </para>
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && this._attributeNames.Count > 0; 
        }

    }
}