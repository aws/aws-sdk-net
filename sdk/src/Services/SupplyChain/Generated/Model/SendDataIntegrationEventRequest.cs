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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Container for the parameters to the SendDataIntegrationEvent operation.
    /// Send the transactional data payload for the event with real-time data for analysis
    /// or monitoring. The real-time data events are stored in an Amazon Web Services service
    /// before being processed and stored in data lake. New data events are synced with data
    /// lake at 5 PM GMT everyday. The updated transactional data is available in data lake
    /// after ingestion.
    /// </summary>
    public partial class SendDataIntegrationEventRequest : AmazonSupplyChainRequest
    {
        private string _clientToken;
        private string _data;
        private string _eventGroupId;
        private DateTime? _eventTimestamp;
        private DataIntegrationEventType _eventType;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotent client token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=126)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data payload of the event. For more information on the data schema to use, see
        /// <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/data-model-asc.html">Data
        /// entities supported in AWS Supply Chain</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1048576)]
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property EventGroupId. 
        /// <para>
        /// Event identifier (for example, orderId for InboundOrder) used for data sharing or
        /// partitioning.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EventGroupId
        {
            get { return this._eventGroupId; }
            set { this._eventGroupId = value; }
        }

        // Check to see if EventGroupId property is set
        internal bool IsSetEventGroupId()
        {
            return this._eventGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// The event timestamp (in epoch seconds).
        /// </para>
        /// </summary>
        public DateTime EventTimestamp
        {
            get { return this._eventTimestamp.GetValueOrDefault(); }
            set { this._eventTimestamp = value; }
        }

        // Check to see if EventTimestamp property is set
        internal bool IsSetEventTimestamp()
        {
            return this._eventTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The data event type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataIntegrationEventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The AWS Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}