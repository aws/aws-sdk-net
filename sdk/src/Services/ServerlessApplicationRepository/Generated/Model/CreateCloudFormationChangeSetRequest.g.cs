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

namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCloudFormationChangeSet operation. Creates
    /// an AWS CloudFormation change set for the given application.
    /// </summary>
    public partial class CreateCloudFormationChangeSetRequest : AmazonServerlessApplicationRepositoryRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
        public string ChangeSetName { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetName property is set.
        /// </summary>
        internal bool IsSetChangeSetName() => this.ChangeSetName != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property NotificationArns. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotificationArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotificationArns property is set.
        /// </summary>
        internal bool IsSetNotificationArns() => this.NotificationArns != null && (this.NotificationArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParameterOverrides. 
        /// <para>
        /// A list of parameter values for the parameters of the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterValue> ParameterOverrides { get; set; } = AWSConfigs.InitializeCollections ? new List<ParameterValue>() : null;

        /// <summary>
        /// Checks to see if the ParameterOverrides property is set.
        /// </summary>
        internal bool IsSetParameterOverrides() => this.ParameterOverrides != null && (this.ParameterOverrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RollbackConfiguration. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
        public RollbackConfiguration RollbackConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RollbackConfiguration property is set.
        /// </summary>
        internal bool IsSetRollbackConfiguration() => this.RollbackConfiguration != null;

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
        public string SemanticVersion { get; set; }

        /// <summary>
        /// Checks to see if the SemanticVersion property is set.
        /// </summary>
        internal bool IsSetSemanticVersion() => this.SemanticVersion != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// This property corresponds to the parameter of the same name for the <i>AWS CloudFormation
        /// <a href="https://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">CreateChangeSet</a>
        /// </i> API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;
    }
}
