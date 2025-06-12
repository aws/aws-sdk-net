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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the BatchPutMessage operation.
    /// Sends messages to a channel.
    /// </summary>
    public partial class BatchPutMessageRequest : AmazonIoTAnalyticsRequest
    {
        private string _channelName;
        private List<Message> _messages = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel where the messages are sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The list of messages to be sent. Each message has the format: { "messageId": "string",
        /// "payload": "string"}.
        /// </para>
        ///  
        /// <para>
        /// The field names of message payloads (data) that you send to IoT Analytics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain only alphanumeric characters and undescores (_). No other special characters
        /// are allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must begin with an alphabetic character or single underscore (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot contain hyphens (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In regular expression terms: "^[A-Za-z_]([A-Za-z0-9]*|[A-Za-z0-9][A-Za-z0-9_]*)$".
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be more than 255 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Are case insensitive. (Fields named foo and FOO in the same payload are considered
        /// duplicates.)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, {"temp_01": 29} or {"_temp_01": 29} are valid, but {"temp-01": 29}, {"01_temp":
        /// 29} or {"__temp_01": 29} are invalid in message payloads. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Message> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}