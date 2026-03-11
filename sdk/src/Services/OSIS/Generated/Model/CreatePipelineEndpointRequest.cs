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
    /// Container for the parameters to the CreatePipelineEndpoint operation.
    /// Creates a VPC endpoint for an OpenSearch Ingestion pipeline. Pipeline endpoints allow
    /// you to ingest data from your VPC into pipelines that you have access to.
    /// </summary>
    public partial class CreatePipelineEndpointRequest : AmazonOSISRequest
    {
        private string _pipelineArn;
        private PipelineEndpointVpcOptions _vpcOptions;

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline to create the endpoint for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=46, Max=76)]
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
        /// Gets and sets the property VpcOptions. 
        /// <para>
        /// Container for the VPC configuration for the pipeline endpoint, including subnet IDs
        /// and security group IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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