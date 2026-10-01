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
    /// This is the response object from the StartCapacityTask operation.
    /// </summary>
    public partial class StartCapacityTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset. An Outpost asset can be a single server within an Outposts rack
        /// or an Outposts server configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property CapacityTaskId. 
        /// <para>
        /// ID of the capacity task that you want to start.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string CapacityTaskId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityTaskId property is set.
        /// </summary>
        internal bool IsSetCapacityTaskId() => this.CapacityTaskId != null;

        /// <summary>
        /// Gets and sets the property CapacityTaskStatus. 
        /// <para>
        /// Status of the specified capacity task.
        /// </para>
        /// </summary>
        public CapacityTaskStatus CapacityTaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the CapacityTaskStatus property is set.
        /// </summary>
        internal bool IsSetCapacityTaskStatus() => this.CapacityTaskStatus != null;

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// Date that the specified capacity task ran successfully.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDate property is set.
        /// </summary>
        internal bool IsSetCompletionDate() => this.CompletionDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// Date that the specified capacity task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Results of the dry run showing if the specified capacity task is above or below the
        /// available instance capacity.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// Reason that the specified capacity task failed.
        /// </para>
        /// </summary>
        public CapacityTaskFailure Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed != null;

        /// <summary>
        /// Gets and sets the property InstancesToExclude. 
        /// <para>
        /// User-specified instances that must not be stopped in order to free up the capacity
        /// needed to run the capacity task.
        /// </para>
        /// </summary>
        public InstancesToExclude InstancesToExclude { get; set; }

        /// <summary>
        /// Checks to see if the InstancesToExclude property is set.
        /// </summary>
        internal bool IsSetInstancesToExclude() => this.InstancesToExclude != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Date that the specified capacity task was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property OrderId. 
        /// <para>
        /// ID of the Amazon Web Services Outposts order of the host associated with the capacity
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
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// ID of the Outpost associated with the capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 180)]
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property RequestedInstancePools. 
        /// <para>
        /// List of the instance pools requested in the specified capacity task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceTypeCapacity> RequestedInstancePools { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceTypeCapacity>() : null;

        /// <summary>
        /// Checks to see if the RequestedInstancePools property is set.
        /// </summary>
        internal bool IsSetRequestedInstancePools() => this.RequestedInstancePools != null && (this.RequestedInstancePools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskActionOnBlockingInstances. 
        /// <para>
        /// User-specified option in case an instance is blocking the capacity task from running.
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
