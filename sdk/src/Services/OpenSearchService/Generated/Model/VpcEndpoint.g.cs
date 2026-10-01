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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The connection endpoint for connecting to an Amazon OpenSearch Service domain through
    /// a proxy.
    /// </summary>
    public partial class VpcEndpoint
    {
        /// <summary>
        /// Gets and sets the property DomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain associated with the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string DomainArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainArn property is set.
        /// </summary>
        internal bool IsSetDomainArn() => this.DomainArn != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint ID for connecting to the domain.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the endpoint.
        /// </para>
        /// </summary>
        public VpcEndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The unique identifier of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 256)]
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointOwner. 
        /// <para>
        /// The creator of the endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointOwner { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointOwner property is set.
        /// </summary>
        internal bool IsSetVpcEndpointOwner() => this.VpcEndpointOwner != null;

        /// <summary>
        /// Gets and sets the property VpcOptions. 
        /// <para>
        /// Options to specify the subnets and security groups for an Amazon OpenSearch Service
        /// VPC endpoint.
        /// </para>
        /// </summary>
        public VPCDerivedInfo VpcOptions { get; set; }

        /// <summary>
        /// Checks to see if the VpcOptions property is set.
        /// </summary>
        internal bool IsSetVpcOptions() => this.VpcOptions != null;
    }
}
