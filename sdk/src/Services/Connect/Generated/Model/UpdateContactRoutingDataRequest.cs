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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateContactRoutingData operation.
    /// Updates routing priority and age on the contact (<b>QueuePriority</b> and <b>QueueTimeAdjustmentInSeconds</b>).
    /// These properties can be used to change a customer's position in the queue. For example,
    /// you can move a contact to the back of the queue by setting a lower routing priority
    /// relative to other contacts in queue; or you can move a contact to the front of the
    /// queue by increasing the routing age which will make the contact look artificially
    /// older and therefore higher up in the first-in-first-out routing order. Note that adjusting
    /// the routing age of a contact affects only its position in queue, and not its actual
    /// queue wait time as reported through metrics. These properties can also be updated
    /// by using <a href="https://docs.aws.amazon.com/connect/latest/adminguide/change-routing-priority.html">the
    /// Set routing priority / age flow block</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Either <b>QueuePriority</b> or <b>QueueTimeAdjustmentInSeconds</b> should be provided
    /// within the request body, but not both.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateContactRoutingDataRequest : AmazonConnectRequest
    {
        private string _contactId;
        private string _instanceId;
        private long? _queuePriority;
        private int? _queueTimeAdjustmentSeconds;
        private RoutingCriteriaInput _routingCriteria;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Amazon Connect. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property QueuePriority. 
        /// <para>
        /// Priority of the contact in the queue. The default priority for new contacts is 5.
        /// You can raise the priority of a contact compared to other contacts in the queue by
        /// assigning them a higher priority, such as 1 or 2.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=9223372036854775807)]
        public long? QueuePriority
        {
            get { return this._queuePriority; }
            set { this._queuePriority = value; }
        }

        // Check to see if QueuePriority property is set
        internal bool IsSetQueuePriority()
        {
            return this._queuePriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueTimeAdjustmentSeconds. 
        /// <para>
        /// The number of seconds to add or subtract from the contact's routing age. Contacts
        /// are routed to agents on a first-come, first-serve basis. This means that changing
        /// their amount of time in queue compared to others also changes their position in queue.
        /// </para>
        /// </summary>
        public int? QueueTimeAdjustmentSeconds
        {
            get { return this._queueTimeAdjustmentSeconds; }
            set { this._queueTimeAdjustmentSeconds = value; }
        }

        // Check to see if QueueTimeAdjustmentSeconds property is set
        internal bool IsSetQueueTimeAdjustmentSeconds()
        {
            return this._queueTimeAdjustmentSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoutingCriteria. 
        /// <para>
        /// Updates the routing criteria on the contact. These properties can be used to change
        /// how a&#x2028; contact is routed within the queue.
        /// </para>
        /// </summary>
        public RoutingCriteriaInput RoutingCriteria
        {
            get { return this._routingCriteria; }
            set { this._routingCriteria = value; }
        }

        // Check to see if RoutingCriteria property is set
        internal bool IsSetRoutingCriteria()
        {
            return this._routingCriteria != null;
        }

    }
}