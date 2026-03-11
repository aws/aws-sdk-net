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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the GetFleet operation.
    /// </summary>
    public partial class GetFleetResponse : AmazonWebServiceResponse
    {
        private AutoScalingStatus _autoScalingStatus;
        private FleetCapabilities _capabilities;
        private FleetConfiguration _configuration;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _displayName;
        private string _farmId;
        private string _fleetId;
        private HostConfiguration _hostConfiguration;
        private int? _maxWorkerCount;
        private int? _minWorkerCount;
        private string _roleArn;
        private FleetStatus _status;
        private string _statusMessage;
        private int? _targetWorkerCount;
        private DateTime? _updatedAt;
        private string _updatedBy;
        private int? _workerCount;

        /// <summary>
        /// Gets and sets the property AutoScalingStatus. 
        /// <para>
        /// The Auto Scaling status of the fleet. Either <c>GROWING</c>, <c>STEADY</c>, or <c>SHRINKING</c>.
        /// </para>
        /// </summary>
        public AutoScalingStatus AutoScalingStatus
        {
            get { return this._autoScalingStatus; }
            set { this._autoScalingStatus = value; }
        }

        // Check to see if AutoScalingStatus property is set
        internal bool IsSetAutoScalingStatus()
        {
            return this._autoScalingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Outlines what the fleet is capable of for minimums, maximums, and naming, in addition
        /// to attribute names and values.
        /// </para>
        /// </summary>
        public FleetCapabilities Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration setting for the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FleetConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user or system that created this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the fleet.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=100)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the fleet.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the farm in the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The fleet ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property HostConfiguration. 
        /// <para>
        /// The script that runs as a worker is starting up that you can use to provide additional
        /// configuration for workers in your fleet.
        /// </para>
        /// </summary>
        public HostConfiguration HostConfiguration
        {
            get { return this._hostConfiguration; }
            set { this._hostConfiguration = value; }
        }

        // Check to see if HostConfiguration property is set
        internal bool IsSetHostConfiguration()
        {
            return this._hostConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. 
        /// <para>
        /// The maximum number of workers specified in the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? MaxWorkerCount
        {
            get { return this._maxWorkerCount; }
            set { this._maxWorkerCount = value; }
        }

        // Check to see if MaxWorkerCount property is set
        internal bool IsSetMaxWorkerCount()
        {
            return this._maxWorkerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinWorkerCount. 
        /// <para>
        /// The minimum number of workers specified in the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? MinWorkerCount
        {
            get { return this._minWorkerCount; }
            set { this._minWorkerCount = value; }
        }

        // Check to see if MinWorkerCount property is set
        internal bool IsSetMinWorkerCount()
        {
            return this._minWorkerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FleetStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that communicates a suspended status of the fleet.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetWorkerCount. 
        /// <para>
        /// The number of target workers in the fleet.
        /// </para>
        /// </summary>
        public int? TargetWorkerCount
        {
            get { return this._targetWorkerCount; }
            set { this._targetWorkerCount = value; }
        }

        // Check to see if TargetWorkerCount property is set
        internal bool IsSetTargetWorkerCount()
        {
            return this._targetWorkerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the resource was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user or system that updated this resource.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerCount. 
        /// <para>
        /// The number of workers in the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? WorkerCount
        {
            get { return this._workerCount; }
            set { this._workerCount = value; }
        }

        // Check to see if WorkerCount property is set
        internal bool IsSetWorkerCount()
        {
            return this._workerCount.HasValue; 
        }

    }
}