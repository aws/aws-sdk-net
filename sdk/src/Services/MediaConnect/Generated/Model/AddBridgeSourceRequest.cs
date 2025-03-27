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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// Add an output to a bridge.
    /// </summary>
    public partial class AddBridgeSourceRequest
    {
        private AddBridgeFlowSourceRequest _flowSource;
        private AddBridgeNetworkSourceRequest _networkSource;

        /// <summary>
        /// Gets and sets the property FlowSource. 
        /// <para>
        ///  The source of the flow. 
        /// </para>
        /// </summary>
        public AddBridgeFlowSourceRequest FlowSource
        {
            get { return this._flowSource; }
            set { this._flowSource = value; }
        }

        // Check to see if FlowSource property is set
        internal bool IsSetFlowSource()
        {
            return this._flowSource != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkSource. 
        /// <para>
        ///  The source of the network. 
        /// </para>
        /// </summary>
        public AddBridgeNetworkSourceRequest NetworkSource
        {
            get { return this._networkSource; }
            set { this._networkSource = value; }
        }

        // Check to see if NetworkSource property is set
        internal bool IsSetNetworkSource()
        {
            return this._networkSource != null;
        }

    }
}