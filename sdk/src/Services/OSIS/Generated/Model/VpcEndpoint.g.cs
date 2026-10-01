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

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// An OpenSearch Ingestion-managed VPC endpoint that will access one or more pipelines.
    /// </summary>
    public partial class VpcEndpoint
    {
        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The unique identifier of the endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID for your VPC. Amazon Web Services PrivateLink generates this value when you
        /// create a VPC.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property VpcOptions. 
        /// <para>
        /// Information about the VPC, including associated subnets and security groups.
        /// </para>
        /// </summary>
        public VpcOptions VpcOptions { get; set; }

        /// <summary>
        /// Checks to see if the VpcOptions property is set.
        /// </summary>
        internal bool IsSetVpcOptions() => this.VpcOptions != null;
    }
}
