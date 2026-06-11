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
    /// Contains information about a subscription for an MQTT client, including the topic
    /// filter and Quality of Service (QoS) level.
    /// </summary>
    public partial class SubscriptionSummary
    {
        private int? _qos;
        private string _topicFilter;

        /// <summary>
        /// Gets and sets the property Qos. 
        /// <para>
        /// The Quality of Service (QoS) level for the subscription. Valid values are 0 (at most
        /// once) and 1 (at least once).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public int? Qos
        {
            get { return this._qos; }
            set { this._qos = value; }
        }

        // Check to see if Qos property is set
        internal bool IsSetQos()
        {
            return this._qos.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicFilter. 
        /// <para>
        /// The topic filter pattern that the client is subscribed to. May include MQTT wildcards
        /// such as + (single-level) and # (multi-level).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TopicFilter
        {
            get { return this._topicFilter; }
            set { this._topicFilter = value; }
        }

        // Check to see if TopicFilter property is set
        internal bool IsSetTopicFilter()
        {
            return this._topicFilter != null;
        }

    }
}