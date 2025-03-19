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
    /// Container for the parameters to the UpdateBridgeSource operation.
    /// Updates an existing bridge source.
    /// </summary>
    public partial class UpdateBridgeSourceRequest : AmazonMediaConnectRequest
    {
        private string _bridgeArn;
        private UpdateBridgeFlowSourceRequest _flowSource;
        private UpdateBridgeNetworkSourceRequest _networkSource;
        private string _sourceName;

        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the bridge that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BridgeArn
        {
            get { return this._bridgeArn; }
            set { this._bridgeArn = value; }
        }

        // Check to see if BridgeArn property is set
        internal bool IsSetBridgeArn()
        {
            return this._bridgeArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlowSource. 
        /// <para>
        ///  The name of the flow that you want to update.
        /// </para>
        /// </summary>
        public UpdateBridgeFlowSourceRequest FlowSource
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
        ///  The network for the bridge source. 
        /// </para>
        /// </summary>
        public UpdateBridgeNetworkSourceRequest NetworkSource
        {
            get { return this._networkSource; }
            set { this._networkSource = value; }
        }

        // Check to see if NetworkSource property is set
        internal bool IsSetNetworkSource()
        {
            return this._networkSource != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        ///  The name of the source that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

    }
}