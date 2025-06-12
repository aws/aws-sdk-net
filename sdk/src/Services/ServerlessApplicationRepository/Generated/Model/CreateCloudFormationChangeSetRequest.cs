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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
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
namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCloudFormationChangeSet operation.
    /// Creates an AWS CloudFormation change set for the given application.
    /// </summary>
    public partial class CreateCloudFormationChangeSetRequest : AmazonServerlessApplicationRepositoryRequest
    {
        private string _applicationId;
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _changeSetName;
        private string _clientToken;
        private string _description;
        private List<string> _notificationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ParameterValue> _parameterOverrides = AWSConfigs.InitializeCollections ? new List<ParameterValue>() : null;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RollbackConfiguration _rollbackConfiguration;
        private string _semanticVersion;
        private string _stackName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _templateId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// A list of values that you must specify before you can deploy certain applications.
        /// Some applications might include resources that can affect permissions in your AWS
        /// account, for example, by creating new AWS Identity and Access Management (IAM) users.
        /// For those applications, you must explicitly acknowledge their capabilities by specifying
        /// this parameter.
        /// </para>
        /// 
        /// <para>
        /// The only valid values are CAPABILITY_IAM, CAPABILITY_NAMED_IAM, CAPABILITY_RESOURCE_POLICY,
        /// and CAPABILITY_AUTO_EXPAND.
        /// </para>
        /// 
        /// <para>
        /// The following resources require you to specify CAPABILITY_IAM or CAPABILITY_NAMED_IAM:
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">AWS::IAM::Group</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html">AWS::IAM::InstanceProfile</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html">AWS::IAM::Policy</a>,
        /// and <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html">AWS::IAM::Role</a>.
        /// If the application contains IAM resources, you can specify either CAPABILITY_IAM or
        /// CAPABILITY_NAMED_IAM. If the application contains IAM resources with custom names,
        /// you must specify CAPABILITY_NAMED_IAM.
        /// </para>
        /// 
        /// <para>
        /// The following resources require you to specify CAPABILITY_RESOURCE_POLICY: <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-permission.html">AWS::Lambda::Permission</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html">AWS::IAM:Policy</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html">AWS::ApplicationAutoScaling::ScalingPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html">AWS::S3::BucketPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-policy.html">AWS::SQS::QueuePolicy</a>,
        /// and <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-policy.html">AWS::SNS:TopicPolicy</a>.
        /// </para>
        /// 
        /// <para>
        /// Applications that contain one or more nested applications require you to specify CAPABILITY_AUTO_EXPAND.
        /// </para>
        /// 
        /// <para>
        /// If your application template contains any of the above resources, we recommend that
        /// you review all permissions associated with the application before deploying. If you
        /// don't specify this parameter for an application that requires capabilities, the call
        /// will fail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && (this._capabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
        public string ChangeSetName
        {
            get { return this._changeSetName; }
            set { this._changeSetName = value; }
        }

        // Check to see if ChangeSetName property is set
        internal bool IsSetChangeSetName()
        {
            return this._changeSetName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NotificationArns. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotificationArns
        {
            get { return this._notificationArns; }
            set { this._notificationArns = value; }
        }

        // Check to see if NotificationArns property is set
        internal bool IsSetNotificationArns()
        {
            return this._notificationArns != null && (this._notificationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParameterOverrides. 
        /// <para>
        /// A list of parameter values for the parameters of the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterValue> ParameterOverrides
        {
            get { return this._parameterOverrides; }
            set { this._parameterOverrides = value; }
        }

        // Check to see if ParameterOverrides property is set
        internal bool IsSetParameterOverrides()
        {
            return this._parameterOverrides != null && (this._parameterOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RollbackConfiguration. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
        public RollbackConfiguration RollbackConfiguration
        {
            get { return this._rollbackConfiguration; }
            set { this._rollbackConfiguration = value; }
        }

        // Check to see if RollbackConfiguration property is set
        internal bool IsSetRollbackConfiguration()
        {
            return this._rollbackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version of the application:
        /// </para>
        /// 
        /// <para>
        ///  <a href="https://semver.org/">https://semver.org/</a> 
        /// </para>
        /// </summary>
        public string SemanticVersion
        {
            get { return this._semanticVersion; }
            set { this._semanticVersion = value; }
        }

        // Check to see if SemanticVersion property is set
        internal bool IsSetSemanticVersion()
        {
            return this._semanticVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The UUID returned by CreateCloudFormationTemplate.
        /// </para>
        /// 
        /// <para>
        /// Pattern: [0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}
        /// </para>
        /// </summary>
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

    }
}