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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
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
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Container for the parameters to the BatchPutMessage operation.
    /// Sends a set of messages to the IoT Events system. Each message payload is transformed
    /// into the input you specify (<c>"inputName"</c>) and ingested into any detectors that
    /// monitor that input. If multiple messages are sent, the order in which the messages
    /// are processed isn't guaranteed. To guarantee ordering, you must send messages one
    /// at a time and wait for a successful response.
    /// </summary>
    public partial class BatchPutMessageRequest : AmazonIoTEventsDataRequest
    {
        private List<Message> _messages = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The list of messages to send. Each message has the following format: <c>'{ "messageId":
        /// "string", "inputName": "string", "payload": "string"}'</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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