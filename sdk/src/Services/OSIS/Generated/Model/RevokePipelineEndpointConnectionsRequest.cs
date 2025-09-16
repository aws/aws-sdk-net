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
    /// Container for the parameters to the RevokePipelineEndpointConnections operation.
    /// Revokes pipeline endpoints from specified endpoint IDs.
    /// </summary>
    public partial class RevokePipelineEndpointConnectionsRequest : AmazonOSISRequest
    {
        private List<string> _endpointIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _pipelineArn;

        /// <summary>
        /// Gets and sets the property EndpointIds. 
        /// <para>
        /// A list of endpoint IDs for which to revoke access to the pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> EndpointIds
        {
            get { return this._endpointIds; }
            set { this._endpointIds = value; }
        }

        // Check to see if EndpointIds property is set
        internal bool IsSetEndpointIds()
        {
            return this._endpointIds != null && (this._endpointIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline from which to revoke endpoint connections.
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

    }
}