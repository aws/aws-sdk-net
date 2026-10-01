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

namespace Amazon.AIOps.Model
{
    /// <summary>
    /// This is the response object from the GetInvestigationGroup operation.
    /// </summary>
    public partial class GetInvestigationGroupResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the investigation group.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> ChatbotNotificationChannel { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the ChatbotNotificationChannel property is set.
        /// </summary>
        internal bool IsSetChatbotNotificationChannel() => this.ChatbotNotificationChannel != null && (this.ChatbotNotificationChannel.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the investigation group was created.
        /// </para>
        /// </summary>
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The name of the user who created the investigation group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CrossAccountConfigurations. 
        /// <para>
        /// Lists the <c>AWSAccountId</c> of the accounts configured for cross-account access
        /// and the results of the last scan performed on each account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public List<CrossAccountConfiguration> CrossAccountConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<CrossAccountConfiguration>() : null;

        /// <summary>
        /// Checks to see if the CrossAccountConfigurations property is set.
        /// </summary>
        internal bool IsSetCrossAccountConfigurations() => this.CrossAccountConfigurations != null && (this.CrossAccountConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Specifies the customer managed KMS key that the investigation group uses to encrypt
        /// data, if there is one. If not, the investigation group uses an Amazon Web Services
        /// key to encrypt the data.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property IsCloudTrailEventHistoryEnabled. 
        /// <para>
        /// Specifies whether CloudWatch investigationshas access to change events that are recorded
        /// by CloudTrail.
        /// </para>
        /// </summary>
        public bool? IsCloudTrailEventHistoryEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsCloudTrailEventHistoryEnabled property is set.
        /// </summary>
        internal bool IsSetIsCloudTrailEventHistoryEnabled() => this.IsCloudTrailEventHistoryEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time that the investigation group was most recently modified.
        /// </para>
        /// </summary>
        public long? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The name of the user who created the investigation group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the investigation group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RetentionInDays. 
        /// <para>
        /// Specifies how long that investigation data is kept.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 90)]
        public long? RetentionInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionInDays property is set.
        /// </summary>
        internal bool IsSetRetentionInDays() => this.RetentionInDays.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that the investigation group uses for permissions to gather
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TagKeyBoundaries. 
        /// <para>
        /// Displays the custom tag keys for custom applications in your system that you have
        /// specified in the investigation group. Resource tags help CloudWatch investigations
        /// narrow the search space when it is unable to discover definite relationships between
        /// resources. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagKeyBoundaries { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagKeyBoundaries property is set.
        /// </summary>
        internal bool IsSetTagKeyBoundaries() => this.TagKeyBoundaries != null && (this.TagKeyBoundaries.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
