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

#pragma warning disable CS0612,CS0618,CS1570
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
        public new List<string> Equals
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
        /// For CloudTrail management events, supported fields include <c>eventCategory</c> (required),
        /// <c>eventSource</c>, and <c>readOnly</c>.
        /// </para>
        ///  
        /// <para>
        /// For CloudTrail data events, supported fields include <c>eventCategory</c> (required),
        /// <c>resources.type</c> (required), <c>eventName</c>, <c>readOnly</c>, and <c>resources.ARN</c>.
        /// </para>
        ///  
        /// <para>
        /// For CloudTrail network activity events, supported fields include <c>eventCategory</c>
        /// (required), <c>eventSource</c> (required), <c>eventName</c>, <c>errorCode</c>, and
        /// <c>vpcEndpointId</c>.
        /// </para>
        ///  
        /// <para>
        ///  For event data stores for CloudTrail Insights events, Config configuration items,
        /// Audit Manager evidence, or events outside of Amazon Web Services, the only supported
        /// field is <c>eventCategory</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>readOnly</c> </b> - This is an optional field that is only used for management
        /// events and data events. This field can be set to <c>Equals</c> with a value of <c>true</c>
        /// or <c>false</c>. If you do not add this field, CloudTrail logs both <c>read</c> and
        /// <c>write</c> events. A value of <c>true</c> logs only <c>read</c> events. A value
        /// of <c>false</c> logs only <c>write</c> events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>eventSource</c> </b> - This field is only used for management events and network
        /// activity events.
        /// </para>
        ///  
        /// <para>
        /// For management events, this is an optional field that can be set to <c>NotEquals</c>
        /// <c>kms.amazonaws.com</c> to exclude KMS management events, or <c>NotEquals</c> <c>rdsdata.amazonaws.com</c>
        /// to exclude RDS management events.
        /// </para>
        ///  
        /// <para>
        /// For network activity events, this is a required field that only uses the <c>Equals</c>
        /// operator. Set this field to the event source for which you want to log network activity
        /// events. If you want to log network activity events for multiple event sources, you
        /// must create a separate field selector for each event source.
        /// </para>
        ///  
        /// <para>
        /// The following are valid values for network activity events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>cloudtrail.amazonaws.com</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2.amazonaws.com</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kms.amazonaws.com</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>secretsmanager.amazonaws.com</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>eventName</c> </b> - This is an optional field that is only used for data
        /// events and network activity events. You can use any operator with <c>eventName</c>.
        /// You can use it to ﬁlter in or ﬁlter out specific events. You can have multiple values
        /// for this ﬁeld, separated by commas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>eventCategory</c> </b> - This field is required and must be set to <c>Equals</c>.
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
        ///  </li> <li> 
        /// <para>
        ///  For CloudTrail network activity events, the value must be <c>NetworkActivity</c>.
        /// 
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
        ///  <b> <c>errorCode</c> </b> - This ﬁeld is only used to filter CloudTrail network activity
        /// events and is optional. This is the error code to filter on. Currently, the only valid
        /// <c>errorCode</c> is <c>VpceAccessDenied</c>. <c>errorCode</c> can only use the <c>Equals</c>
        /// operator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>resources.type</c> </b> - This ﬁeld is required for CloudTrail data events.
        /// <c>resources.type</c> can only use the <c>Equals</c> operator.
        /// </para>
        ///  
        /// <para>
        /// The value can be one of the following:
        /// </para>
        ///  <ul> <li> 
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
        ///  <c>AWS::Bedrock::FlowAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Bedrock::Guardrail</c> 
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
        ///  <c>AWS::CloudWatch::Metric</c> 
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
        ///  <c>AWS::DynamoDB::Table</c> 
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
        ///  <c>AWS::Kinesis::Stream</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Kinesis::StreamConsumer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::KinesisVideo::Stream</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Lambda::Function</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::MachineLearning::MlModel</c> 
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
        ///  <c>AWS::One::UKey</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::One::User</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::PaymentCryptography::Alias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::PaymentCryptography::Key</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::PCAConnectorAD::Connector</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::PCAConnectorSCEP::Connector</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::QApps:QApp</c> 
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
        ///  <c>AWS::RUM::AppMonitor</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::AccessPoint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::Object</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3Express::Object</c> 
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
        ///  <c>AWS::SQS::Queue</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SSM::ManagedNode</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SSMMessages::ControlChannel</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::StepFunctions::StateMachine</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SWF::Domain</c> 
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
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::XRay::Trace</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  You can have only one <c>resources.type</c> ﬁeld per selector. To log events on more
        /// than one resource type, add another selector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>resources.ARN</c> </b> - The <c>resources.ARN</c> is an optional field for
        /// data events. You can use any operator with <c>resources.ARN</c>, but if you use <c>Equals</c>
        /// or <c>NotEquals</c>, the value must exactly match the ARN of a valid resource of the
        /// type you've speciﬁed in the template as the value of resources.type. To log all data
        /// events for all objects in a specific S3 bucket, use the <c>StartsWith</c> operator,
        /// and include only the bucket ARN as the matching value.
        /// </para>
        ///  
        /// <para>
        /// For information about filtering data events on the <c>resources.ARN</c> field, see
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/filtering-data-events.html#filtering-data-events-resourcearn">Filtering
        /// data events by resources.ARN</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't use the <c>resources.ARN</c> field to filter resource types that do not
        /// have ARNs.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <c>vpcEndpointId</c> </b> - This ﬁeld is only used to filter CloudTrail network
        /// activity events and is optional. This field identifies the VPC endpoint that the request
        /// passed through. You can use any operator with <c>vpcEndpointId</c>.
        /// </para>
        ///  </li> </ul>
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