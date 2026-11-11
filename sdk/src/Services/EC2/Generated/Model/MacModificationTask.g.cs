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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about a System Integrity Protection (SIP) modification task or volume
    /// ownership delegation task for an Amazon EC2 Mac instance.
    /// </summary>
    public partial class MacModificationTask
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the Amazon EC2 Mac instance.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MacModificationTaskId. 
        /// <para>
        /// The ID of task.
        /// </para>
        /// </summary>
        public string MacModificationTaskId { get; set; }

        /// <summary>
        /// Checks to see if the MacModificationTaskId property is set.
        /// </summary>
        internal bool IsSetMacModificationTaskId() => this.MacModificationTaskId != null;

        /// <summary>
        /// Gets and sets the property MacSystemIntegrityProtectionConfig. 
        /// <para>
        /// [SIP modification tasks only] Information about the SIP configuration.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionConfiguration MacSystemIntegrityProtectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the MacSystemIntegrityProtectionConfig property is set.
        /// </summary>
        internal bool IsSetMacSystemIntegrityProtectionConfig() => this.MacSystemIntegrityProtectionConfig != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time the task was created, in the UTC timezone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskState. 
        /// <para>
        /// The state of the task.
        /// </para>
        /// </summary>
        public MacModificationTaskState TaskState { get; set; }

        /// <summary>
        /// Checks to see if the TaskState property is set.
        /// </summary>
        internal bool IsSetTaskState() => this.TaskState != null;

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of task.
        /// </para>
        /// </summary>
        public MacModificationTaskType TaskType { get; set; }

        /// <summary>
        /// Checks to see if the TaskType property is set.
        /// </summary>
        internal bool IsSetTaskType() => this.TaskType != null;
    }
}
