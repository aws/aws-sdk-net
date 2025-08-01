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
 * Do not modify this file. This file is generated from the aiops-2018-05-10.normal.json service model.
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
namespace Amazon.AIOps.Model
{
    /// <summary>
    /// This is the response object from the GetInvestigationGroup operation.
    /// </summary>
    public partial class GetInvestigationGroupResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private Dictionary<string, List<string>> _chatbotNotificationChannel = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private long? _createdAt;
        private string _createdBy;
        private List<CrossAccountConfiguration> _crossAccountConfigurations = AWSConfigs.InitializeCollections ? new List<CrossAccountConfiguration>() : null;
        private EncryptionConfiguration _encryptionConfiguration;
        private bool? _isCloudTrailEventHistoryEnabled;
        private long? _lastModifiedAt;
        private string _lastModifiedBy;
        private string _name;
        private long? _retentionInDays;
        private string _roleArn;
        private List<string> _tagKeyBoundaries = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the investigation group.
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
        /// Gets and sets the property ChatbotNotificationChannel. 
        /// <para>
        /// This structure is a string array. The first string is the ARN of a Amazon SNS topic.
        /// The array of strings display the ARNs of chat applications configurations that are
        /// associated with that topic. For more information about these configuration ARNs, see
        /// <a href="https://docs.aws.amazon.com/chatbot/latest/adminguide/getting-started.html">Getting
        /// started with Amazon Q in chat applications</a> and <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awschatbot.html#awschatbot-resources-for-iam-policies">Resource
        /// type defined by Amazon Web Services Chatbot</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> ChatbotNotificationChannel
        {
            get { return this._chatbotNotificationChannel; }
            set { this._chatbotNotificationChannel = value; }
        }

        // Check to see if ChatbotNotificationChannel property is set
        internal bool IsSetChatbotNotificationChannel()
        {
            return this._chatbotNotificationChannel != null && (this._chatbotNotificationChannel.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the investigation group was created.
        /// </para>
        /// </summary>
        public long? CreatedAt
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
        /// The name of the user who created the investigation group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property CrossAccountConfigurations. 
        /// <para>
        /// Lists the <c>AWSAccountId</c> of the accounts configured for cross-account access
        /// and the results of the last scan performed on each account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<CrossAccountConfiguration> CrossAccountConfigurations
        {
            get { return this._crossAccountConfigurations; }
            set { this._crossAccountConfigurations = value; }
        }

        // Check to see if CrossAccountConfigurations property is set
        internal bool IsSetCrossAccountConfigurations()
        {
            return this._crossAccountConfigurations != null && (this._crossAccountConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Specifies the customer managed KMS key that the investigation group uses to encrypt
        /// data, if there is one. If not, the investigation group uses an Amazon Web Services
        /// key to encrypt the data.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IsCloudTrailEventHistoryEnabled. 
        /// <para>
        /// Specifies whether CloudWatch investigationshas access to change events that are recorded
        /// by CloudTrail.
        /// </para>
        /// </summary>
        public bool? IsCloudTrailEventHistoryEnabled
        {
            get { return this._isCloudTrailEventHistoryEnabled; }
            set { this._isCloudTrailEventHistoryEnabled = value; }
        }

        // Check to see if IsCloudTrailEventHistoryEnabled property is set
        internal bool IsSetIsCloudTrailEventHistoryEnabled()
        {
            return this._isCloudTrailEventHistoryEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time that the investigation group was most recently modified.
        /// </para>
        /// </summary>
        public long? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The name of the user who created the investigation group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the investigation group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property RetentionInDays. 
        /// <para>
        /// Specifies how long that investigation data is kept.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=90)]
        public long? RetentionInDays
        {
            get { return this._retentionInDays; }
            set { this._retentionInDays = value; }
        }

        // Check to see if RetentionInDays property is set
        internal bool IsSetRetentionInDays()
        {
            return this._retentionInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that the investigation group uses for permissions to gather
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property TagKeyBoundaries. 
        /// <para>
        /// Displays the custom tag keys for custom applications in your system that you have
        /// specified in the investigation group. Resource tags help CloudWatch investigations
        /// narrow the search space when it is unable to discover definite relationships between
        /// resources. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagKeyBoundaries
        {
            get { return this._tagKeyBoundaries; }
            set { this._tagKeyBoundaries = value; }
        }

        // Check to see if TagKeyBoundaries property is set
        internal bool IsSetTagKeyBoundaries()
        {
            return this._tagKeyBoundaries != null && (this._tagKeyBoundaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}