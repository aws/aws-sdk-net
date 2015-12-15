/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStack operation.
    /// Creates a stack as specified in the template. After the call completes successfully,
    /// the stack creation starts. You can check the status of the stack via the <a>DescribeStacks</a>
    /// API.
    /// </summary>
    public partial class CreateStackRequest : AmazonCloudFormationRequest
    {
        private List<string> _capabilities = new List<string>();
        private bool? _disableRollback;
        private List<string> _notificationARNs = new List<string>();
        private OnFailure _onFailure;
        private List<Parameter> _parameters = new List<Parameter>();
        private List<string> _resourceTypes = new List<string>();
        private string _stackName;
        private string _stackPolicyBody;
        private string _stackPolicyURL;
        private List<Tag> _tags = new List<Tag>();
        private string _templateBody;
        private string _templateURL;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// A list of capabilities that you must specify before AWS CloudFormation can create
        /// or update certain stacks. Some stack templates might include resources that can affect
        /// permissions in your AWS account. For those stacks, you must explicitly acknowledge
        /// their capabilities by specifying this parameter.
        /// </para>
        ///  
        /// <para>
        /// Currently, the only valid value is <code>CAPABILITY_IAM</code>, which is required
        /// for the following resources: <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html">
        /// AWS::IAM::AccessKey</a>, <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">
        /// AWS::IAM::Group</a>, <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html">
        /// AWS::IAM::InstanceProfile</a>, <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html">
        /// AWS::IAM::Policy</a>, <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html">
        /// AWS::IAM::Role</a>, <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html">
        /// AWS::IAM::User</a>, and <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html">
        /// AWS::IAM::UserToGroupAddition</a>. If your stack template contains these resources,
        /// we recommend that you review any permissions associated with them. If you don't specify
        /// this parameter, this action returns an <code>InsufficientCapabilities</code> error.
        /// </para>
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DisableRollback. 
        /// <para>
        /// Set to <code>true</code> to disable rollback of the stack if stack creation failed.
        /// You can specify either <code>DisableRollback</code> or <code>OnFailure</code>, but
        /// not both.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool DisableRollback
        {
            get { return this._disableRollback.GetValueOrDefault(); }
            set { this._disableRollback = value; }
        }

        // Check to see if DisableRollback property is set
        internal bool IsSetDisableRollback()
        {
            return this._disableRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// The Simple Notification Service (SNS) topic ARNs to publish stack related events.
        /// You can find your SNS topic ARNs using the <a href="http://console.aws.amazon.com/sns">SNS
        /// console</a> or your Command Line Interface (CLI).
        /// </para>
        /// </summary>
        public List<string> NotificationARNs
        {
            get { return this._notificationARNs; }
            set { this._notificationARNs = value; }
        }

        // Check to see if NotificationARNs property is set
        internal bool IsSetNotificationARNs()
        {
            return this._notificationARNs != null && this._notificationARNs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OnFailure. 
        /// <para>
        /// Determines what action will be taken if stack creation fails. This must be one of:
        /// DO_NOTHING, ROLLBACK, or DELETE. You can specify either <code>OnFailure</code> or
        /// <code>DisableRollback</code>, but not both.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>ROLLBACK</code>
        /// </para>
        /// </summary>
        public OnFailure OnFailure
        {
            get { return this._onFailure; }
            set { this._onFailure = value; }
        }

        // Check to see if OnFailure property is set
        internal bool IsSetOnFailure()
        {
            return this._onFailure != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <code>Parameter</code> structures that specify input parameters for the
        /// stack.
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The template resource types that you have permissions to work with for this create
        /// stack action, such as <code>AWS::EC2::Instance</code>, <code>AWS::EC2::*</code>, or
        /// <code>Custom::MyCustomInstance</code>. Use the following syntax to describe template
        /// resource types: <code>AWS::*</code> (for all AWS resource), <code>Custom::*</code>
        /// (for all custom resources), <code>Custom::<i>logical_ID</i></code> (for a specific
        /// custom resource), <code>AWS::<i>service_name</i>::*</code> (for all resources of a
        /// particular AWS service), and <code>AWS::<i>service_name</i>::<i>resource_logical_ID</i></code>
        /// (for a specific AWS resource).
        /// </para>
        ///  
        /// <para>
        /// If the list of resource types doesn't include a resource that you're creating, the
        /// stack creation fails. By default, AWS CloudFormation grants permissions to all resource
        /// types. AWS Identity and Access Management (IAM) uses this parameter for AWS CloudFormation-specific
        /// condition keys in IAM policies. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-iam-template.html">Controlling
        /// Access with AWS Identity and Access Management</a>.
        /// </para>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name that is associated with the stack. The name must be unique in the region
        /// in which you are creating the stack.
        /// </para>
        ///  <note>A stack name can contain only alphanumeric characters (case sensitive) and
        /// hyphens. It must start with an alphabetic character and cannot be longer than 255
        /// characters.</note>
        /// </summary>
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
        /// Gets and sets the property StackPolicyBody. 
        /// <para>
        /// Structure containing the stack policy body. For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/protect-stack-resources.html">
        /// Prevent Updates to Stack Resources</a> in the AWS CloudFormation User Guide. You can
        /// specify either the <code>StackPolicyBody</code> or the <code>StackPolicyURL</code>
        /// parameter, but not both.
        /// </para>
        /// </summary>
        public string StackPolicyBody
        {
            get { return this._stackPolicyBody; }
            set { this._stackPolicyBody = value; }
        }

        // Check to see if StackPolicyBody property is set
        internal bool IsSetStackPolicyBody()
        {
            return this._stackPolicyBody != null;
        }

        /// <summary>
        /// Gets and sets the property StackPolicyURL. 
        /// <para>
        /// Location of a file containing the stack policy. The URL must point to a policy (max
        /// size: 16KB) located in an S3 bucket in the same region as the stack. You can specify
        /// either the <code>StackPolicyBody</code> or the <code>StackPolicyURL</code> parameter,
        /// but not both.
        /// </para>
        /// </summary>
        public string StackPolicyURL
        {
            get { return this._stackPolicyURL; }
            set { this._stackPolicyURL = value; }
        }

        // Check to see if StackPolicyURL property is set
        internal bool IsSetStackPolicyURL()
        {
            return this._stackPolicyURL != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of user-defined <code>Tags</code> to associate with this stack, represented
        /// by key/value pairs. Tags defined for the stack are propagated to EC2 resources that
        /// are created as part of the stack. A maximum number of 10 tags can be specified.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// Structure containing the template body with a minimum length of 1 byte and a maximum
        /// length of 51,200 bytes. For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either the <code>TemplateBody</code> or the <code>TemplateURL</code>
        /// parameter, but not both.
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateURL. 
        /// <para>
        /// Location of file containing the template body. The URL must point to a template (max
        /// size: 460,800 bytes) that is located in an Amazon S3 bucket. For more information,
        /// go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either the <code>TemplateBody</code> or the <code>TemplateURL</code>
        /// parameter, but not both.
        /// </para>
        /// </summary>
        public string TemplateURL
        {
            get { return this._templateURL; }
            set { this._templateURL = value; }
        }

        // Check to see if TemplateURL property is set
        internal bool IsSetTemplateURL()
        {
            return this._templateURL != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The amount of time that can pass before the stack status becomes CREATE_FAILED; if
        /// <code>DisableRollback</code> is not set or is set to <code>false</code>, the stack
        /// will be rolled back.
        /// </para>
        /// </summary>
        public int TimeoutInMinutes
        {
            get { return this._timeoutInMinutes.GetValueOrDefault(); }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

    }
}