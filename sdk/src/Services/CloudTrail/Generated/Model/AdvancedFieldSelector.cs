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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A single selector statement in an advanced event selector.
    /// </summary>
    public partial class AdvancedFieldSelector
    {
        private List<string> _endsWith = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _equals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _field;
        private List<string> _notEndsWith = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notEquals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notStartsWith = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _startsWith = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EndsWith. 
        /// <para>
        /// An operator that includes events that match the last few characters of the event record
        /// field specified as the value of <c>Field</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> EndsWith
        {
            get { return this._endsWith; }
            set { this._endsWith = value; }
        }

        // Check to see if EndsWith property is set
        internal bool IsSetEndsWith()
        {
            return this._endsWith != null && (this._endsWith.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        ///  An operator that includes events that match the exact value of the event record field
        /// specified as the value of <c>Field</c>. This is the only valid operator that you can
        /// use with the <c>readOnly</c>, <c>eventCategory</c>, and <c>resources.type</c> fields.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Equals
        {
            get { return this._equals; }
            set { this._equals = value; }
        }

        // Check to see if Equals property is set
        internal bool IsSetEquals()
        {
            return this._equals != null && (this._equals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        ///  A field in a CloudTrail event record on which to filter events to be logged. For
        /// event data stores for CloudTrail Insights events, Config configuration items, Audit
        /// Manager evidence, or events outside of Amazon Web Services, the field is used only
        /// for selecting events as filtering is not supported.
        /// </para>
        ///  
        /// <para>
        /// For CloudTrail management events, supported fields include <c>readOnly</c>, <c>eventCategory</c>,
        /// and <c>eventSource</c>.
        /// </para>
        ///  
        /// <para>
        /// For CloudTrail data events, supported fields include <c>readOnly</c>, <c>eventCategory</c>,
        /// <c>eventName</c>, <c>resources.type</c>, and <c>resources.ARN</c>.
        /// </para>
        ///  
        /// <para>
        ///  For event data stores for CloudTrail Insights events, Config configuration items,
        /// Audit Manager evidence, or events outside of Amazon Web Services, the only supported
        /// field is <c>eventCategory</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>readOnly</c> </b> - Optional. Can be set to <c>Equals</c> a value of <c>true</c>
        /// or <c>false</c>. If you do not add this field, CloudTrail logs both <c>read</c> and
        /// <c>write</c> events. A value of <c>true</c> logs only <c>read</c> events. A value
        /// of <c>false</c> logs only <c>write</c> events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>eventSource</c> </b> - For filtering management events only. This can be set
        /// to <c>NotEquals</c> <c>kms.amazonaws.com</c> or <c>NotEquals</c> <c>rdsdata.amazonaws.com</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>eventName</c> </b> - Can use any operator. You can use it to ﬁlter in or ﬁlter
        /// out any data event logged to CloudTrail, such as <c>PutBucket</c> or <c>GetSnapshotBlock</c>.
        /// You can have multiple values for this ﬁeld, separated by commas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>eventCategory</c> </b> - This is required and must be set to <c>Equals</c>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For CloudTrail management events, the value must be <c>Management</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For CloudTrail data events, the value must be <c>Data</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are used only for event data stores:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For CloudTrail Insights events, the value must be <c>Insight</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For Config configuration items, the value must be <c>ConfigurationItem</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For Audit Manager evidence, the value must be <c>Evidence</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For non-Amazon Web Services events, the value must be <c>ActivityAuditLog</c>. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>resources.type</c> </b> - This ﬁeld is required for CloudTrail data events.
        /// <c>resources.type</c> can only use the <c>Equals</c> operator, and the value can be
        /// one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS::DynamoDB::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Lambda::Function</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::Object</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::AppConfig::Configuration</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::B2BI::Transformer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Bedrock::AgentAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Bedrock::KnowledgeBase</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Cassandra::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::CloudFront::KeyValueStore</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::CloudTrail::Channel</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::CodeWhisperer::Customization</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::CodeWhisperer::Profile</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Cognito::IdentityPool</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::DynamoDB::Stream</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::EC2::Snapshot</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::EMRWAL::Workspace</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::FinSpace::Environment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Glue::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::GreengrassV2::ComponentVersion</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::GreengrassV2::Deployment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::GuardDuty::Detector</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::IoT::Certificate</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::IoT::Thing</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::IoTSiteWise::Asset</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::IoTSiteWise::TimeSeries</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::IoTTwinMaker::Entity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::IoTTwinMaker::Workspace</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::KendraRanking::ExecutionPlan</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::KinesisVideo::Stream</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::ManagedBlockchain::Network</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::ManagedBlockchain::Node</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::MedicalImaging::Datastore</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::NeptuneGraph::Graph</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::PCAConnectorAD::Connector</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::QBusiness::Application</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::QBusiness::DataSource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::QBusiness::Index</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::QBusiness::WebExperience</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::RDS::DBCluster</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::AccessPoint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3ObjectLambda::AccessPoint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3Outposts::Object</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SageMaker::Endpoint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SageMaker::ExperimentTrialComponent</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SageMaker::FeatureGroup</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::ServiceDiscovery::Namespace </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::ServiceDiscovery::Service</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SCN::Instance</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SNS::PlatformEndpoint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SNS::Topic</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SWF::Domain</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SQS::Queue</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SSMMessages::ControlChannel</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::ThinClient::Device</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::ThinClient::Environment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Timestream::Database</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Timestream::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::VerifiedPermissions::PolicyStore</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  You can have only one <c>resources.type</c> ﬁeld per selector. To log data events
        /// on more than one resource type, add another selector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>resources.ARN</c> </b> - You can use any operator with <c>resources.ARN</c>,
        /// but if you use <c>Equals</c> or <c>NotEquals</c>, the value must exactly match the
        /// ARN of a valid resource of the type you've speciﬁed in the template as the value of
        /// resources.type. For example, if resources.type equals <c>AWS::S3::Object</c>, the
        /// ARN must be in one of the following formats. To log all data events for all objects
        /// in a specific S3 bucket, use the <c>StartsWith</c> operator, and include only the
        /// bucket ARN as the matching value.
        /// </para>
        ///  
        /// <para>
        /// The trailing slash is intentional; do not exclude it. Replace the text between less
        /// than and greater than symbols (&lt;&gt;) with resource-specific information. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;/</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;/&lt;object_path&gt;/</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::DynamoDB::Table</c>, and the operator is set to
        /// <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:dynamodb:&lt;region&gt;:&lt;account_ID&gt;:table/&lt;table_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::Lambda::Function</c>, and the operator is set to
        /// <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:lambda:&lt;region&gt;:&lt;account_ID&gt;:function:&lt;function_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::AppConfig::Configuration</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:appconfig:&lt;region&gt;:&lt;account_ID&gt;:application/&lt;application_ID&gt;/environment/&lt;environment_ID&gt;/configuration/&lt;configuration_profile_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::B2BI::Transformer</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:b2bi:&lt;region&gt;:&lt;account_ID&gt;:transformer/&lt;transformer_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::Bedrock::AgentAlias</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:bedrock:&lt;region&gt;:&lt;account_ID&gt;:agent-alias/&lt;agent_ID&gt;/&lt;alias_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::Bedrock::KnowledgeBase</c>, and the operator is
        /// set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:bedrock:&lt;region&gt;:&lt;account_ID&gt;:knowledge-base/&lt;knowledge_base_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::Cassandra::Table</c>, and the operator is set to
        /// <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:cassandra:&lt;region&gt;:&lt;account_ID&gt;:/keyspace/&lt;keyspace_name&gt;/table/&lt;table_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::CloudFront::KeyValueStore</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:cloudfront:&lt;region&gt;:&lt;account_ID&gt;:key-value-store/&lt;KVS_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::CloudTrail::Channel</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:cloudtrail:&lt;region&gt;:&lt;account_ID&gt;:channel/&lt;channel_UUID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::CodeWhisperer::Customization</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:codewhisperer:&lt;region&gt;:&lt;account_ID&gt;:customization/&lt;customization_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::CodeWhisperer::Profile</c>, and the operator is
        /// set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:codewhisperer:&lt;region&gt;:&lt;account_ID&gt;:profile/&lt;profile_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::Cognito::IdentityPool</c>, and the operator is
        /// set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:cognito-identity:&lt;region&gt;:&lt;account_ID&gt;:identitypool/&lt;identity_pool_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::DynamoDB::Stream</c>, and the operator is
        /// set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:dynamodb:&lt;region&gt;:&lt;account_ID&gt;:table/&lt;table_name&gt;/stream/&lt;date_time&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::EC2::Snapshot</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:ec2:&lt;region&gt;::snapshot/&lt;snapshot_ID&gt;</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::EMRWAL::Workspace</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:emrwal:&lt;region&gt;:&lt;account_ID&gt;:workspace/&lt;workspace_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::FinSpace::Environment</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:finspace:&lt;region&gt;:&lt;account_ID&gt;:environment/&lt;environment_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::Glue::Table</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:glue:&lt;region&gt;:&lt;account_ID&gt;:table/&lt;database_name&gt;/&lt;table_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::GreengrassV2::ComponentVersion</c>, and
        /// the operator is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:greengrass:&lt;region&gt;:&lt;account_ID&gt;:components/&lt;component_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::GreengrassV2::Deployment</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:greengrass:&lt;region&gt;:&lt;account_ID&gt;:deployments/&lt;deployment_ID</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::GuardDuty::Detector</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:guardduty:&lt;region&gt;:&lt;account_ID&gt;:detector/&lt;detector_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::IoT::Certificate</c>, and the operator is
        /// set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:iot:&lt;region&gt;:&lt;account_ID&gt;:cert/&lt;certificate_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::IoT::Thing</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:iot:&lt;region&gt;:&lt;account_ID&gt;:thing/&lt;thing_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::IoTSiteWise::Asset</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:iotsitewise:&lt;region&gt;:&lt;account_ID&gt;:asset/&lt;asset_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::IoTSiteWise::TimeSeries</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:iotsitewise:&lt;region&gt;:&lt;account_ID&gt;:timeseries/&lt;timeseries_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::IoTTwinMaker::Entity</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:iottwinmaker:&lt;region&gt;:&lt;account_ID&gt;:workspace/&lt;workspace_ID&gt;/entity/&lt;entity_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::IoTTwinMaker::Workspace</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:iottwinmaker:&lt;region&gt;:&lt;account_ID&gt;:workspace/&lt;workspace_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::KendraRanking::ExecutionPlan</c>, and the
        /// operator is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:kendra-ranking:&lt;region&gt;:&lt;account_ID&gt;:rescore-execution-plan/&lt;rescore_execution_plan_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::KinesisVideo::Stream</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:kinesisvideo:&lt;region&gt;:&lt;account_ID&gt;:stream/&lt;stream_name&gt;/&lt;creation_time&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::ManagedBlockchain::Network</c>, and the
        /// operator is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:managedblockchain:::networks/&lt;network_name&gt;</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::ManagedBlockchain::Node</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:managedblockchain:&lt;region&gt;:&lt;account_ID&gt;:nodes/&lt;node_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::MedicalImaging::Datastore</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:medical-imaging:&lt;region&gt;:&lt;account_ID&gt;:datastore/&lt;data_store_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::NeptuneGraph::Graph</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:neptune-graph:&lt;region&gt;:&lt;account_ID&gt;:graph/&lt;graph_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::PCAConnectorAD::Connector</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:pca-connector-ad:&lt;region&gt;:&lt;account_ID&gt;:connector/&lt;connector_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::QBusiness::Application</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:qbusiness:&lt;region&gt;:&lt;account_ID&gt;:application/&lt;application_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::QBusiness::DataSource</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:qbusiness:&lt;region&gt;:&lt;account_ID&gt;:application/&lt;application_ID&gt;/index/&lt;index_ID&gt;/data-source/&lt;datasource_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::QBusiness::Index</c>, and the operator is
        /// set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:qbusiness:&lt;region&gt;:&lt;account_ID&gt;:application/&lt;application_ID&gt;/index/&lt;index_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::QBusiness::WebExperience</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:qbusiness:&lt;region&gt;:&lt;account_ID&gt;:application/&lt;application_ID&gt;/web-experience/&lt;web_experience_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::RDS::DBCluster</c>, and the operator is
        /// set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:rds:&lt;region&gt;:&lt;account_ID&gt;:cluster/&lt;cluster_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::S3::AccessPoint</c>, and the operator is
        /// set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in one of the following
        /// formats. To log events on all objects in an S3 access point, we recommend that you
        /// use only the access point ARN, don’t include the object path, and use the <c>StartsWith</c>
        /// or <c>NotStartsWith</c> operators.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:s3:&lt;region&gt;:&lt;account_ID&gt;:accesspoint/&lt;access_point_name&gt;</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:s3:&lt;region&gt;:&lt;account_ID&gt;:accesspoint/&lt;access_point_name&gt;/object/&lt;object_path&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::S3ObjectLambda::AccessPoint</c>, and the
        /// operator is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:s3-object-lambda:&lt;region&gt;:&lt;account_ID&gt;:accesspoint/&lt;access_point_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::S3Outposts::Object</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:s3-outposts:&lt;region&gt;:&lt;account_ID&gt;:&lt;object_path&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::SageMaker::Endpoint</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:sagemaker:&lt;region&gt;:&lt;account_ID&gt;:endpoint/&lt;endpoint_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::SageMaker::ExperimentTrialComponent</c>,
        /// and the operator is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the
        /// following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:sagemaker:&lt;region&gt;:&lt;account_ID&gt;:experiment-trial-component/&lt;experiment_trial_component_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::SageMaker::FeatureGroup</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:sagemaker:&lt;region&gt;:&lt;account_ID&gt;:feature-group/&lt;feature_group_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::SCN::Instance</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:scn:&lt;region&gt;:&lt;account_ID&gt;:instance/&lt;instance_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::ServiceDiscovery::Namespace</c>, and the
        /// operator is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:servicediscovery:&lt;region&gt;:&lt;account_ID&gt;:namespace/&lt;namespace_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::ServiceDiscovery::Service</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:servicediscovery:&lt;region&gt;:&lt;account_ID&gt;:service/&lt;service_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::SNS::PlatformEndpoint</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:sns:&lt;region&gt;:&lt;account_ID&gt;:endpoint/&lt;endpoint_type&gt;/&lt;endpoint_name&gt;/&lt;endpoint_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::SNS::Topic</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:sns:&lt;region&gt;:&lt;account_ID&gt;:&lt;topic_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::SWF::Domain</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:swf:&lt;region&gt;:&lt;account_ID&gt;:domain/&lt;domain_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::SQS::Queue</c>, and the operator is set
        /// to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:sqs:&lt;region&gt;:&lt;account_ID&gt;:&lt;queue_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::SSMMessages::ControlChannel</c>, and the
        /// operator is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:ssmmessages:&lt;region&gt;:&lt;account_ID&gt;:control-channel/&lt;channel_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::ThinClient::Device</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:thinclient:&lt;region&gt;:&lt;account_ID&gt;:device/&lt;device_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::ThinClient::Environment</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:thinclient:&lt;region&gt;:&lt;account_ID&gt;:environment/&lt;environment_ID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::Timestream::Database</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:timestream:&lt;region&gt;:&lt;account_ID&gt;:database/&lt;database_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>resources.type</c> equals <c>AWS::Timestream::Table</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:timestream:&lt;region&gt;:&lt;account_ID&gt;:database/&lt;database_name&gt;/table/&lt;table_name&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <c>AWS::VerifiedPermissions::PolicyStore</c>, and the operator
        /// is set to <c>Equals</c> or <c>NotEquals</c>, the ARN must be in the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:&lt;partition&gt;:verifiedpermissions:&lt;region&gt;:&lt;account_ID&gt;:policy-store/&lt;policy_store_UUID&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property NotEndsWith. 
        /// <para>
        ///  An operator that excludes events that match the last few characters of the event
        /// record field specified as the value of <c>Field</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotEndsWith
        {
            get { return this._notEndsWith; }
            set { this._notEndsWith = value; }
        }

        // Check to see if NotEndsWith property is set
        internal bool IsSetNotEndsWith()
        {
            return this._notEndsWith != null && (this._notEndsWith.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        ///  An operator that excludes events that match the exact value of the event record field
        /// specified as the value of <c>Field</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotEquals
        {
            get { return this._notEquals; }
            set { this._notEquals = value; }
        }

        // Check to see if NotEquals property is set
        internal bool IsSetNotEquals()
        {
            return this._notEquals != null && (this._notEquals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotStartsWith. 
        /// <para>
        ///  An operator that excludes events that match the first few characters of the event
        /// record field specified as the value of <c>Field</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotStartsWith
        {
            get { return this._notStartsWith; }
            set { this._notStartsWith = value; }
        }

        // Check to see if NotStartsWith property is set
        internal bool IsSetNotStartsWith()
        {
            return this._notStartsWith != null && (this._notStartsWith.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartsWith. 
        /// <para>
        /// An operator that includes events that match the first few characters of the event
        /// record field specified as the value of <c>Field</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> StartsWith
        {
            get { return this._startsWith; }
            set { this._startsWith = value; }
        }

        // Check to see if StartsWith property is set
        internal bool IsSetStartsWith()
        {
            return this._startsWith != null && (this._startsWith.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}