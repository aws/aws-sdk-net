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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateRoutingProfileQueues operation. Associates
    /// a set of queues with a routing profile.
    /// </summary>
    public partial class AssociateRoutingProfileQueuesRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ManualAssignmentQueueConfigs. 
        /// <para>
        /// The manual assignment queues to associate with this routing profile.
        /// </para>
        ///  <note> 
        /// <para>
        /// For voice contacts, manual assignment supports only agent-first callback contacts.
        /// Chat, email, and task contacts are fully supported.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<RoutingProfileManualAssignmentQueueConfig> ManualAssignmentQueueConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingProfileManualAssignmentQueueConfig>() : null;

        /// <summary>
        /// Checks to see if the ManualAssignmentQueueConfigs property is set.
        /// </summary>
        internal bool IsSetManualAssignmentQueueConfigs() => this.ManualAssignmentQueueConfigs != null && (this.ManualAssignmentQueueConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueueConfigs. 
        /// <para>
        /// The queues to associate with this routing profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<RoutingProfileQueueConfig> QueueConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingProfileQueueConfig>() : null;

        /// <summary>
        /// Checks to see if the QueueConfigs property is set.
        /// </summary>
        internal bool IsSetQueueConfigs() => this.QueueConfigs != null && (this.QueueConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoutingProfileId. 
        /// <para>
        /// The identifier of the routing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoutingProfileId { get; set; }

        /// <summary>
        /// Checks to see if the RoutingProfileId property is set.
        /// </summary>
        internal bool IsSetRoutingProfileId() => this.RoutingProfileId != null;
    }
}
