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

namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Container for the parameters to the SendDataIntegrationEvent operation. Send the data
    /// payload for the event with real-time data for analysis or monitoring. The real-time
    /// data events are stored in an Amazon Web Services service before being processed and
    /// stored in data lake.
    /// </summary>
    public partial class SendDataIntegrationEventRequest : AmazonSupplyChainRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotent client token. The token is active for 8 hours, and within its lifetime,
        /// it ensures the request completes only once upon retry with same client token. If omitted,
        /// the AWS SDK generates a unique value so that AWS SDK can safely retry the request
        /// upon network errors.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 126)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data payload of the event, should follow the data schema of the target dataset,
        /// or see <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/data-model-asc.html">Data
        /// entities supported in AWS Supply Chain</a>. To send single data record, use JsonObject
        /// format; to send multiple data records, use JsonArray format.
        /// </para>
        ///  
        /// <para>
        /// Note that for AWS Supply Chain dataset under <b>asc</b> namespace, it has a connection_id
        /// internal field that is not allowed to be provided by client directly, they will be
        /// auto populated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1048576)]
        public string Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property DatasetTarget. 
        /// <para>
        /// The target dataset configuration for <b>scn.data.dataset</b> event type.
        /// </para>
        /// </summary>
        public DataIntegrationEventDatasetTargetConfiguration DatasetTarget { get; set; }

        /// <summary>
        /// Checks to see if the DatasetTarget property is set.
        /// </summary>
        internal bool IsSetDatasetTarget() => this.DatasetTarget != null;

        /// <summary>
        /// Gets and sets the property EventGroupId. 
        /// <para>
        /// Event identifier (for example, orderId for InboundOrder) used for data sharding or
        /// partitioning. Noted under one eventGroupId of same eventType and instanceId, events
        /// are processed sequentially in the order they are received by the server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EventGroupId { get; set; }

        /// <summary>
        /// Checks to see if the EventGroupId property is set.
        /// </summary>
        internal bool IsSetEventGroupId() => this.EventGroupId != null;

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// The timestamp (in epoch seconds) associated with the event. If not provided, it will
        /// be assigned with current timestamp.
        /// </para>
        /// </summary>
        public DateTime? EventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestamp property is set.
        /// </summary>
        internal bool IsSetEventTimestamp() => this.EventTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The data event type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>scn.data.dataset</b> - Send data directly to any specified dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.supplyplan</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/supply-plan-entity.html">supply_plan</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.shipmentstoporder</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/replenishment-shipment-stop-order-entity.html">shipment_stop_order</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.shipmentstop</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/replenishment-shipment-stop-entity.html">shipment_stop</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.shipment</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/replenishment-shipment-entity.html">shipment</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.reservation</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/planning-reservation-entity.html">reservation</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.processproduct</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/operation-process-product-entity.html">process_product</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.processoperation</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/operation-process-operation-entity.html">process_operation</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.processheader</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/operation-process-header-entity.html">process_header</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.forecast</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/forecast-forecast-entity.html">forecast</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.inventorylevel</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/inventory_mgmnt-inv-level-entity.html">inv_level</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.inboundorder</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/replenishment-inbound-order-entity.html">inbound_order</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.inboundorderline</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/replenishment-inbound-order-line-entity.html">inbound_order_line</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.inboundorderlineschedule</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/replenishment-inbound-order-line-schedule-entity.html">inbound_order_line_schedule</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.outboundorderline</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/outbound-fulfillment-order-line-entity.html">outbound_order_line</a>
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>scn.data.outboundshipment</b> - Send data to <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/outbound-fulfillment-shipment-entity.html">outbound_shipment</a>
        /// dataset.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataIntegrationEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The AWS Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;
    }
}
