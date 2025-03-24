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
    /// Displays details of the selected bridge.
    /// </summary>
    public partial class ListedBridge
    {
        private string _bridgeArn;
        private BridgeState _bridgeState;
        private string _bridgeType;
        private string _name;
        private string _placementArn;

        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  The ARN of the bridge.
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
        /// Gets and sets the property BridgeState. 
        /// <para>
        /// The state of the bridge. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BridgeState BridgeState
        {
            get { return this._bridgeState; }
            set { this._bridgeState = value; }
        }

        // Check to see if BridgeState property is set
        internal bool IsSetBridgeState()
        {
            return this._bridgeState != null;
        }

        /// <summary>
        /// Gets and sets the property BridgeType. 
        /// <para>
        ///  The type of the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BridgeType
        {
            get { return this._bridgeType; }
            set { this._bridgeType = value; }
        }

        // Check to see if BridgeType property is set
        internal bool IsSetBridgeType()
        {
            return this._bridgeType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementArn. 
        /// <para>
        ///  The ARN of the gateway associated with the bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlacementArn
        {
            get { return this._placementArn; }
            set { this._placementArn = value; }
        }

        // Check to see if PlacementArn property is set
        internal bool IsSetPlacementArn()
        {
            return this._placementArn != null;
        }

    }
}