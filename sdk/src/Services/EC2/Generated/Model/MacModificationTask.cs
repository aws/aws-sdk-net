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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about a System Integrity Protection (SIP) modification task or volume
    /// ownership delegation task for an Amazon EC2 Mac instance.
    /// </summary>
    public partial class MacModificationTask
    {
        private string _instanceId;
        private string _macModificationTaskId;
        private MacSystemIntegrityProtectionConfiguration _macSystemIntegrityProtectionConfig;
        private DateTime? _startTime;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private MacModificationTaskState _taskState;
        private MacModificationTaskType _taskType;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the Amazon EC2 Mac instance.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MacModificationTaskId. 
        /// <para>
        /// The ID of task.
        /// </para>
        /// </summary>
        public string MacModificationTaskId
        {
            get { return this._macModificationTaskId; }
            set { this._macModificationTaskId = value; }
        }

        // Check to see if MacModificationTaskId property is set
        internal bool IsSetMacModificationTaskId()
        {
            return this._macModificationTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property MacSystemIntegrityProtectionConfig. 
        /// <para>
        /// [SIP modification tasks only] Information about the SIP configuration.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionConfiguration MacSystemIntegrityProtectionConfig
        {
            get { return this._macSystemIntegrityProtectionConfig; }
            set { this._macSystemIntegrityProtectionConfig = value; }
        }

        // Check to see if MacSystemIntegrityProtectionConfig property is set
        internal bool IsSetMacSystemIntegrityProtectionConfig()
        {
            return this._macSystemIntegrityProtectionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time the task was created, in the UTC timezone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the task.
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
        /// Gets and sets the property TaskState. 
        /// <para>
        /// The state of the task.
        /// </para>
        /// </summary>
        public MacModificationTaskState TaskState
        {
            get { return this._taskState; }
            set { this._taskState = value; }
        }

        // Check to see if TaskState property is set
        internal bool IsSetTaskState()
        {
            return this._taskState != null;
        }

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of task.
        /// </para>
        /// </summary>
        public MacModificationTaskType TaskType
        {
            get { return this._taskType; }
            set { this._taskType = value; }
        }

        // Check to see if TaskType property is set
        internal bool IsSetTaskType()
        {
            return this._taskType != null;
        }

    }
}