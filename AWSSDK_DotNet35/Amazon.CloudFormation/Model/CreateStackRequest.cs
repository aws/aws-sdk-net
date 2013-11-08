/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Creates a stack as specified in the template. After the call completes successfully, the stack creation starts. You can check the
    /// status of the stack via the DescribeStacks API.</para> <para><b>NOTE:</b> Currently, the limit for stacks is 20 stacks per account per
    /// region. </para>
    /// </summary>
    public partial class CreateStackRequest : AmazonCloudFormationRequest
    {
        private string stackName;
        private string templateBody;
        private string templateURL;
        private List<Parameter> parameters = new List<Parameter>();
        private bool? disableRollback;
        private int? timeoutInMinutes;
        private List<string> notificationARNs = new List<string>();
        private List<string> capabilities = new List<string>();
        private OnFailure onFailure;
        private string stackPolicyBody;
        private string stackPolicyURL;
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The name associated with the stack. The name must be unique within your AWS account. <note>Must contain only alphanumeric characters (case
        /// sensitive) and start with an alpha character. Maximum length of the name is 255 characters.</note>
        ///  
        /// </summary>
        public string StackName
        {
            get { return this.stackName; }
            set { this.stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;
        }

        /// <summary>
        /// Structure containing the template body. (For more information, go to the <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a>.) Conditional: You must pass
        /// <c>TemplateBody</c> or <c>TemplateURL</c>. If both are passed, only <c>TemplateBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this.templateBody; }
            set { this.templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this.templateBody != null;
        }

        /// <summary>
        /// Location of file containing the template body. The URL must point to a template (max size: 307,200 bytes) located in an S3 bucket in the
        /// same region as the stack. For more information, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS
        /// CloudFormation User Guide</a>. Conditional: You must pass <c>TemplateURL</c> or <c>TemplateBody</c>. If both are passed, only
        /// <c>TemplateBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateURL
        {
            get { return this.templateURL; }
            set { this.templateURL = value; }
        }

        // Check to see if TemplateURL property is set
        internal bool IsSetTemplateURL()
        {
            return this.templateURL != null;
        }

        /// <summary>
        /// A list of <c>Parameter</c> structures that specify input parameters for the stack.
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }

        /// <summary>
        /// Set to <c>true</c> to disable rollback of the stack if stack creation failed. You can specify either <c>DisableRollback</c> or
        /// <c>OnFailure</c>, but not both. Default: <c>false</c>
        ///  
        /// </summary>
        public bool DisableRollback
        {
            get { return this.disableRollback ?? default(bool); }
            set { this.disableRollback = value; }
        }

        // Check to see if DisableRollback property is set
        internal bool IsSetDisableRollback()
        {
            return this.disableRollback.HasValue;
        }

        /// <summary>
        /// The amount of time that can pass before the stack status becomes CREATE_FAILED; if <c>DisableRollback</c> is not set or is set to
        /// <c>false</c>, the stack will be rolled back.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int TimeoutInMinutes
        {
            get { return this.timeoutInMinutes ?? default(int); }
            set { this.timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this.timeoutInMinutes.HasValue;
        }

        /// <summary>
        /// The Simple Notification Service (SNS) topic ARNs to publish stack related events. You can find your SNS topic ARNs using the <a
        /// href="http://console.aws.amazon.com/sns">SNS console</a> or your Command Line Interface (CLI).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 5</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> NotificationARNs
        {
            get { return this.notificationARNs; }
            set { this.notificationARNs = value; }
        }

        // Check to see if NotificationARNs property is set
        internal bool IsSetNotificationARNs()
        {
            return this.notificationARNs.Count > 0;
        }

        /// <summary>
        /// The list of capabilities that you want to allow in the stack. If your template contains IAM resources, you must specify the CAPABILITY_IAM
        /// value for this parameter; otherwise, this action returns an InsufficientCapabilities error. IAM resources are the following: <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html">AWS::IAM::AccessKey</a>, <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">AWS::IAM::Group</a>, <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html">AWS::IAM::Policy</a>, <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html">AWS::IAM::User</a>, and <a
        /// ef="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html">AWS::IAM::UserToGroupAddition</a>.
        ///  
        /// </summary>
        public List<string> Capabilities
        {
            get { return this.capabilities; }
            set { this.capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this.capabilities.Count > 0;
        }

        /// <summary>
        /// Determines what action will be taken if stack creation fails. This must be one of: DO_NOTHING, ROLLBACK, or DELETE. You can specify either
        /// <c>OnFailure</c> or <c>DisableRollback</c>, but not both. Default: <c>ROLLBACK</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>DO_NOTHING, ROLLBACK, DELETE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public OnFailure OnFailure
        {
            get { return this.onFailure; }
            set { this.onFailure = value; }
        }

        // Check to see if OnFailure property is set
        internal bool IsSetOnFailure()
        {
            return this.onFailure != null;
        }

        /// <summary>
        /// Structure containing the stack policy body. (For more information, go to the <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/protect-stack-resources.html"> AWS CloudFormation User Guide</a>.) If
        /// you pass <c>StackPolicyBody</c> and <c>StackPolicyURL</c>, only <c>StackPolicyBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 16384</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StackPolicyBody
        {
            get { return this.stackPolicyBody; }
            set { this.stackPolicyBody = value; }
        }

        // Check to see if StackPolicyBody property is set
        internal bool IsSetStackPolicyBody()
        {
            return this.stackPolicyBody != null;
        }

        /// <summary>
        /// Location of a file containing the stack policy. The URL must point to a policy (max size: 16KB) located in an S3 bucket in the same region
        /// as the stack. If you pass <c>StackPolicyBody</c> and <c>StackPolicyURL</c>, only <c>StackPolicyBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1350</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StackPolicyURL
        {
            get { return this.stackPolicyURL; }
            set { this.stackPolicyURL = value; }
        }

        // Check to see if StackPolicyURL property is set
        internal bool IsSetStackPolicyURL()
        {
            return this.stackPolicyURL != null;
        }

        /// <summary>
        /// A set of user-defined <c>Tags</c> to associate with this stack, represented by key/value pairs. Tags defined for the stack are propagated to
        /// EC2 resources that are created as part of the stack. A maximum number of 10 tags can be specified.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

    }
}
    
