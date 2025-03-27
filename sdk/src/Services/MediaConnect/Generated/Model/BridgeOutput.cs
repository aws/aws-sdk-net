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
    /// The output of the bridge.
    /// </summary>
    public partial class BridgeOutput
    {
        private BridgeFlowOutput _flowOutput;
        private BridgeNetworkOutput _networkOutput;

        /// <summary>
        /// Gets and sets the property FlowOutput. 
        /// <para>
        ///  The output of the associated flow. 
        /// </para>
        /// </summary>
        public BridgeFlowOutput FlowOutput
        {
            get { return this._flowOutput; }
            set { this._flowOutput = value; }
        }

        // Check to see if FlowOutput property is set
        internal bool IsSetFlowOutput()
        {
            return this._flowOutput != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkOutput. 
        /// <para>
        ///  The network output for the bridge. 
        /// </para>
        /// </summary>
        public BridgeNetworkOutput NetworkOutput
        {
            get { return this._networkOutput; }
            set { this._networkOutput = value; }
        }

        // Check to see if NetworkOutput property is set
        internal bool IsSetNetworkOutput()
        {
            return this._networkOutput != null;
        }

    }
}