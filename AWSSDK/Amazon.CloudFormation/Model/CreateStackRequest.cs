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
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.CreateStack"/>
    public class CreateStackRequest : AmazonWebServiceRequest
    {
        private string stackName;
        private string templateBody;
        private string templateURL;
        private List<Parameter> parameters = new List<Parameter>();
        private bool? disableRollback;
        private int? timeoutInMinutes;
        private List<string> notificationARNs = new List<string>();
        private List<string> capabilities = new List<string>();
        private string onFailure;
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

        /// <summary>
        /// Sets the StackName property
        /// </summary>
        /// <param name="stackName">The value to set for the StackName property </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithStackName(string stackName)
        {
            this.stackName = stackName;
            return this;
        }
            

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;
        }

        /// <summary>
        /// Structure containing the template body. (For more information, go to the <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a>.) Conditional: You must pass
        /// <c>TemplateBody</c> or <c>TemplateURL</c>. If both are passed, only <c>TemplateBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 51200</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this.templateBody; }
            set { this.templateBody = value; }
        }

        /// <summary>
        /// Sets the TemplateBody property
        /// </summary>
        /// <param name="templateBody">The value to set for the TemplateBody property </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithTemplateBody(string templateBody)
        {
            this.templateBody = templateBody;
            return this;
        }
            

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this.templateBody != null;
        }

        /// <summary>
        /// Location of file containing the template body. The URL must point to a template (max size: 307,200 bytes) located in an S3 bucket in the
        /// same region as the stack. For more information, go to the <a href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide">AWS
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

        /// <summary>
        /// Sets the TemplateURL property
        /// </summary>
        /// <param name="templateURL">The value to set for the TemplateURL property </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithTemplateURL(string templateURL)
        {
            this.templateURL = templateURL;
            return this;
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
        /// <summary>
        /// Adds elements to the Parameters collection
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithParameters(params Parameter[] parameters)
        {
            foreach (Parameter element in parameters)
            {
                this.parameters.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Parameters collection
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithParameters(IEnumerable<Parameter> parameters)
        {
            foreach (Parameter element in parameters)
            {
                this.parameters.Add(element);
            }

            return this;
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

        /// <summary>
        /// Sets the DisableRollback property
        /// </summary>
        /// <param name="disableRollback">The value to set for the DisableRollback property </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithDisableRollback(bool disableRollback)
        {
            this.disableRollback = disableRollback;
            return this;
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

        /// <summary>
        /// Sets the TimeoutInMinutes property
        /// </summary>
        /// <param name="timeoutInMinutes">The value to set for the TimeoutInMinutes property </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithTimeoutInMinutes(int timeoutInMinutes)
        {
            this.timeoutInMinutes = timeoutInMinutes;
            return this;
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
        /// <summary>
        /// Adds elements to the NotificationARNs collection
        /// </summary>
        /// <param name="notificationARNs">The values to add to the NotificationARNs collection </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithNotificationARNs(params string[] notificationARNs)
        {
            foreach (string element in notificationARNs)
            {
                this.notificationARNs.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the NotificationARNs collection
        /// </summary>
        /// <param name="notificationARNs">The values to add to the NotificationARNs collection </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithNotificationARNs(IEnumerable<string> notificationARNs)
        {
            foreach (string element in notificationARNs)
            {
                this.notificationARNs.Add(element);
            }

            return this;
        }

        // Check to see if NotificationARNs property is set
        internal bool IsSetNotificationARNs()
        {
            return this.notificationARNs.Count > 0;
        }

        /// <summary>
        /// The list of capabilities that you want to allow in the stack. If your template contains IAM resources, you must specify the CAPABILITY_IAM
        /// value for this parameter; otherwise, this action returns an InsufficientCapabilities error. IAM resources are the following: <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html">AWS::IAM::AccessKey</a>, <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">AWS::IAM::Group</a>, <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html">AWS::IAM::Policy</a>, <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html">AWS::IAM::User</a>, and <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html">AWS::IAM::UserToGroupAddition</a>.
        ///  
        /// </summary>
        public List<string> Capabilities
        {
            get { return this.capabilities; }
            set { this.capabilities = value; }
        }
        /// <summary>
        /// Adds elements to the Capabilities collection
        /// </summary>
        /// <param name="capabilities">The values to add to the Capabilities collection </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithCapabilities(params string[] capabilities)
        {
            foreach (string element in capabilities)
            {
                this.capabilities.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Capabilities collection
        /// </summary>
        /// <param name="capabilities">The values to add to the Capabilities collection </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithCapabilities(IEnumerable<string> capabilities)
        {
            foreach (string element in capabilities)
            {
                this.capabilities.Add(element);
            }

            return this;
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
        public string OnFailure
        {
            get { return this.onFailure; }
            set { this.onFailure = value; }
        }

        /// <summary>
        /// Sets the OnFailure property
        /// </summary>
        /// <param name="onFailure">The value to set for the OnFailure property </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithOnFailure(string onFailure)
        {
            this.onFailure = onFailure;
            return this;
        }
            

        // Check to see if OnFailure property is set
        internal bool IsSetOnFailure()
        {
            return this.onFailure != null;
        }

        /// <summary>
        /// A set of user-defined <c>Tags</c> to associate with this stack, represented by key/value pairs. Tags defined for the stack are propogated to
        /// EC2 resources that are created as part of the stack. A maximum number of 10 tags can be specified.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }
        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithTags(params Tag[] tags)
        {
            foreach (Tag element in tags)
            {
                this.tags.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        public CreateStackRequest WithTags(IEnumerable<Tag> tags)
        {
            foreach (Tag element in tags)
            {
                this.tags.Add(element);
            }

            return this;
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
    
