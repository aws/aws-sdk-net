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
    /// Container for the parameters to the UpdateQueue operation. Updates a queue.
    /// </summary>
    public partial class UpdateQueueRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedStorageProfileIdsToAdd. The storage profile IDs
        /// to add.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> AllowedStorageProfileIdsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedStorageProfileIdsToAdd property is set.
        /// </summary>
        internal bool IsSetAllowedStorageProfileIdsToAdd() => this.AllowedStorageProfileIdsToAdd != null && (this.AllowedStorageProfileIdsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedStorageProfileIdsToRemove. The storage profile ID
        /// to remove.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> AllowedStorageProfileIdsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedStorageProfileIdsToRemove property is set.
        /// </summary>
        internal bool IsSetAllowedStorageProfileIdsToRemove() => this.AllowedStorageProfileIdsToRemove != null && (this.AllowedStorageProfileIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. The idempotency token to update in the queue.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DefaultBudgetAction. The default action to take for a queue
        /// update if a budget isn't configured.
        /// </summary>
        public DefaultQueueBudgetAction DefaultBudgetAction { get; set; }

        /// <summary>
        /// Checks to see if the DefaultBudgetAction property is set.
        /// </summary>
        internal bool IsSetDefaultBudgetAction() => this.DefaultBudgetAction != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the queue to update.
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
        /// The display name of the queue to update.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID to update in the queue.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property JobAttachmentSettings. The job attachment settings to update
        /// for the queue.
        /// </summary>
        public JobAttachmentSettings JobAttachmentSettings { get; set; }

        /// <summary>
        /// Checks to see if the JobAttachmentSettings property is set.
        /// </summary>
        internal bool IsSetJobAttachmentSettings() => this.JobAttachmentSettings != null;

        /// <summary>
        /// Gets and sets the property JobRunAsUser. Update the jobs in the queue to run as a
        /// specified POSIX user.
        /// </summary>
        public JobRunAsUser JobRunAsUser { get; set; }

        /// <summary>
        /// Checks to see if the JobRunAsUser property is set.
        /// </summary>
        internal bool IsSetJobRunAsUser() => this.JobRunAsUser != null;

        /// <summary>
        /// Gets and sets the property QueueId. The queue ID to update.
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property RequiredFileSystemLocationNamesToAdd. The required file
        /// system location names to add to the queue.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> RequiredFileSystemLocationNamesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequiredFileSystemLocationNamesToAdd property is set.
        /// </summary>
        internal bool IsSetRequiredFileSystemLocationNamesToAdd() => this.RequiredFileSystemLocationNamesToAdd != null && (this.RequiredFileSystemLocationNamesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequiredFileSystemLocationNamesToRemove. The required file
        /// system location names to remove from the queue.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> RequiredFileSystemLocationNamesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequiredFileSystemLocationNamesToRemove property is set.
        /// </summary>
        internal bool IsSetRequiredFileSystemLocationNamesToRemove() => this.RequiredFileSystemLocationNamesToRemove != null && (this.RequiredFileSystemLocationNamesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. The IAM role ARN that's used to run jobs from
        /// this queue.
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SchedulingConfiguration. The scheduling configuration for
        /// the queue. This configuration determines how workers are assigned to jobs in the queue.
        /// When updating the scheduling configuration, the entire configuration is replaced.
        /// In-progress tasks run to completion before the new scheduling configuration takes
        /// effect.
        /// </summary>
        public SchedulingConfiguration SchedulingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingConfiguration property is set.
        /// </summary>
        internal bool IsSetSchedulingConfiguration() => this.SchedulingConfiguration != null;
    }
}
