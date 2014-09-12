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
        /// The list of capabilities that you want to allow in the stack. If your template contains
        /// certain resources, you must specify the CAPABILITY_IAM value for this parameter; otherwise,
        /// this action returns an InsufficientCapabilities error. The following resources require
        /// you to specify the capabilities parameter: <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stack.html">AWS::CloudFormation::Stack</a>,
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html">AWS::IAM::AccessKey</a>,
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">AWS::IAM::Group</a>,
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html">AWS::IAM::InstanceProfile</a>,
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html">AWS::IAM::Policy</a>,
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html">AWS::IAM::Role</a>,
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html">AWS::IAM::User</a>,
        /// and <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html">AWS::IAM::UserToGroupAddition</a>.
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
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name associated with the stack. The name must be unique within your AWS account.
        /// </para>
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
        /// size: 307,200 bytes) located in an S3 bucket in the same region as the stack. For
        /// more information, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
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