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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Sends an input to an IoT Events detector.
    /// </summary>
    public partial class IotEventsAction
    {
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
        public bool? BatchMode { get; set; }

        /// <summary>
        /// Checks to see if the BatchMode property is set.
        /// </summary>
        internal bool IsSetBatchMode() => this.BatchMode.HasValue;

        /// <summary>
        /// Gets and sets the property InputName. 
        /// <para>
        /// The name of the IoT Events input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string InputName { get; set; }

        /// <summary>
        /// Checks to see if the InputName property is set.
        /// </summary>
        internal bool IsSetInputName() => this.InputName != null;

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
        [AWSProperty(Min = 0, Max = 128)]
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants IoT permission to send an input to an IoT Events detector.
        /// ("Action":"iotevents:BatchPutMessage").
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
