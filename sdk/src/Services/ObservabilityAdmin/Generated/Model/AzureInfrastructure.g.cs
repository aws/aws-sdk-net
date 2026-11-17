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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// The choices for the Azure infrastructure that the setup creates.
    /// </summary>
    public partial class AzureInfrastructure
    {
        /// <summary>
        /// Gets and sets the property EventHubs. 
        /// <para>
        /// The Event Hubs configuration. Specify exactly one entry, which applies to the Event
        /// Hubs in every Azure Region. This value applies only if an <c>AzureScopeItem</c> collects
        /// <c>ResourceLogs</c>. If you omit it, the setup uses default settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<AzureEventHubConfiguration> EventHubs { get; set; } = AWSConfigs.InitializeCollections ? new List<AzureEventHubConfiguration>() : null;

        /// <summary>
        /// Checks to see if the EventHubs property is set.
        /// </summary>
        internal bool IsSetEventHubs() => this.EventHubs != null && (this.EventHubs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FlowLogs. 
        /// <para>
        /// The location of your Flow Logs. You must specify this value if an <c>AzureScopeItem</c>
        /// collects <c>FlowLogs</c>, and you can specify it only in that case.
        /// </para>
        /// </summary>
        public AzureFlowLogsInfrastructure FlowLogs { get; set; }

        /// <summary>
        /// Checks to see if the FlowLogs property is set.
        /// </summary>
        internal bool IsSetFlowLogs() => this.FlowLogs != null;

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The Azure subscription in which the setup creates the Event Hubs namespaces and, for
        /// <c>AwsManaged</c> Flow Logs, the Storage Accounts. You must specify this value if
        /// an <c>AzureScopeItem</c> collects <c>ResourceLogs</c>, or if you specify <c>EventHubs</c>
        /// or <c>AwsManaged</c> Flow Logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionId() => this.SubscriptionId != null;
    }
}
