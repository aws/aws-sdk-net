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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A description of a cluster (job flow).
    /// </summary>
    public partial class JobFlowDetail
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
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
            this.JobFlowId = jobFlowId;
            this.Name = name;
            this.ExecutionStatusDetail = executionStatusDetail;
            this.Instances = instances;
        }

        /// <summary>
        /// Gets and sets the property AmiVersion. 
        /// <para>
        /// Applies only to Amazon EMR AMI versions 3.x and 2.x. For Amazon EMR releases 4.0 and
        /// later, <c>ReleaseLabel</c> is used. To specify a custom AMI, use <c>CustomAmiID</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AmiVersion { get; set; }

        /// <summary>
        /// Checks to see if the AmiVersion property is set.
        /// </summary>
        internal bool IsSetAmiVersion() => this.AmiVersion != null;

        /// <summary>
        /// Gets and sets the property AutoScalingRole. 
        /// <para>
        /// An IAM role for automatic scaling policies. The default role is <c>EMR_AutoScaling_DefaultRole</c>.
        /// The IAM role provides a way for the automatic scaling feature to get the required
        /// permissions it needs to launch and terminate Amazon EC2 instances in an instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string AutoScalingRole { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingRole property is set.
        /// </summary>
        internal bool IsSetAutoScalingRole() => this.AutoScalingRole != null;

        /// <summary>
        /// Gets and sets the property BootstrapActions. 
        /// <para>
        /// A list of the bootstrap actions run by the job flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BootstrapActionDetail> BootstrapActions { get; set; } = AWSConfigs.InitializeCollections ? new List<BootstrapActionDetail>() : null;

        /// <summary>
        /// Checks to see if the BootstrapActions property is set.
        /// </summary>
        internal bool IsSetBootstrapActions() => this.BootstrapActions != null && (this.BootstrapActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionStatusDetail. 
        /// <para>
        /// Describes the execution status of the job flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobFlowExecutionStatusDetail ExecutionStatusDetail { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatusDetail property is set.
        /// </summary>
        internal bool IsSetExecutionStatusDetail() => this.ExecutionStatusDetail != null;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// Describes the Amazon EC2 instances of the job flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobFlowInstancesDetail Instances { get; set; }

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null;

        /// <summary>
        /// Gets and sets the property JobFlowId. 
        /// <para>
        /// The job flow identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string JobFlowId { get; set; }

        /// <summary>
        /// Checks to see if the JobFlowId property is set.
        /// </summary>
        internal bool IsSetJobFlowId() => this.JobFlowId != null;

        /// <summary>
        /// Gets and sets the property JobFlowRole. 
        /// <para>
        /// The IAM role that was specified when the job flow was launched. The Amazon EC2 instances
        /// of the job flow assume this role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string JobFlowRole { get; set; }

        /// <summary>
        /// Checks to see if the JobFlowRole property is set.
        /// </summary>
        internal bool IsSetJobFlowRole() => this.JobFlowRole != null;

        /// <summary>
        /// Gets and sets the property LogEncryptionKmsKeyId. 
        /// <para>
        /// The KMS key used for encrypting log files. This attribute is only available with Amazon
        /// EMR 5.30.0 and later, excluding 6.0.0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string LogEncryptionKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the LogEncryptionKmsKeyId property is set.
        /// </summary>
        internal bool IsSetLogEncryptionKmsKeyId() => this.LogEncryptionKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The location in Amazon S3 where log files for the job are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string LogUri { get; set; }

        /// <summary>
        /// Checks to see if the LogUri property is set.
        /// </summary>
        internal bool IsSetLogUri() => this.LogUri != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScaleDownBehavior. 
        /// <para>
        /// The way that individual Amazon EC2 instances terminate when an automatic scale-in
        /// activity occurs or an instance group is resized. <c>TERMINATE_AT_INSTANCE_HOUR</c>
        /// indicates that Amazon EMR terminates nodes at the instance-hour boundary, regardless
        /// of when the request to terminate the instance was submitted. This option is only available
        /// with Amazon EMR 5.1.0 and later and is the default for clusters created using that
        /// version. <c>TERMINATE_AT_TASK_COMPLETION</c> indicates that Amazon EMR adds nodes
        /// to a deny list and drains tasks from nodes before terminating the Amazon EC2 instances,
        /// regardless of the instance-hour boundary. With either behavior, Amazon EMR removes
        /// the least active nodes first and blocks instance termination if it could lead to HDFS
        /// corruption. <c>TERMINATE_AT_TASK_COMPLETION</c> available only in Amazon EMR releases
        /// 4.1.0 and later, and is the default for releases of Amazon EMR earlier than 5.1.0.
        /// </para>
        /// </summary>
        public ScaleDownBehavior ScaleDownBehavior { get; set; }

        /// <summary>
        /// Checks to see if the ScaleDownBehavior property is set.
        /// </summary>
        internal bool IsSetScaleDownBehavior() => this.ScaleDownBehavior != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM role that is assumed by the Amazon EMR service to access Amazon Web Services
        /// resources on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// A list of steps run by the job flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StepDetail> Steps { get; set; } = AWSConfigs.InitializeCollections ? new List<StepDetail>() : null;

        /// <summary>
        /// Checks to see if the Steps property is set.
        /// </summary>
        internal bool IsSetSteps() => this.Steps != null && (this.Steps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedProducts. 
        /// <para>
        /// A list of strings set by third-party software when the job flow is launched. If you
        /// are not using third-party software to manage the job flow, this value is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedProducts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedProducts property is set.
        /// </summary>
        internal bool IsSetSupportedProducts() => this.SupportedProducts != null && (this.SupportedProducts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VisibleToAllUsers. 
        /// <para>
        /// Indicates whether the cluster is visible to IAM principals in the Amazon Web Services
        /// account associated with the cluster. When <c>true</c>, IAM principals in the Amazon
        /// Web Services account can perform Amazon EMR cluster actions that their IAM policies
        /// allow. When <c>false</c>, only the IAM principal that created the cluster and the
        /// Amazon Web Services account root user can perform Amazon EMR actions, regardless of
        /// IAM permissions policies attached to other IAM principals.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c> if a value is not provided when creating a cluster
        /// using the Amazon EMR API <a>RunJobFlow</a> command, the CLI <a href="https://docs.aws.amazon.com/cli/latest/reference/emr/create-cluster.html">create-cluster</a>
        /// command, or the Amazon Web Services Management Console.
        /// </para>
        /// </summary>
        public bool? VisibleToAllUsers { get; set; }

        /// <summary>
        /// Checks to see if the VisibleToAllUsers property is set.
        /// </summary>
        internal bool IsSetVisibleToAllUsers() => this.VisibleToAllUsers.HasValue;
    }
}
