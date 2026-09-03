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
    /// Displays details of the selected bridge.
    /// </summary>
    public partial class ListedBridge
    {
        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  The ARN of the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BridgeArn { get; set; }

        /// <summary>
        /// Checks to see if the BridgeArn property is set.
        /// </summary>
        internal bool IsSetBridgeArn() => this.BridgeArn != null;

        /// <summary>
        /// Gets and sets the property BridgeState. 
        /// <para>
        /// The state of the bridge. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BridgeState BridgeState { get; set; }

        /// <summary>
        /// Checks to see if the BridgeState property is set.
        /// </summary>
        internal bool IsSetBridgeState() => this.BridgeState != null;

        /// <summary>
        /// Gets and sets the property BridgeType. 
        /// <para>
        ///  The type of the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BridgeType { get; set; }

        /// <summary>
        /// Checks to see if the BridgeType property is set.
        /// </summary>
        internal bool IsSetBridgeType() => this.BridgeType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PlacementArn. 
        /// <para>
        ///  The ARN of the gateway associated with the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlacementArn { get; set; }

        /// <summary>
        /// Checks to see if the PlacementArn property is set.
        /// </summary>
        internal bool IsSetPlacementArn() => this.PlacementArn != null;
    }
}
