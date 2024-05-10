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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVpcEndpoints operation.
    /// Describes one or more Amazon OpenSearch Service-managed VPC endpoints.
    /// </summary>
    public partial class DescribeVpcEndpointsRequest : AmazonElasticsearchRequest
    {
        private List<string> _vpcEndpointIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property VpcEndpointIds. 
        /// <para>
        /// The unique identifiers of the endpoints to get information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> VpcEndpointIds
        {
            get { return this._vpcEndpointIds; }
            set { this._vpcEndpointIds = value; }
        }

        // Check to see if VpcEndpointIds property is set
        internal bool IsSetVpcEndpointIds()
        {
            return this._vpcEndpointIds != null && (this._vpcEndpointIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}