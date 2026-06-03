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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
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
namespace Amazon.IotData.Model
{
    /// <summary>
    /// Container for the parameters to the GetConnection operation.
    /// Retrieves connection information for the specified MQTT client.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetConnection</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class GetConnectionRequest : AmazonIotDataRequest
    {
        private string _clientId;
        private bool? _includeSocketInformation;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier of the MQTT client to retrieve connection information. The client
        /// ID can't start with a dollar sign ($).
        /// </para>
        ///  
        /// <para>
        /// MQTT client IDs must be URL encoded (percent-encoded) when they contain characters
        /// that are not valid in HTTP requests, such as spaces, forward slashes (/), and UTF-8
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeSocketInformation. 
        /// <para>
        /// Specifies if socket information (sourcePort, targetPort, sourceIp, targetIp) should
        /// be included in the GetConnection response. Set to <c>TRUE</c> to include socket information.
        /// Set to <c>FALSE</c> to omit socket information. By default, this is set to <c>FALSE</c>.
        /// See the <a href="https://docs.aws.amazon.com/iot/latest/developerguide/mqtt.html#mqtt-client-disconnect">developer
        /// guide</a> for how to authorize this parameter.
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

    }
}