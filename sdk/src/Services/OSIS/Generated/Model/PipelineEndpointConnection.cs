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
    /// Represents a connection to a pipeline endpoint, containing details about the endpoint
    /// association.
    /// </summary>
    public partial class PipelineEndpointConnection
    {
        private string _endpointId;
        private string _pipelineArn;
        private PipelineEndpointStatus _status;
        private string _vpcEndpointOwner;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The unique identifier of the endpoint in the connection.
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
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline in the endpoint connection.
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
        /// The current status of the pipeline endpoint connection.
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
        /// Gets and sets the property VpcEndpointOwner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the VPC endpoint used in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string VpcEndpointOwner
        {
            get { return this._vpcEndpointOwner; }
            set { this._vpcEndpointOwner = value; }
        }

        // Check to see if VpcEndpointOwner property is set
        internal bool IsSetVpcEndpointOwner()
        {
            return this._vpcEndpointOwner != null;
        }

    }
}