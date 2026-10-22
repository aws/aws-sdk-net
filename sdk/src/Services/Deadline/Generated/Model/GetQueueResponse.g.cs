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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the GetQueue operation.
    /// </summary>
    public partial class GetQueueResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowedStorageProfileIds. 
        /// <para>
        /// The storage profile IDs for the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> AllowedStorageProfileIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedStorageProfileIds property is set.
        /// </summary>
        internal bool IsSetAllowedStorageProfileIds() => this.AllowedStorageProfileIds != null && (this.AllowedStorageProfileIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BlockedReason. 
        /// <para>
        /// The reason the queue was blocked.
        /// </para>
        /// </summary>
        public QueueBlockedReason BlockedReason { get; set; }

        /// <summary>
        /// Checks to see if the BlockedReason property is set.
        /// </summary>
        internal bool IsSetBlockedReason() => this.BlockedReason != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user or system that created this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DefaultBudgetAction. 
        /// <para>
        /// The default action taken on a queue if a budget wasn't configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DefaultQueueBudgetAction DefaultBudgetAction { get; set; }

        /// <summary>
        /// Checks to see if the DefaultBudgetAction property is set.
        /// </summary>
        internal bool IsSetDefaultBudgetAction() => this.DefaultBudgetAction != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the queue.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the queue.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID for the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property JobAttachmentSettings. 
        /// <para>
        /// The job attachment settings for the queue.
        /// </para>
        /// </summary>
        public JobAttachmentSettings JobAttachmentSettings { get; set; }

        /// <summary>
        /// Checks to see if the JobAttachmentSettings property is set.
        /// </summary>
        internal bool IsSetJobAttachmentSettings() => this.JobAttachmentSettings != null;

        /// <summary>
        /// Gets and sets the property JobRunAsUser. 
        /// <para>
        /// The jobs in the queue ran as this specified POSIX user.
        /// </para>
        /// </summary>
        public JobRunAsUser JobRunAsUser { get; set; }

        /// <summary>
        /// Checks to see if the JobRunAsUser property is set.
        /// </summary>
        internal bool IsSetJobRunAsUser() => this.JobRunAsUser != null;

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property RequiredFileSystemLocationNames. 
        /// <para>
        /// A list of the required file system location names in the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> RequiredFileSystemLocationNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequiredFileSystemLocationNames property is set.
        /// </summary>
        internal bool IsSetRequiredFileSystemLocationNames() => this.RequiredFileSystemLocationNames != null && (this.RequiredFileSystemLocationNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SchedulingConfiguration. 
        /// <para>
        /// The scheduling configuration for the queue. This configuration determines how workers
        /// are assigned to jobs in the queue.
        /// </para>
        /// </summary>
        public SchedulingConfiguration SchedulingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingConfiguration property is set.
        /// </summary>
        internal bool IsSetSchedulingConfiguration() => this.SchedulingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the queue.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c>–The queue is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCHEDULING</c>–The queue is scheduling.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCHEDULING_BLOCKED</c>–The queue scheduling is blocked. See the provided reason.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueueStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the resource was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user or system that updated this resource.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
