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
    /// Container for the parameters to the ListGatewayRoutes operation. Returns a list of
    /// gateway routes. A gateway route represents the association between a service and a
    /// gateway and the service-specific infrastructure the gateway manages for it. You can
    /// filter the results by gateway, cluster, service, container port name, and status.
    /// The results are paginated. We recommend that you use pagination to ensure that the
    /// operation returns quickly and successfully.
    /// </summary>
    public partial class ListGatewayRoutesRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of a cluster to filter the results by.
        /// </para>
        /// </summary>
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property Gateway. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of a gateway to filter the results by.
        /// </para>
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// Checks to see if the Gateway property is set.
        /// </summary>
        internal bool IsSetGateway() => this.Gateway != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that the operation returns in a single page. The default
        /// is 100.
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

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of a service to filter the results by. Because
        /// services can span clusters, a service name isn't necessarily unique and can match
        /// multiple services.
        /// </para>
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property ServiceContainerPortName. 
        /// <para>
        /// The name of a task definition container port to filter the results by.
        /// </para>
        /// </summary>
        public string ServiceContainerPortName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceContainerPortName property is set.
        /// </summary>
        internal bool IsSetServiceContainerPortName() => this.ServiceContainerPortName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The gateway route status to filter the results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 7)]
        public List<string> Status { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null && (this.Status.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
