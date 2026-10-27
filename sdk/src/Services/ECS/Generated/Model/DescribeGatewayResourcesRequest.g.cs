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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeGatewayResources operation. Returns the
    /// infrastructure that a gateway has created and manages, so that you can follow the
    /// traffic path from top-level shared resources, such as load balancers, to the service-specific
    /// resources represented as gateway routes. Responses include only the Amazon Resource
    /// Names (ARNs) of gateway-managed infrastructure. For the current state of a resource,
    /// describe it with the corresponding Amazon Web Services service (Elastic Load Balancing,
    /// Amazon EC2, or Amazon Web Services Certificate Manager). The results are paginated.
    /// </summary>
    public partial class DescribeGatewayResourcesRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Gateway. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Checks to see if the Gateway property is set.
        /// </summary>
        internal bool IsSetGateway() => this.Gateway != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that the operation returns in a single page. The maximum
        /// value is 20 and the default is 10.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous paginated request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
