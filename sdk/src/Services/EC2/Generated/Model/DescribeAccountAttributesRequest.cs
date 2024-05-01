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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAccountAttributes operation.
    /// Describes attributes of your Amazon Web Services account. The following are the supported
    /// account attributes:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>default-vpc</c>: The ID of the default VPC for your account, or <c>none</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>max-instances</c>: This attribute is no longer supported. The returned value does
    /// not reflect your actual vCPU limit for running On-Demand Instances. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-on-demand-instances.html#ec2-on-demand-instances-limits">On-Demand
    /// Instance Limits</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>max-elastic-ips</c>: The maximum number of Elastic IP addresses that you can allocate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>supported-platforms</c>: This attribute is deprecated.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>vpc-max-elastic-ips</c>: The maximum number of Elastic IP addresses that you can
    /// allocate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>vpc-max-security-groups-per-interface</c>: The maximum number of security groups
    /// that you can assign to a network interface.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeAccountAttributesRequest : AmazonEC2Request
    {
        private List<string> _attributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// The account attribute names.
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
            return this._attributeNames != null && (this._attributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}