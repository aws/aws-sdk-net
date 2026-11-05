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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStack operation. Creates a stack as specified
    /// in the template. After the call completes successfully, the stack creation starts.
    /// You can check the status of the stack through the <a>DescribeStacks</a> operation.
    /// <para> For more information about creating a stack and monitoring stack progress,
    /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacks.html">Managing
    /// Amazon Web Services resources as a single unit with CloudFormation stacks</a> in the
    /// <i>CloudFormation User Guide</i>. </para>
    /// </summary>
    public partial class CreateStackRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// In some cases, you must explicitly acknowledge that your stack template contains certain
        /// capabilities in order for CloudFormation to create the stack.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CAPABILITY_IAM</c> and <c>CAPABILITY_NAMED_IAM</c> 
        /// </para>
        ///  
        /// <para>
        /// Some stack templates might include resources that can affect permissions in your Amazon
        /// Web Services account; for example, by creating new IAM users. For those stacks, you
        /// must explicitly acknowledge this by specifying one of these capabilities.
        /// </para>
        ///  
        /// <para>
        /// The following IAM resources require you to specify either the <c>CAPABILITY_IAM</c>
        /// or <c>CAPABILITY_NAMED_IAM</c> capability.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have IAM resources, you can specify either capability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have IAM resources with custom names, you <i>must</i> specify <c>CAPABILITY_NAMED_IAM</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify either of these capabilities, CloudFormation returns an <c>InsufficientCapabilities</c>
        /// error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If your stack template contains these resources, we recommend that you review all
        /// permissions associated with them and edit their permissions if necessary.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-accesskey.html">AWS::IAM::AccessKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-group.html">AWS::IAM::Group</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-instanceprofile.html">AWS::IAM::InstanceProfile</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-managedpolicy.html">
        /// AWS::IAM::ManagedPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-policy.html">AWS::IAM::Policy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-role.html">AWS::IAM::Role</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-user.html">AWS::IAM::User</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-usertogroupaddition.html">AWS::IAM::UserToGroupAddition</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/control-access-with-iam.html#using-iam-capabilities">Acknowledging
        /// IAM resources in CloudFormation templates</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CAPABILITY_AUTO_EXPAND</c> 
        /// </para>
        ///  
        /// <para>
        /// Some template contain macros. Macros perform custom processing on templates; this
        /// can include simple actions like find-and-replace operations, all the way to extensive
        /// transformations of entire templates. Because of this, users typically create a change
        /// set from the processed template, so that they can review the changes resulting from
        /// the macros before actually creating the stack. If your stack template contains one
        /// or more macros, and you choose to create a stack directly from the processed template,
        /// without first reviewing the resulting changes in a change set, you must acknowledge
        /// this capability. This includes the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/transform-aws-include.html">AWS::Include</a>
        /// and <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/transform-aws-serverless.html">AWS::Serverless</a>
        /// transforms, which are macros hosted by CloudFormation.
        /// </para>
        ///  
        /// <para>
        /// If you want to create a stack from a stack template that contains macros <i>and</i>
        /// nested stacks, you must create the stack directly from the template using this capability.
        /// </para>
        ///  <important> 
        /// <para>
        /// You should only create stacks directly from a stack template that contains macros
        /// if you know what processing the macro performs.
        /// </para>
        ///  
        /// <para>
        /// Each macro relies on an underlying Lambda service function for processing stack templates.
        /// Be aware that the Lambda function owner can update the function operation without
        /// CloudFormation being notified.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-macros.html">Perform
        /// custom processing on CloudFormation templates with template macros</a>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Only one of the <c>Capabilities</c> and <c>ResourceType</c> parameters can be specified.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for this <c>CreateStack</c> request. Specify this token if you
        /// plan to retry requests so that CloudFormation knows that you're not attempting to
        /// create a stack with the same name. You might retry <c>CreateStack</c> requests to
        /// ensure that CloudFormation successfully received them.
        /// </para>
        ///  
        /// <para>
        /// All events initiated by a given stack operation are assigned the same client request
        /// token, which you can use to track operations. For example, if you execute a <c>CreateStack</c>
        /// operation with the token <c>token1</c>, then all the <c>StackEvents</c> generated
        /// by that operation will have <c>ClientRequestToken</c> set as <c>token1</c>.
        /// </para>
        ///  
        /// <para>
        /// In the console, stack operations display the client request token on the Events tab.
        /// Stack operations that are initiated from the console use the token format <i>Console-StackOperation-ID</i>,
        /// which helps you easily identify the stack operation . For example, if you create a
        /// stack using the console, each stack event would be assigned the same token in the
        /// following format: <c>Console-CreateStack-7f59c3cf-00d2-40c7-b2ff-e75db0987002</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The deployment configuration for this stack operation, including the deployment mode.
        /// </para>
        /// </summary>
        public DeploymentConfig DeploymentConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfig property is set.
        /// </summary>
        internal bool IsSetDeploymentConfig() => this.DeploymentConfig != null;

        /// <summary>
        /// Gets and sets the property DisableRollback. 
        /// <para>
        /// Set to <c>true</c> to disable rollback of the stack if stack creation failed. You
        /// can specify either <c>DisableRollback</c> or <c>OnFailure</c>, but not both.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// Checks to see if the DisableRollback property is set.
        /// </summary>
        internal bool IsSetDisableRollback() => this.DisableRollback.HasValue;

        /// <summary>
        /// Gets and sets the property DisableValidation. 
        /// <para>
        ///  Set to <c>true</c> to disable pre-deployment validations in changeset or stack operations.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? DisableValidation { get; set; }

        /// <summary>
        /// Checks to see if the DisableValidation property is set.
        /// </summary>
        internal bool IsSetDisableValidation() => this.DisableValidation.HasValue;

        /// <summary>
        /// Gets and sets the property EnableTerminationProtection. 
        /// <para>
        /// Whether to enable termination protection on the specified stack. If a user attempts
        /// to delete a stack with termination protection enabled, the operation fails and the
        /// stack remains unchanged. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protect
        /// CloudFormation stacks from being deleted</a> in the <i>CloudFormation User Guide</i>.
        /// Termination protection is deactivated on stacks by default.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
        /// stacks</a>, termination protection is set on the root stack and can't be changed directly
        /// on the nested stack.
        /// </para>
        /// </summary>
        public bool? EnableTerminationProtection { get; set; }

        /// <summary>
        /// Checks to see if the EnableTerminationProtection property is set.
        /// </summary>
        internal bool IsSetEnableTerminationProtection() => this.EnableTerminationProtection.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// The Amazon SNS topic ARNs to publish stack related events. You can find your Amazon
        /// SNS topic ARNs using the Amazon SNS console or your Command Line Interface (CLI).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> NotificationARNs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotificationARNs property is set.
        /// </summary>
        internal bool IsSetNotificationARNs() => this.NotificationARNs != null && (this.NotificationARNs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OnFailure. 
        /// <para>
        /// Determines what action will be taken if stack creation fails. This must be one of:
        /// <c>DO_NOTHING</c>, <c>ROLLBACK</c>, or <c>DELETE</c>. You can specify either <c>OnFailure</c>
        /// or <c>DisableRollback</c>, but not both.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although the default setting is <c>ROLLBACK</c>, there is one exception. This exception
        /// occurs when a StackSet attempts to deploy a stack instance and the stack instance
        /// fails to create successfully. In this case, the <c>CreateStack</c> call overrides
        /// the default setting and sets the value of <c>OnFailure</c> to <c>DELETE</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>ROLLBACK</c> 
        /// </para>
        /// </summary>
        public OnFailure OnFailure { get; set; }

        /// <summary>
        /// Checks to see if the OnFailure property is set.
        /// </summary>
        internal bool IsSetOnFailure() => this.OnFailure != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <c>Parameter</c> structures that specify input parameters for the stack.
        /// For more information, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_Parameter.html">Parameter</a>
        /// data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// Specifies which resource types you can work with, such as <c>AWS::EC2::Instance</c>
        /// or <c>Custom::MyCustomInstance</c>.
        /// </para>
        ///  
        /// <para>
        /// If the list of resource types doesn't include a resource that you're creating, the
        /// stack creation fails. By default, CloudFormation grants permissions to all resource
        /// types. IAM uses this parameter for CloudFormation-specific condition keys in IAM policies.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/control-access-with-iam.html">Control
        /// CloudFormation access with Identity and Access Management</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only one of the <c>Capabilities</c> and <c>ResourceType</c> parameters can be specified.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property RetainExceptOnCreate. 
        /// <para>
        /// When set to <c>true</c>, newly created resources are deleted when the operation rolls
        /// back. This includes newly created resources marked with a deletion policy of <c>Retain</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? RetainExceptOnCreate { get; set; }

        /// <summary>
        /// Checks to see if the RetainExceptOnCreate property is set.
        /// </summary>
        internal bool IsSetRetainExceptOnCreate() => this.RetainExceptOnCreate.HasValue;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that CloudFormation assumes to create
        /// the stack. CloudFormation uses the role's credentials to make calls on your behalf.
        /// CloudFormation always uses this role for all future operations on the stack. Provided
        /// that users have permission to operate on the stack, CloudFormation uses this role
        /// even if the users don't have permission to pass it. Ensure that the role grants least
        /// privilege.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, CloudFormation uses the role that was previously associated
        /// with the stack. If no role is available, CloudFormation uses a temporary session that's
        /// generated from your user credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property RollbackConfiguration. 
        /// <para>
        /// The rollback triggers for CloudFormation to monitor during stack creation and updating
        /// operations, and for the specified monitoring period afterwards.
        /// </para>
        /// </summary>
        public RollbackConfiguration RollbackConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RollbackConfiguration property is set.
        /// </summary>
        internal bool IsSetRollbackConfiguration() => this.RollbackConfiguration != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name that's associated with the stack. The name must be unique in the Region in
        /// which you are creating the stack.
        /// </para>
        ///  <note> 
        /// <para>
        /// A stack name can contain only alphanumeric characters (case sensitive) and hyphens.
        /// It must start with an alphabetical character and can't be longer than 128 characters.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property StackPolicyBody. 
        /// <para>
        /// Structure that contains the stack policy body. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/protect-stack-resources.html">Prevent
        /// updates to stack resources</a> in the <i>CloudFormation User Guide</i>. You can specify
        /// either the <c>StackPolicyBody</c> or the <c>StackPolicyURL</c> parameter, but not
        /// both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// Checks to see if the StackPolicyBody property is set.
        /// </summary>
        internal bool IsSetStackPolicyBody() => this.StackPolicyBody != null;

        /// <summary>
        /// Gets and sets the property StackPolicyURL. 
        /// <para>
        /// Location of a file that contains the stack policy. The URL must point to a policy
        /// (maximum size: 16 KB) located in an S3 bucket in the same Region as the stack. The
        /// location for an Amazon S3 bucket must start with <c>https://</c>. URLs from S3 static
        /// websites are not supported.
        /// </para>
        ///  
        /// <para>
        /// You can specify either the <c>StackPolicyBody</c> or the <c>StackPolicyURL</c> parameter,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5120)]
        public string StackPolicyURL { get; set; }

        /// <summary>
        /// Checks to see if the StackPolicyURL property is set.
        /// </summary>
        internal bool IsSetStackPolicyURL() => this.StackPolicyURL != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with this stack. CloudFormation also propagates these
        /// tags to the resources created in the stack. A maximum number of 50 tags can be specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// Structure that contains the template body with a minimum length of 1 byte and a maximum
        /// length of 51,200 bytes.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>TemplateBody</c> or <c>TemplateURL</c>, but
        /// not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;

        /// <summary>
        /// Gets and sets the property TemplateURL. 
        /// <para>
        /// The URL of a file that contains the template body. The URL must point to a template
        /// (max size: 1 MB) that's located in an Amazon S3 bucket or a Systems Manager document.
        /// The location for an Amazon S3 bucket must start with <c>https://</c>. URLs from S3
        /// static websites are not supported.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either the <c>TemplateBody</c> or the <c>TemplateURL</c>
        /// parameter, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5120)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// Checks to see if the TemplateURL property is set.
        /// </summary>
        internal bool IsSetTemplateURL() => this.TemplateURL != null;

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The amount of time that can pass before the stack status becomes <c>CREATE_FAILED</c>;
        /// if <c>DisableRollback</c> is not set or is set to <c>false</c>, the stack will be
        /// rolled back.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutInMinutes() => this.TimeoutInMinutes.HasValue;
    }
}
