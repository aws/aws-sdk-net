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
    /// Container for the parameters to the CreateQueue operation.
    /// Creates a queue to coordinate the order in which jobs run on a farm. A queue can also
    /// specify where to pull resources and indicate where to output completed jobs.
    /// </summary>
    public partial class CreateQueueRequest : AmazonDeadlineRequest
    {
        private List<string> _allowedStorageProfileIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private DefaultQueueBudgetAction _defaultBudgetAction;
        private string _description;
        private string _displayName;
        private string _farmId;
        private JobAttachmentSettings _jobAttachmentSettings;
        private JobRunAsUser _jobRunAsUser;
        private List<string> _requiredFileSystemLocationNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedStorageProfileIds. 
        /// <para>
        /// The storage profile IDs to include in the queue.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The unique token which the server uses to recognize retries of the same request.
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
        /// The default action to take on a queue if a budget isn't configured.
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
        /// The farm ID of the farm to connect to the queue.
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
        /// The job attachment settings for the queue. These are the Amazon S3 bucket name and
        /// the Amazon S3 prefix.
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
        /// The jobs in the queue run as the specified POSIX user.
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
        /// Gets and sets the property RequiredFileSystemLocationNames. 
        /// <para>
        /// The file system location name to include in the queue.
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
        /// The IAM role ARN that workers will use while running jobs for this queue.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a tag key and a tag value. Tag keys and values are both required,
        /// but tag values can be empty strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}