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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the GetThingConnectivityData operation.
    /// Retrieves the live connectivity status per device. If a device has never connected
    /// to IoT Core or was disconnected for more than 1 hour before fleet indexing's <c>thingConnectivityIndexingMode</c>
    /// was enabled, the response will have the <c>connected</c> field set to <c>false</c>
    /// with no additional session details.
    /// </summary>
    public partial class GetThingConnectivityDataRequest : AmazonIoTRequest
    {
        private bool? _includeSocketInformation;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property IncludeSocketInformation. 
        /// <para>
        /// Specifies if socket information (sourcePort, targetPort, sourceIp, targetIp, vpcEndpointId)
        /// should be included in the GetThingConnectivityData response. Set to <c>true</c> to
        /// include socket information. Set to <c>false</c> to omit socket information. By default,
        /// this is set to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeSocketInformation
        {
            get { return this._includeSocketInformation; }
            set { this._includeSocketInformation = value; }
        }

        // Check to see if IncludeSocketInformation property is set
        internal bool IsSetIncludeSocketInformation()
        {
            return this._includeSocketInformation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of your IoT thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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