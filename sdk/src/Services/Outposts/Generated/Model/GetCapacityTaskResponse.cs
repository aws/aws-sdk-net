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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
    /// This is the response object from the GetCapacityTask operation.
    /// </summary>
    public partial class GetCapacityTaskResponse : AmazonWebServiceResponse
    {
        private string _assetId;
        private string _capacityTaskId;
        private CapacityTaskStatus _capacityTaskStatus;
        private DateTime? _completionDate;
        private DateTime? _creationDate;
        private bool? _dryRun;
        private CapacityTaskFailure _failed;
        private InstancesToExclude _instancesToExclude;
        private DateTime? _lastModifiedDate;
        private string _orderId;
        private string _outpostId;
        private List<InstanceTypeCapacity> _requestedInstancePools = AWSConfigs.InitializeCollections ? new List<InstanceTypeCapacity>() : null;
        private TaskActionOnBlockingInstances _taskActionOnBlockingInstances;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the Outpost asset. An Outpost asset can be a single server within an Outposts
        /// rack or an Outposts server configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityTaskId. 
        /// <para>
        /// ID of the capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string CapacityTaskId
        {
            get { return this._capacityTaskId; }
            set { this._capacityTaskId = value; }
        }

        // Check to see if CapacityTaskId property is set
        internal bool IsSetCapacityTaskId()
        {
            return this._capacityTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityTaskStatus. 
        /// <para>
        /// Status of the capacity task.
        /// </para>
        ///  
        /// <para>
        /// A capacity task can have one of the following statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REQUESTED</c> - The capacity task was created and is awaiting the next step by
        /// Amazon Web Services Outposts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - The capacity task is running and cannot be cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The capacity task could not be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The capacity task has completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WAITING_FOR_EVACUATION</c> - The capacity task requires capacity to run. You must
        /// stop the recommended EC2 running instances to free up capacity for the task to run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLATION_IN_PROGRESS</c> - The capacity task has been cancelled and is in
        /// the process of cleaning up resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> - The capacity task is cancelled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityTaskStatus CapacityTaskStatus
        {
            get { return this._capacityTaskStatus; }
            set { this._capacityTaskStatus = value; }
        }

        // Check to see if CapacityTaskStatus property is set
        internal bool IsSetCapacityTaskStatus()
        {
            return this._capacityTaskStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date the capacity task ran successfully.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate
        {
            get { return this._completionDate; }
            set { this._completionDate = value; }
        }

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this._completionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the capacity task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Performs a dry run to determine if you are above or below instance capacity.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// Reason why the capacity task failed.
        /// </para>
        /// </summary>
        public CapacityTaskFailure Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed != null;
        }

        /// <summary>
        /// Gets and sets the property InstancesToExclude. 
        /// <para>
        /// Instances that the user specified they cannot stop in order to free up the capacity
        /// needed to run the capacity task.
        /// </para>
        /// </summary>
        public InstancesToExclude InstancesToExclude
        {
            get { return this._instancesToExclude; }
            set { this._instancesToExclude = value; }
        }

        // Check to see if InstancesToExclude property is set
        internal bool IsSetInstancesToExclude()
        {
            return this._instancesToExclude != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date the capacity task was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrderId. 
        /// <para>
        /// ID of the Amazon Web Services Outposts order associated with the specified capacity
        /// task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string OrderId
        {
            get { return this._orderId; }
            set { this._orderId = value; }
        }

        // Check to see if OrderId property is set
        internal bool IsSetOrderId()
        {
            return this._orderId != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// ID of the Outpost associated with the specified capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=180)]
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedInstancePools. 
        /// <para>
        /// List of instance pools requested in the capacity task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceTypeCapacity> RequestedInstancePools
        {
            get { return this._requestedInstancePools; }
            set { this._requestedInstancePools = value; }
        }

        // Check to see if RequestedInstancePools property is set
        internal bool IsSetRequestedInstancePools()
        {
            return this._requestedInstancePools != null && (this._requestedInstancePools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskActionOnBlockingInstances. 
        /// <para>
        /// User-specified option in case an instance is blocking the capacity task from running.
        /// Shows one of the following options:
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
        public TaskActionOnBlockingInstances TaskActionOnBlockingInstances
        {
            get { return this._taskActionOnBlockingInstances; }
            set { this._taskActionOnBlockingInstances = value; }
        }

        // Check to see if TaskActionOnBlockingInstances property is set
        internal bool IsSetTaskActionOnBlockingInstances()
        {
            return this._taskActionOnBlockingInstances != null;
        }

    }
}