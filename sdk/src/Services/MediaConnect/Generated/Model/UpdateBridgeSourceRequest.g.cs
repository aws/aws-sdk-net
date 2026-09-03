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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBridgeSource operation. Updates an existing
    /// bridge source.
    /// </summary>
    public partial class UpdateBridgeSourceRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the bridge that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BridgeArn { get; set; }

        /// <summary>
        /// Checks to see if the BridgeArn property is set.
        /// </summary>
        internal bool IsSetBridgeArn() => this.BridgeArn != null;

        /// <summary>
        /// Gets and sets the property FlowSource. 
        /// <para>
        ///  The name of the flow that you want to update.
        /// </para>
        /// </summary>
        public UpdateBridgeFlowSourceRequest FlowSource { get; set; }

        /// <summary>
        /// Checks to see if the FlowSource property is set.
        /// </summary>
        internal bool IsSetFlowSource() => this.FlowSource != null;

        /// <summary>
        /// Gets and sets the property NetworkSource. 
        /// <para>
        ///  The network for the bridge source. 
        /// </para>
        /// </summary>
        public UpdateBridgeNetworkSourceRequest NetworkSource { get; set; }

        /// <summary>
        /// Checks to see if the NetworkSource property is set.
        /// </summary>
        internal bool IsSetNetworkSource() => this.NetworkSource != null;

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        ///  The name of the source that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceName property is set.
        /// </summary>
        internal bool IsSetSourceName() => this.SourceName != null;
    }
}
