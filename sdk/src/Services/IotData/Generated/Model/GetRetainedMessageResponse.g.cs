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

namespace Amazon.IotData.Model
{
    /// <summary>
    /// This is the response object from the GetRetainedMessage operation.
    /// </summary>
    public partial class GetRetainedMessageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The Epoch date and time, in milliseconds, when the retained message was stored by
        /// IoT.
        /// </para>
        /// </summary>
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The Base64-encoded message payload of the retained message body.
        /// </para>
        /// </summary>
        public MemoryStream Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property Qos. 
        /// <para>
        /// The quality of service (QoS) level used to publish the retained message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public int? Qos { get; set; }

        /// <summary>
        /// Checks to see if the Qos property is set.
        /// </summary>
        internal bool IsSetQos() => this.Qos.HasValue;

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The topic name to which the retained message was published.
        /// </para>
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Checks to see if the Topic property is set.
        /// </summary>
        internal bool IsSetTopic() => this.Topic != null;

        /// <summary>
        /// Gets and sets the property UserProperties. 
        /// <para>
        /// A base64-encoded JSON string that includes an array of JSON objects, or null if the
        /// retained message doesn't include any user properties.
        /// </para>
        ///  
        /// <para>
        /// The following example <c>userProperties</c> parameter is a JSON string that represents
        /// two user properties. Note that it will be base64-encoded:
        /// </para>
        ///  
        /// <para>
        ///  <c>[{"deviceName": "alpha"}, {"deviceCnt": "45"}]</c> 
        /// </para>
        /// </summary>
        public MemoryStream UserProperties { get; set; }

        /// <summary>
        /// Checks to see if the UserProperties property is set.
        /// </summary>
        internal bool IsSetUserProperties() => this.UserProperties != null;
    }
}
