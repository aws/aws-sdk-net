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
    /// Container for the parameters to the CreateInvestigationGroup operation.
    /// Creates an <i>investigation group</i> in your account. Creating an investigation group
    /// is a one-time setup task for each Region in your account. It is a necessary task to
    /// be able to perform investigations.
    /// 
    ///  
    /// <para>
    /// Settings in the investigation group help you centrally manage the common properties
    /// of your investigations, such as the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Who can access the investigations
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether investigation data is encrypted with a customer managed Key Management Service
    /// key.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// How long investigations and their data are retained by default.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Currently, you can have one investigation group in each Region in your account. Each
    /// investigation in a Region is a part of the investigation group in that Region
    /// </para>
    ///  
    /// <para>
    /// To create an investigation group and set up CloudWatch investigations, you must be
    /// signed in to an IAM principal that has either the <c>AIOpsConsoleAdminPolicy</c> or
    /// the <c>AdministratorAccess</c> IAM policy attached, or to an account that has similar
    /// permissions.
    /// </para>
    ///  <important> 
    /// <para>
    /// You can configure CloudWatch alarms to start investigations and add events to investigations.
    /// If you create your investigation group with <c>CreateInvestigationGroup</c> and you
    /// want to enable alarms to do this, you must use <c>PutInvestigationGroupPolicy</c>
    /// to create a resource policy that grants this permission to CloudWatch alarms. 
    /// </para>
    ///  
    /// <para>
    /// For more information about configuring CloudWatch alarms, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html">Using
    /// Amazon CloudWatch alarms</a> 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateInvestigationGroupRequest : AmazonAIOpsRequest
    {
        private Dictionary<string, List<string>> _chatbotNotificationChannel = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private List<CrossAccountConfiguration> _crossAccountConfigurations = AWSConfigs.InitializeCollections ? new List<CrossAccountConfiguration>() : null;
        private EncryptionConfiguration _encryptionConfiguration;
        private bool? _isCloudTrailEventHistoryEnabled;
        private string _name;
        private long? _retentionInDays;
        private string _roleArn;
        private List<string> _tagKeyBoundaries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property CrossAccountConfigurations. 
        /// <para>
        /// List of <c>sourceRoleArn</c> values that have been configured for cross-account access.
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
        /// Use this structure if you want to use a customer managed KMS key to encrypt your investigation
        /// data. If you omit this parameter, CloudWatch investigations will use an Amazon Web
        /// Services key to encrypt the data. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Investigations-Security.html#Investigations-KMS">Encryption
        /// of investigation data</a>.
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
        /// Specify <c>true</c> to enable CloudWatch investigations to have access to change events
        /// that are recorded by CloudTrail. The default is <c>true</c>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Provides a name for the investigation group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// Specify how long that investigation data is kept. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Investigations-Retention.html">Operational
        /// investigation data retention</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the default of 90 days is used.
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
        /// Specify the ARN of the IAM role that CloudWatch investigations will use when it gathers
        /// investigation data. The permissions in this role determine which of your resources
        /// that CloudWatch investigations will have access to during investigations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Investigations-Security.html#Investigations-Security-Data">How
        /// to control what data CloudWatch investigations has access to during investigations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the investigation group. You can associate
        /// as many as 50 tags with an investigation group. To be able to associate tags when
        /// you create the investigation group, you must have the <c>cloudwatch:TagResource</c>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
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