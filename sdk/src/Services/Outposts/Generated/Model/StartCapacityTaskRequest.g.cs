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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the StartCapacityTask operation. Starts the specified
    /// capacity task. You can have one active capacity task for each order and each Outpost.
    /// </summary>
    public partial class StartCapacityTaskRequest : AmazonOutpostsRequest
    {
        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the Outpost asset. An Outpost asset can be a single server within an Outposts
        /// rack or an Outposts server configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// You can request a dry run to determine if the instance type and instance size changes
        /// is above or below available instance capacity. Requesting a dry run does not make
        /// any changes to your plan.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InstancePools. 
        /// <para>
        /// The instance pools specified in the capacity task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<InstanceTypeCapacity> InstancePools { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceTypeCapacity>() : null;

        /// <summary>
        /// Checks to see if the InstancePools property is set.
        /// </summary>
        internal bool IsSetInstancePools() => this.InstancePools != null && (this.InstancePools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstancesToExclude. 
        /// <para>
        /// List of user-specified running instances that must not be stopped in order to free
        /// up the capacity needed to run the capacity task.
        /// </para>
        /// </summary>
        public InstancesToExclude InstancesToExclude { get; set; }

        /// <summary>
        /// Checks to see if the InstancesToExclude property is set.
        /// </summary>
        internal bool IsSetInstancesToExclude() => this.InstancesToExclude != null;

        /// <summary>
        /// Gets and sets the property OrderId. 
        /// <para>
        /// The ID of the Amazon Web Services Outposts order associated with the specified capacity
        /// task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string OrderId { get; set; }

        /// <summary>
        /// Checks to see if the OrderId property is set.
        /// </summary>
        internal bool IsSetOrderId() => this.OrderId != null;

        /// <summary>
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// The ID or ARN of the Outposts associated with the specified capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 180)]
        public string OutpostIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OutpostIdentifier property is set.
        /// </summary>
        internal bool IsSetOutpostIdentifier() => this.OutpostIdentifier != null;

        /// <summary>
        /// Gets and sets the property TaskActionOnBlockingInstances. 
        /// <para>
        /// Specify one of the following options in case an instance is blocking the capacity
        /// task from running.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>WAIT_FOR_EVACUATION</c> - Checks every 10 minutes over 48 hours to determine if
        /// instances have stopped and capacity is available to complete the task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAIL_TASK</c> - The capacity task fails.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TaskActionOnBlockingInstances TaskActionOnBlockingInstances { get; set; }

        /// <summary>
        /// Checks to see if the TaskActionOnBlockingInstances property is set.
        /// </summary>
        internal bool IsSetTaskActionOnBlockingInstances() => this.TaskActionOnBlockingInstances != null;
    }
}
