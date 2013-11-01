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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para> A description of a job flow.</para>
    /// </summary>
    public class JobFlowDetail
    {
        
        private string jobFlowId;
        private string name;
        private string logUri;
        private string amiVersion;
        private JobFlowExecutionStatusDetail executionStatusDetail;
        private JobFlowInstancesDetail instances;
        private List<StepDetail> steps = new List<StepDetail>();
        private List<BootstrapActionDetail> bootstrapActions = new List<BootstrapActionDetail>();
        private List<string> supportedProducts = new List<string>();
        private bool? visibleToAllUsers;
        private string jobFlowRole;


        /// <summary>
        /// The job flow identifier.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string JobFlowId
        {
            get { return this.jobFlowId; }
            set { this.jobFlowId = value; }
        }

        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this.jobFlowId != null;
        }

        /// <summary>
        /// The name of the job flow.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The location in Amazon S3 where log files for the job are stored.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10280</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this.logUri; }
            set { this.logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this.logUri != null;
        }

        /// <summary>
        /// The version of the AMI used to initialize Amazon EC2 instances in the job flow. For a list of AMI versions currently supported by Amazon
        /// ElasticMapReduce, go to <a
        /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/EnvironmentConfig_AMIVersion.html#ami-versions-supported">AMI
        /// Versions Supported in Elastic MapReduce</a> in the <i>Amazon Elastic MapReduce Developer's Guide.</i>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AmiVersion
        {
            get { return this.amiVersion; }
            set { this.amiVersion = value; }
        }

        // Check to see if AmiVersion property is set
        internal bool IsSetAmiVersion()
        {
            return this.amiVersion != null;
        }

        /// <summary>
        /// Describes the execution status of the job flow.
        ///  
        /// </summary>
        public JobFlowExecutionStatusDetail ExecutionStatusDetail
        {
            get { return this.executionStatusDetail; }
            set { this.executionStatusDetail = value; }
        }

        // Check to see if ExecutionStatusDetail property is set
        internal bool IsSetExecutionStatusDetail()
        {
            return this.executionStatusDetail != null;
        }

        /// <summary>
        /// Describes the Amazon EC2 instances of the job flow.
        ///  
        /// </summary>
        public JobFlowInstancesDetail Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances != null;
        }

        /// <summary>
        /// A list of steps run by the job flow.
        ///  
        /// </summary>
        public List<StepDetail> Steps
        {
            get { return this.steps; }
            set { this.steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this.steps.Count > 0;
        }

        /// <summary>
        /// A list of the bootstrap actions run by the job flow.
        ///  
        /// </summary>
        public List<BootstrapActionDetail> BootstrapActions
        {
            get { return this.bootstrapActions; }
            set { this.bootstrapActions = value; }
        }

        // Check to see if BootstrapActions property is set
        internal bool IsSetBootstrapActions()
        {
            return this.bootstrapActions.Count > 0;
        }

        /// <summary>
        /// A list of strings set by third party software when the job flow is launched. If you are not using third party software to manage the job
        /// flow this value is empty.
        ///  
        /// </summary>
        public List<string> SupportedProducts
        {
            get { return this.supportedProducts; }
            set { this.supportedProducts = value; }
        }

        // Check to see if SupportedProducts property is set
        internal bool IsSetSupportedProducts()
        {
            return this.supportedProducts.Count > 0;
        }

        /// <summary>
        /// Specifies whether the job flow is visible to all IAM users of the AWS account associated with the job flow. If this value is set to
        /// <c>true</c>, all IAM users of that AWS account can view and (if they have the proper policy permissions set) manage the job flow. If it is
        /// set to <c>false</c>, only the IAM user that created the job flow can view and manage it. This value can be changed using the
        /// <a>SetVisibleToAllUsers</a> action.
        ///  
        /// </summary>
        public bool VisibleToAllUsers
        {
            get { return this.visibleToAllUsers ?? default(bool); }
            set { this.visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this.visibleToAllUsers.HasValue;
        }

        /// <summary>
        /// The IAM role that was specified when the job flow was launched. The EC2 instances of the job flow assume this role.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10280</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string JobFlowRole
        {
            get { return this.jobFlowRole; }
            set { this.jobFlowRole = value; }
        }

        // Check to see if JobFlowRole property is set
        internal bool IsSetJobFlowRole()
        {
            return this.jobFlowRole != null;
        }
    }
}
