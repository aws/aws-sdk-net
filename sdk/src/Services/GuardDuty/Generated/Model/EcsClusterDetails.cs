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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the details of the ECS Cluster.
    /// </summary>
    public partial class EcsClusterDetails
    {
        private int? _activeServicesCount;
        private string _arn;
        private string _name;
        private int? _registeredContainerInstancesCount;
        private int? _runningTasksCount;
        private string _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private EcsTaskDetails _taskDetails;

        /// <summary>
        /// Gets and sets the property ActiveServicesCount. 
        /// <para>
        /// The number of services that are running on the cluster in an ACTIVE state.
        /// </para>
        /// </summary>
        public int? ActiveServicesCount
        {
            get { return this._activeServicesCount; }
            set { this._activeServicesCount = value; }
        }

        // Check to see if ActiveServicesCount property is set
        internal bool IsSetActiveServicesCount()
        {
            return this._activeServicesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the cluster.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ECS Cluster.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredContainerInstancesCount. 
        /// <para>
        /// The number of container instances registered into the cluster.
        /// </para>
        /// </summary>
        public int? RegisteredContainerInstancesCount
        {
            get { return this._registeredContainerInstancesCount; }
            set { this._registeredContainerInstancesCount = value; }
        }

        // Check to see if RegisteredContainerInstancesCount property is set
        internal bool IsSetRegisteredContainerInstancesCount()
        {
            return this._registeredContainerInstancesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningTasksCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the RUNNING state.
        /// </para>
        /// </summary>
        public int? RunningTasksCount
        {
            get { return this._runningTasksCount; }
            set { this._runningTasksCount = value; }
        }

        // Check to see if RunningTasksCount property is set
        internal bool IsSetRunningTasksCount()
        {
            return this._runningTasksCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ECS cluster.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the ECS Cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskDetails. 
        /// <para>
        /// Contains information about the details of the ECS Task.
        /// </para>
        /// </summary>
        public EcsTaskDetails TaskDetails
        {
            get { return this._taskDetails; }
            set { this._taskDetails = value; }
        }

        // Check to see if TaskDetails property is set
        internal bool IsSetTaskDetails()
        {
            return this._taskDetails != null;
        }

    }
}