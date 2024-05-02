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
    /// Sends message data to an IoT Analytics channel.
    /// </summary>
    public partial class IotAnalyticsAction
    {
        private bool? _batchMode;
        private string _channelArn;
        private string _channelName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property BatchMode. 
        /// <para>
        /// Whether to process the action as a batch. The default value is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// When <c>batchMode</c> is <c>true</c> and the rule SQL statement evaluates to an Array,
        /// each Array element is delivered as a separate message when passed by <a href="https://docs.aws.amazon.com/iotanalytics/latest/APIReference/API_BatchPutMessage.html">
        /// <c>BatchPutMessage</c> </a> to the IoT Analytics channel. The resulting array can't
        /// have more than 100 messages.
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
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// (deprecated) The ARN of the IoT Analytics channel to which message data will be sent.
        /// </para>
        /// </summary>
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the IoT Analytics channel to which message data will be sent.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role which has a policy that grants IoT Analytics permission to send
        /// message data via IoT Analytics (iotanalytics:BatchPutMessage).
        /// </para>
        /// </summary>
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