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
    /// This is the response object from the GetQueue operation.
    /// </summary>
    public partial class GetQueueResponse : AmazonWebServiceResponse
    {
        private List<string> _allowedStorageProfileIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private QueueBlockedReason _blockedReason;
        private DateTime? _createdAt;
        private string _createdBy;
        private DefaultQueueBudgetAction _defaultBudgetAction;
        private string _description;
        private string _displayName;
        private string _farmId;
        private JobAttachmentSettings _jobAttachmentSettings;
        private JobRunAsUser _jobRunAsUser;
        private string _queueId;
        private List<string> _requiredFileSystemLocationNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleArn;
        private QueueStatus _status;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property AllowedStorageProfileIds. 
        /// <para>
        /// The storage profile IDs for the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> AllowedStorageProfileIds
        {
            get { return this._allowedStorageProfileIds; }
            set { this._allowedStorageProfileIds = value; }
        }

        // Check to see if AllowedStorageProfileIds property is set
        internal bool IsSetAllowedStorageProfileIds()
        {
            return this._allowedStorageProfileIds != null && (this._allowedStorageProfileIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BlockedReason. 
        /// <para>
        /// The reason the queue was blocked.
        /// </para>
        /// </summary>
        public QueueBlockedReason BlockedReason
        {
            get { return this._blockedReason; }
            set { this._blockedReason = value; }
        }

        // Check to see if BlockedReason property is set
        internal bool IsSetBlockedReason()
        {
            return this._blockedReason != null;
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
        /// Gets and sets the property DefaultBudgetAction. 
        /// <para>
        /// The default action taken on a queue if a budget wasn't configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The description of the queue.
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
        /// The display name of the queue.
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
        /// The farm ID for the queue.
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
        /// The job attachment settings for the queue.
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
        /// The jobs in the queue ran as this specified POSIX user.
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
        /// The queue ID.
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
        /// Gets and sets the property RequiredFileSystemLocationNames. 
        /// <para>
        /// A list of the required file system location names in the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> RequiredFileSystemLocationNames
        {
            get { return this._requiredFileSystemLocationNames; }
            set { this._requiredFileSystemLocationNames = value; }
        }

        // Check to see if RequiredFileSystemLocationNames property is set
        internal bool IsSetRequiredFileSystemLocationNames()
        {
            return this._requiredFileSystemLocationNames != null && (this._requiredFileSystemLocationNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN.
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
        [AWSProperty(Required=true)]
        public QueueStatus Status
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

    }
}