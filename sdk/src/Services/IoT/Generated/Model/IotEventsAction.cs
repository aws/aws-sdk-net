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
    /// Sends an input to an IoT Events detector.
    /// </summary>
    public partial class IotEventsAction
    {
        private bool? _batchMode;
        private string _inputName;
        private string _messageId;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property BatchMode. 
        /// <para>
        /// Whether to process the event actions as a batch. The default value is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// When <c>batchMode</c> is <c>true</c>, you can't specify a <c>messageId</c>. 
        /// </para>
        ///  
        /// <para>
        /// When <c>batchMode</c> is <c>true</c> and the rule SQL statement evaluates to an Array,
        /// each Array element is treated as a separate message when it's sent to IoT Events by
        /// calling <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_iotevents-data_BatchPutMessage.html">
        /// <c>BatchPutMessage</c> </a>. The resulting array can't have more than 10 messages.
        /// </para>
        /// </summary>
        public bool? BatchMode
        {
            get { return this._batchMode; }
            set { this._batchMode = value; }
        }

        // Check to see if BatchMode property is set
        internal bool IsSetBatchMode()
        {
            return this._batchMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputName. 
        /// <para>
        /// The name of the IoT Events input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string InputName
        {
            get { return this._inputName; }
            set { this._inputName = value; }
        }

        // Check to see if InputName property is set
        internal bool IsSetInputName()
        {
            return this._inputName != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The ID of the message. The default <c>messageId</c> is a new UUID value.
        /// </para>
        ///  
        /// <para>
        /// When <c>batchMode</c> is <c>true</c>, you can't specify a <c>messageId</c>--a new
        /// UUID value will be assigned.
        /// </para>
        ///  
        /// <para>
        /// Assign a value to this property to ensure that only one input (message) with a given
        /// <c>messageId</c> will be processed by an IoT Events detector.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants IoT permission to send an input to an IoT Events detector.
        /// ("Action":"iotevents:BatchPutMessage").
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}