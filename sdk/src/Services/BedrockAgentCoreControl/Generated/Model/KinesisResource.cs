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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for Kinesis Data Stream delivery.
    /// </summary>
    public partial class KinesisResource
    {
        private List<ContentConfiguration> _contentConfigurations = AWSConfigs.InitializeCollections ? new List<ContentConfiguration>() : null;
        private string _dataStreamArn;

        /// <summary>
        /// Gets and sets the property ContentConfigurations. 
        /// <para>
        /// Content configurations for stream delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<ContentConfiguration> ContentConfigurations
        {
            get { return this._contentConfigurations; }
            set { this._contentConfigurations = value; }
        }

        // Check to see if ContentConfigurations property is set
        internal bool IsSetContentConfigurations()
        {
            return this._contentConfigurations != null && (this._contentConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataStreamArn. 
        /// <para>
        /// ARN of the Kinesis Data Stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataStreamArn
        {
            get { return this._dataStreamArn; }
            set { this._dataStreamArn = value; }
        }

        // Check to see if DataStreamArn property is set
        internal bool IsSetDataStreamArn()
        {
            return this._dataStreamArn != null;
        }

    }
}