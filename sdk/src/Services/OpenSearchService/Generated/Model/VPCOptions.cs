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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Options to specify the subnets and security groups for an Amazon OpenSearch Service
    /// VPC endpoint. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/vpc.html">Launching
    /// your Amazon OpenSearch Service domains using a VPC</a>.
    /// </summary>
    public partial class VPCOptions
    {
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _subnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The list of security group IDs associated with the VPC endpoints for the domain. If
        /// you do not provide a security group ID, OpenSearch Service uses the default security
        /// group for the VPC.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet IDs associated with the VPC endpoints for the domain. If your domain
        /// uses multiple Availability Zones, you need to provide two subnet IDs, one per zone.
        /// Otherwise, provide only one.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}