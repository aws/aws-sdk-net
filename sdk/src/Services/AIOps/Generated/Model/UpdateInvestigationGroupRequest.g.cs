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
    /// Container for the parameters to the UpdateInvestigationGroup operation. Updates the
    /// configuration of the specified investigation group.
    /// </summary>
    public partial class UpdateInvestigationGroupRequest : AmazonAIOpsRequest
    {
        /// <summary>
        /// Gets and sets the property ChatbotNotificationChannel. 
        /// <para>
        /// Use this structure to integrate CloudWatch investigations with chat applications.
        /// This structure is a string array. For the first string, specify the ARN of an Amazon
        /// SNS topic. For the array of strings, specify the ARNs of one or more chat applications
        /// configurations that you want to associate with that topic. For more information about
        /// these configuration ARNs, see <a href="https://docs.aws.amazon.com/chatbot/latest/adminguide/getting-started.html">Getting
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
        /// Gets and sets the property CrossAccountConfigurations. 
        /// <para>
        /// Used to configure cross-account access for an investigation group. It allows the investigation
        /// group to access resources in other accounts. 
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
        /// Use this structure if you want to use a customer managed KMS key to encrypt your investigation
        /// data. If you omit this parameter, CloudWatch investigations will use an Amazon Web
        /// Services key to encrypt the data. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Investigations-Security.html#Investigations-KMS">Encryption
        /// of investigation data</a>.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Specify either the name or the ARN of the investigation group that you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property IsCloudTrailEventHistoryEnabled. 
        /// <para>
        /// Specify <c>true</c> to enable CloudWatch investigations to have access to change events
        /// that are recorded by CloudTrail. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IsCloudTrailEventHistoryEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsCloudTrailEventHistoryEnabled property is set.
        /// </summary>
        internal bool IsSetIsCloudTrailEventHistoryEnabled() => this.IsCloudTrailEventHistoryEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Specify this field if you want to change the IAM role that CloudWatch investigations
        /// will use when it gathers investigation data. To do so, specify the ARN of the new
        /// role.
        /// </para>
        ///  
        /// <para>
        /// The permissions in this role determine which of your resources that CloudWatch investigations
        /// will have access to during investigations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Investigations-Security.html#Investigations-Security-Data">How
        /// to control what data CloudWatch investigations has access to during investigations</a>.
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
        /// Enter the existing custom tag keys for custom applications in your system. Resource
        /// tags help CloudWatch investigations narrow the search space when it is unable to discover
        /// definite relationships between resources. For example, to discover that an Amazon
        /// ECS service depends on an Amazon RDS database, CloudWatch investigations can discover
        /// this relationship using data sources such as X-Ray and CloudWatch Application Signals.
        /// However, if you haven't deployed these features, CloudWatch investigations will attempt
        /// to identify possible relationships. Tag boundaries can be used to narrow the resources
        /// that will be discovered by CloudWatch investigations in these cases.
        /// </para>
        ///  
        /// <para>
        /// You don't need to enter tags created by myApplications or CloudFormation, because
        /// CloudWatch investigations can automatically detect those tags.
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
