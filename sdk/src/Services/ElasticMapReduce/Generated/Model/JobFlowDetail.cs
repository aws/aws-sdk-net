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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A description of a cluster (job flow).
    /// </summary>
    public partial class JobFlowDetail
    {
        private string _amiVersion;
        private string _autoScalingRole;
        private List<BootstrapActionDetail> _bootstrapActions = new List<BootstrapActionDetail>();
        private JobFlowExecutionStatusDetail _executionStatusDetail;
        private JobFlowInstancesDetail _instances;
        private string _jobFlowId;
        private string _jobFlowRole;
        private string _logUri;
        private string _name;
        private ScaleDownBehavior _scaleDownBehavior;
        private string _serviceRole;
        private List<StepDetail> _steps = new List<StepDetail>();
        private List<string> _supportedProducts = new List<string>();
        private bool? _visibleToAllUsers;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public JobFlowDetail() { }

        /// <summary>
        /// Instantiates JobFlowDetail with the parameterized properties
        /// </summary>
        /// <param name="jobFlowId">The job flow identifier.</param>
        /// <param name="name">The name of the job flow.</param>
        /// <param name="executionStatusDetail">Describes the execution status of the job flow.</param>
        /// <param name="instances">Describes the Amazon EC2 instances of the job flow.</param>
        public JobFlowDetail(string jobFlowId, string name, JobFlowExecutionStatusDetail executionStatusDetail, JobFlowInstancesDetail instances)
        {
            _jobFlowId = jobFlowId;
            _name = name;
            _executionStatusDetail = executionStatusDetail;
            _instances = instances;
        }

        /// <summary>
        /// Gets and sets the property AmiVersion. 
        /// <para>
        /// The version of the AMI used to initialize Amazon EC2 instances in the job flow. For
        /// a list of AMI versions currently supported by Amazon EMR, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/EnvironmentConfig_AMIVersion.html#ami-versions-supported">AMI
        /// Versions Supported in EMR</a> in the <i>Amazon EMR Developer Guide.</i> 
        /// </para>
        /// </summary>
        public string AmiVersion
        {
            get { return this._amiVersion; }
            set { this._amiVersion = value; }
        }

        // Check to see if AmiVersion property is set
        internal bool IsSetAmiVersion()
        {
            return this._amiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingRole. 
        /// <para>
        /// An IAM role for automatic scaling policies. The default role is <code>EMR_AutoScaling_DefaultRole</code>.
        /// The IAM role provides a way for the automatic scaling feature to get the required
        /// permissions it needs to launch and terminate EC2 instances in an instance group.
        /// </para>
        /// </summary>
        public string AutoScalingRole
        {
            get { return this._autoScalingRole; }
            set { this._autoScalingRole = value; }
        }

        // Check to see if AutoScalingRole property is set
        internal bool IsSetAutoScalingRole()
        {
            return this._autoScalingRole != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapActions. 
        /// <para>
        /// A list of the bootstrap actions run by the job flow.
        /// </para>
        /// </summary>
        public List<BootstrapActionDetail> BootstrapActions
        {
            get { return this._bootstrapActions; }
            set { this._bootstrapActions = value; }
        }

        // Check to see if BootstrapActions property is set
        internal bool IsSetBootstrapActions()
        {
            return this._bootstrapActions != null && this._bootstrapActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatusDetail. 
        /// <para>
        /// Describes the execution status of the job flow.
        /// </para>
        /// </summary>
        public JobFlowExecutionStatusDetail ExecutionStatusDetail
        {
            get { return this._executionStatusDetail; }
            set { this._executionStatusDetail = value; }
        }

        // Check to see if ExecutionStatusDetail property is set
        internal bool IsSetExecutionStatusDetail()
        {
            return this._executionStatusDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// Describes the Amazon EC2 instances of the job flow.
        /// </para>
        /// </summary>
        public JobFlowInstancesDetail Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null;
        }

        /// <summary>
        /// Gets and sets the property JobFlowId. 
        /// <para>
        /// The job flow identifier.
        /// </para>
        /// </summary>
        public string JobFlowId
        {
            get { return this._jobFlowId; }
            set { this._jobFlowId = value; }
        }

        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this._jobFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property JobFlowRole. 
        /// <para>
        /// The IAM role that was specified when the job flow was launched. The EC2 instances
        /// of the job flow assume this role.
        /// </para>
        /// </summary>
        public string JobFlowRole
        {
            get { return this._jobFlowRole; }
            set { this._jobFlowRole = value; }
        }

        // Check to see if JobFlowRole property is set
        internal bool IsSetJobFlowRole()
        {
            return this._jobFlowRole != null;
        }

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The location in Amazon S3 where log files for the job are stored.
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this._logUri != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job flow.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ScaleDownBehavior. 
        /// <para>
        /// The way that individual Amazon EC2 instances terminate when an automatic scale-in
        /// activity occurs or an instance group is resized. <code>TERMINATE_AT_INSTANCE_HOUR</code>
        /// indicates that Amazon EMR terminates nodes at the instance-hour boundary, regardless
        /// of when the request to terminate the instance was submitted. This option is only available
        /// with Amazon EMR 5.1.0 and later and is the default for clusters created using that
        /// version. <code>TERMINATE_AT_TASK_COMPLETION</code> indicates that Amazon EMR blacklists
        /// and drains tasks from nodes before terminating the Amazon EC2 instances, regardless
        /// of the instance-hour boundary. With either behavior, Amazon EMR removes the least
        /// active nodes first and blocks instance termination if it could lead to HDFS corruption.
        /// <code>TERMINATE_AT_TASK_COMPLETION</code> available only in Amazon EMR version 4.1.0
        /// and later, and is the default for versions of Amazon EMR earlier than 5.1.0.
        /// </para>
        /// </summary>
        public ScaleDownBehavior ScaleDownBehavior
        {
            get { return this._scaleDownBehavior; }
            set { this._scaleDownBehavior = value; }
        }

        // Check to see if ScaleDownBehavior property is set
        internal bool IsSetScaleDownBehavior()
        {
            return this._scaleDownBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM role that will be assumed by the Amazon EMR service to access AWS resources
        /// on your behalf.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// A list of steps run by the job flow.
        /// </para>
        /// </summary>
        public List<StepDetail> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && this._steps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedProducts. 
        /// <para>
        /// A list of strings set by third party software when the job flow is launched. If you
        /// are not using third party software to manage the job flow this value is empty.
        /// </para>
        /// </summary>
        public List<string> SupportedProducts
        {
            get { return this._supportedProducts; }
            set { this._supportedProducts = value; }
        }

        // Check to see if SupportedProducts property is set
        internal bool IsSetSupportedProducts()
        {
            return this._supportedProducts != null && this._supportedProducts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VisibleToAllUsers. 
        /// <para>
        /// Specifies whether the cluster is visible to all IAM users of the AWS account associated
        /// with the cluster. If this value is set to <code>true</code>, all IAM users of that
        /// AWS account can view and (if they have the proper policy permissions set) manage the
        /// cluster. If it is set to <code>false</code>, only the IAM user that created the cluster
        /// can view and manage it. This value can be changed using the <a>SetVisibleToAllUsers</a>
        /// action.
        /// </para>
        /// </summary>
        public bool VisibleToAllUsers
        {
            get { return this._visibleToAllUsers.GetValueOrDefault(); }
            set { this._visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this._visibleToAllUsers.HasValue; 
        }

    }
}