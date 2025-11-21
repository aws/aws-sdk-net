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
    /// Container for the parameters to the DisassociateRoutingProfileQueues operation.
    /// Disassociates a set of queues from a routing profile.
    /// 
    ///  
    /// <para>
    /// Up to 10 queue references can be disassociated in a single API call. More than 10
    /// queue references results in a single call results in an InvalidParameterException.
    /// </para>
    /// </summary>
    public partial class DisassociateRoutingProfileQueuesRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private List<RoutingProfileQueueReference> _manualAssignmentQueueReferences = AWSConfigs.InitializeCollections ? new List<RoutingProfileQueueReference>() : null;
        private List<RoutingProfileQueueReference> _queueReferences = AWSConfigs.InitializeCollections ? new List<RoutingProfileQueueReference>() : null;
        private string _routingProfileId;

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
        /// Gets and sets the property ManualAssignmentQueueReferences. 
        /// <para>
        /// The manual assignment queues to disassociate with this routing profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RoutingProfileQueueReference> ManualAssignmentQueueReferences
        {
            get { return this._manualAssignmentQueueReferences; }
            set { this._manualAssignmentQueueReferences = value; }
        }

        // Check to see if ManualAssignmentQueueReferences property is set
        internal bool IsSetManualAssignmentQueueReferences()
        {
            return this._manualAssignmentQueueReferences != null && (this._manualAssignmentQueueReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueueReferences. 
        /// <para>
        /// The queues to disassociate from this routing profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RoutingProfileQueueReference> QueueReferences
        {
            get { return this._queueReferences; }
            set { this._queueReferences = value; }
        }

        // Check to see if QueueReferences property is set
        internal bool IsSetQueueReferences()
        {
            return this._queueReferences != null && (this._queueReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutingProfileId. 
        /// <para>
        /// The identifier of the routing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoutingProfileId
        {
            get { return this._routingProfileId; }
            set { this._routingProfileId = value; }
        }

        // Check to see if RoutingProfileId property is set
        internal bool IsSetRoutingProfileId()
        {
            return this._routingProfileId != null;
        }

    }
}