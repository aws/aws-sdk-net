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
    /// Container for the parameters to the UpdateQueue operation.
    /// Updates a queue.
    /// </summary>
    public partial class UpdateQueueRequest : AmazonDeadlineRequest
    {
        private List<string> _allowedStorageProfileIdsToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedStorageProfileIdsToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private DefaultQueueBudgetAction _defaultBudgetAction;
        private string _description;
        private string _displayName;
        private string _farmId;
        private JobAttachmentSettings _jobAttachmentSettings;
        private JobRunAsUser _jobRunAsUser;
        private string _queueId;
        private List<string> _requiredFileSystemLocationNamesToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _requiredFileSystemLocationNamesToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AllowedStorageProfileIdsToAdd. 
        /// <para>
        /// The storage profile IDs to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> AllowedStorageProfileIdsToAdd
        {
            get { return this._allowedStorageProfileIdsToAdd; }
            set { this._allowedStorageProfileIdsToAdd = value; }
        }

        // Check to see if AllowedStorageProfileIdsToAdd property is set
        internal bool IsSetAllowedStorageProfileIdsToAdd()
        {
            return this._allowedStorageProfileIdsToAdd != null && (this._allowedStorageProfileIdsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedStorageProfileIdsToRemove. 
        /// <para>
        /// The storage profile ID to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> AllowedStorageProfileIdsToRemove
        {
            get { return this._allowedStorageProfileIdsToRemove; }
            set { this._allowedStorageProfileIdsToRemove = value; }
        }

        // Check to see if AllowedStorageProfileIdsToRemove property is set
        internal bool IsSetAllowedStorageProfileIdsToRemove()
        {
            return this._allowedStorageProfileIdsToRemove != null && (this._allowedStorageProfileIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token to update in the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultBudgetAction. 
        /// <para>
        /// The default action to take for a queue update if a budget isn't configured.
        /// </para>
        /// </summary>
        public DefaultQueueBudgetAction DefaultBudgetAction
        {
            get { return this._defaultBudgetAction; }
            set { this._defaultBudgetAction = value; }
        }

        // Check to see if DefaultBudgetAction property is set
        internal bool IsSetDefaultBudgetAction()
        {
            return this._defaultBudgetAction != null;
        }

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
        /// The display name of the queue to update.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The farm ID to update in the queue.
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
        /// Gets and sets the property JobAttachmentSettings. 
        /// <para>
        /// The job attachment settings to update for the queue.
        /// </para>
        /// </summary>
        public JobAttachmentSettings JobAttachmentSettings
        {
            get { return this._jobAttachmentSettings; }
            set { this._jobAttachmentSettings = value; }
        }

        // Check to see if JobAttachmentSettings property is set
        internal bool IsSetJobAttachmentSettings()
        {
            return this._jobAttachmentSettings != null;
        }

        /// <summary>
        /// Gets and sets the property JobRunAsUser. 
        /// <para>
        /// Update the jobs in the queue to run as a specified POSIX user.
        /// </para>
        /// </summary>
        public JobRunAsUser JobRunAsUser
        {
            get { return this._jobRunAsUser; }
            set { this._jobRunAsUser = value; }
        }

        // Check to see if JobRunAsUser property is set
        internal bool IsSetJobRunAsUser()
        {
            return this._jobRunAsUser != null;
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredFileSystemLocationNamesToAdd. 
        /// <para>
        /// The required file system location names to add to the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> RequiredFileSystemLocationNamesToAdd
        {
            get { return this._requiredFileSystemLocationNamesToAdd; }
            set { this._requiredFileSystemLocationNamesToAdd = value; }
        }

        // Check to see if RequiredFileSystemLocationNamesToAdd property is set
        internal bool IsSetRequiredFileSystemLocationNamesToAdd()
        {
            return this._requiredFileSystemLocationNamesToAdd != null && (this._requiredFileSystemLocationNamesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequiredFileSystemLocationNamesToRemove. 
        /// <para>
        /// The required file system location names to remove from the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> RequiredFileSystemLocationNamesToRemove
        {
            get { return this._requiredFileSystemLocationNamesToRemove; }
            set { this._requiredFileSystemLocationNamesToRemove = value; }
        }

        // Check to see if RequiredFileSystemLocationNamesToRemove property is set
        internal bool IsSetRequiredFileSystemLocationNamesToRemove()
        {
            return this._requiredFileSystemLocationNamesToRemove != null && (this._requiredFileSystemLocationNamesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN that's used to run jobs from this queue.
        /// </para>
        /// </summary>
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

    }
}