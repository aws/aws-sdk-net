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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
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
    /// Represents a VPC endpoint for an OpenSearch Ingestion pipeline, enabling private connectivity
    /// between your VPC and the pipeline.
    /// </summary>
    public partial class PipelineEndpoint
    {
        private string _endpointId;
        private string _ingestEndpointUrl;
        private string _pipelineArn;
        private PipelineEndpointStatus _status;
        private string _vpcId;
        private PipelineEndpointVpcOptions _vpcOptions;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The unique identifier for the pipeline endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=512)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property IngestEndpointUrl. 
        /// <para>
        /// The URL used to ingest data to the pipeline through the VPC endpoint.
        /// </para>
        /// </summary>
        public string IngestEndpointUrl
        {
            get { return this._ingestEndpointUrl; }
            set { this._ingestEndpointUrl = value; }
        }

        // Check to see if IngestEndpointUrl property is set
        internal bool IsSetIngestEndpointUrl()
        {
            return this._ingestEndpointUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline associated with this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=46, Max=76)]
        public string PipelineArn
        {
            get { return this._pipelineArn; }
            set { this._pipelineArn = value; }
        }

        // Check to see if PipelineArn property is set
        internal bool IsSetPipelineArn()
        {
            return this._pipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the pipeline endpoint.
        /// </para>
        /// </summary>
        public PipelineEndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC where the pipeline endpoint is created.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcOptions. 
        /// <para>
        /// Configuration options for the VPC endpoint, including subnet and security group settings.
        /// </para>
        /// </summary>
        public PipelineEndpointVpcOptions VpcOptions
        {
            get { return this._vpcOptions; }
            set { this._vpcOptions = value; }
        }

        // Check to see if VpcOptions property is set
        internal bool IsSetVpcOptions()
        {
            return this._vpcOptions != null;
        }

    }
}