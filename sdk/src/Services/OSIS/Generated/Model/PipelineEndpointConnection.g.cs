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
    /// Represents a connection to a pipeline endpoint, containing details about the endpoint
    /// association.
    /// </summary>
    public partial class PipelineEndpointConnection
    {
        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The unique identifier of the endpoint in the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 512)]
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline in the endpoint connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 46, Max = 76)]
        public string PipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineArn property is set.
        /// </summary>
        internal bool IsSetPipelineArn() => this.PipelineArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the pipeline endpoint connection.
        /// </para>
        /// </summary>
        public PipelineEndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointOwner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the VPC endpoint used in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string VpcEndpointOwner { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointOwner property is set.
        /// </summary>
        internal bool IsSetVpcEndpointOwner() => this.VpcEndpointOwner != null;
    }
}
