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
    /// The bridge's source.
    /// </summary>
    public partial class BridgeSource
    {
        /// <summary>
        /// Gets and sets the property FlowSource. 
        /// <para>
        ///  The source of the associated flow. 
        /// </para>
        /// </summary>
        public BridgeFlowSource FlowSource { get; set; }

        /// <summary>
        /// Checks to see if the FlowSource property is set.
        /// </summary>
        internal bool IsSetFlowSource() => this.FlowSource != null;

        /// <summary>
        /// Gets and sets the property NetworkSource. 
        /// <para>
        ///  The network source for the bridge. 
        /// </para>
        /// </summary>
        public BridgeNetworkSource NetworkSource { get; set; }

        /// <summary>
        /// Checks to see if the NetworkSource property is set.
        /// </summary>
        internal bool IsSetNetworkSource() => this.NetworkSource != null;
    }
}
