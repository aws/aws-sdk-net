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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnectivityInfo operation.
    /// Updates connectivity information for a Greengrass core device.
    /// 
    ///  
    /// <para>
    /// Connectivity information includes endpoints and ports where client devices can connect
    /// to an MQTT broker on the core device. When a client device calls the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-discover-api.html">IoT
    /// Greengrass discovery API</a>, IoT Greengrass returns connectivity information for
    /// all of the core devices where the client device can connect. For more information,
    /// see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/connect-client-devices.html">Connect
    /// client devices to core devices</a> in the <i>IoT Greengrass Version 2 Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateConnectivityInfoRequest : AmazonGreengrassV2Request
    {
        private List<ConnectivityInfo> _connectivityInfo = AWSConfigs.InitializeCollections ? new List<ConnectivityInfo>() : null;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property ConnectivityInfo. 
        /// <para>
        /// The connectivity information for the core device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConnectivityInfo> ConnectivityInfo
        {
            get { return this._connectivityInfo; }
            set { this._connectivityInfo = value; }
        }

        // Check to see if ConnectivityInfo property is set
        internal bool IsSetConnectivityInfo()
        {
            return this._connectivityInfo != null && (this._connectivityInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the core device. This is also the name of the IoT thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}