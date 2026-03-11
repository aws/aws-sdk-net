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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComputeEnvironment operation.
    /// Creates an Batch compute environment. You can create <c>MANAGED</c> or <c>UNMANAGED</c>
    /// compute environments. <c>MANAGED</c> compute environments can use Amazon EC2 or Fargate
    /// resources. <c>UNMANAGED</c> compute environments can only use EC2 resources.
    /// 
    ///  
    /// <para>
    /// In a managed compute environment, Batch manages the capacity and instance types of
    /// the compute resources within the environment. This is based on the compute resource
    /// specification that you define or the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
    /// template</a> that you specify when you create the compute environment. Either, you
    /// can choose to use EC2 On-Demand Instances and EC2 Spot Instances. Or, you can use
    /// Fargate and Fargate Spot capacity in your managed compute environment. You can optionally
    /// set a maximum price so that Spot Instances only launch when the Spot Instance price
    /// is less than a specified percentage of the On-Demand price.
    /// </para>
    ///  
    /// <para>
    /// In an unmanaged compute environment, you can manage your own EC2 compute resources
    /// and have flexibility with how you configure your compute resources. For example, you
    /// can use custom AMIs. However, you must verify that each of your AMIs meet the Amazon
    /// ECS container instance AMI specification. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container_instance_AMIs.html">container
    /// instance AMIs</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// After you created your unmanaged compute environment, you can use the <a>DescribeComputeEnvironments</a>
    /// operation to find the Amazon ECS cluster that's associated with it. Then, launch your
    /// container instances into that Amazon ECS cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_container_instance.html">Launching
    /// an Amazon ECS container instance</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Batch doesn't automatically upgrade the AMIs in a compute environment after it's created.
    /// For more information on how to update a compute environment's AMI, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
    /// compute environments</a> in the <i>Batch User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateComputeEnvironmentRequest : AmazonBatchRequest
    {
        private string _computeEnvironmentName;
        private ComputeResource _computeResources;
        private string _context;
        private EksConfiguration _eksConfiguration;
        private string _serviceRole;
        private CEState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private CEType _type;
        private int? _unmanagedvCpus;

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentName. 
        /// <para>
        /// The name for your compute environment. It can be up to 128 characters long. It can
        /// contain uppercase and lowercase letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeEnvironmentName
        {
            get { return this._computeEnvironmentName; }
            set { this._computeEnvironmentName = value; }
        }

        // Check to see if ComputeEnvironmentName property is set
        internal bool IsSetComputeEnvironmentName()
        {
            return this._computeEnvironmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeResources. 
        /// <para>
        /// Details about the compute resources managed by the compute environment. This parameter
        /// is required for managed compute environments. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// Environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public ComputeResource ComputeResources
        {
            get { return this._computeResources; }
            set { this._computeResources = value; }
        }

        // Check to see if ComputeResources property is set
        internal bool IsSetComputeResources()
        {
            return this._computeResources != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property EksConfiguration. 
        /// <para>
        /// The details for the Amazon EKS cluster that supports the compute environment.
        /// </para>
        ///  <note> 
        /// <para>
        /// To create a compute environment that uses EKS resources, the caller must have permissions
        /// to call <c>eks:DescribeCluster</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public EksConfiguration EksConfiguration
        {
            get { return this._eksConfiguration; }
            set { this._eksConfiguration = value; }
        }

        // Check to see if EksConfiguration property is set
        internal bool IsSetEksConfiguration()
        {
            return this._eksConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that allows Batch to make calls
        /// to other Amazon Web Services services on your behalf. For more information, see <a
        /// href="https://docs.aws.amazon.com/batch/latest/userguide/service_IAM_role.html">Batch
        /// service IAM role</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your account already created the Batch service-linked role, that role is used by
        /// default for your compute environment unless you specify a different role here. If
        /// the Batch service-linked role doesn't exist in your account, and no role is specified
        /// here, the service attempts to create the Batch service-linked role in your account.
        /// </para>
        ///  </important> 
        /// <para>
        /// If your specified role has a path other than <c>/</c>, then you must specify either
        /// the full role ARN (recommended) or prefix the role name with the path. For example,
        /// if a role with the name <c>bar</c> has a path of <c>/foo/</c>, specify <c>/foo/bar</c>
        /// as the role name. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-friendly-names">Friendly
        /// names and paths</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Depending on how you created your Batch service role, its ARN might contain the <c>service-role</c>
        /// path prefix. When you only specify the name of the service role, Batch assumes that
        /// your ARN doesn't use the <c>service-role</c> path prefix. Because of this, we recommend
        /// that you specify the full ARN of your service role when you create compute environments.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the compute environment. If the state is <c>ENABLED</c>, then the compute
        /// environment accepts jobs from a queue and can scale out automatically based on queues.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>ENABLED</c>, then the Batch scheduler can attempt to place jobs
        /// from an associated job queue on the compute resources within the environment. If the
        /// compute environment is managed, then it can scale its instances out or in automatically,
        /// based on the job queue demand.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>DISABLED</c>, then the Batch scheduler doesn't attempt to place
        /// jobs within the environment. Jobs in a <c>STARTING</c> or <c>RUNNING</c> state continue
        /// to progress normally. Managed compute environments in the <c>DISABLED</c> state don't
        /// scale out. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Compute environments in a <c>DISABLED</c> state may continue to incur billing charges.
        /// To prevent additional charges, turn off and then delete the compute environment. For
        /// more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environment_parameters.html#compute_environment_state">State</a>
        /// in the <i>Batch User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When an instance is idle, the instance scales down to the <c>minvCpus</c> value. However,
        /// the instance size doesn't change. For example, consider a <c>c5.8xlarge</c> instance
        /// with a <c>minvCpus</c> value of <c>4</c> and a <c>desiredvCpus</c> value of <c>36</c>.
        /// This instance doesn't scale down to a <c>c5.large</c> instance.
        /// </para>
        /// </summary>
        public CEState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the compute environment to help you categorize and organize
        /// your resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> in <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// These tags can be updated or removed using the <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_TagResource.html">TagResource</a>
        /// and <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_UntagResource.html">UntagResource</a>
        /// API operations. These tags don't propagate to the underlying compute resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the compute environment: <c>MANAGED</c> or <c>UNMANAGED</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// Environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CEType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UnmanagedvCpus. 
        /// <para>
        /// The maximum number of vCPUs for an unmanaged compute environment. This parameter is
        /// only used for fair-share scheduling to reserve vCPU capacity for new share identifiers.
        /// If this parameter isn't provided for a fair-share job queue, no vCPU capacity is reserved.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only supported when the <c>type</c> parameter is set to <c>UNMANAGED</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public int? UnmanagedvCpus
        {
            get { return this._unmanagedvCpus; }
            set { this._unmanagedvCpus = value; }
        }

        // Check to see if UnmanagedvCpus property is set
        internal bool IsSetUnmanagedvCpus()
        {
            return this._unmanagedvCpus.HasValue; 
        }

    }
}