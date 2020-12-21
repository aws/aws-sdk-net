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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComputeEnvironment operation.
    /// Creates an AWS Batch compute environment. You can create <code>MANAGED</code> or <code>UNMANAGED</code>
    /// compute environments. <code>MANAGED</code> compute environments can use Amazon EC2
    /// or AWS Fargate resources. <code>UNMANAGED</code> compute environments can only use
    /// EC2 resources.
    /// 
    ///  
    /// <para>
    /// In a managed compute environment, AWS Batch manages the capacity and instance types
    /// of the compute resources within the environment. This is based on the compute resource
    /// specification that you define or the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
    /// template</a> that you specify when you create the compute environment. You can choose
    /// either to use EC2 On-Demand Instances and EC2 Spot Instances, or to use Fargate and
    /// Fargate Spot capacity in your managed compute environment. You can optionally set
    /// a maximum price so that Spot Instances only launch when the Spot Instance price is
    /// less than a specified percentage of the On-Demand price.
    /// </para>
    ///  <note> 
    /// <para>
    /// Multi-node parallel jobs are not supported on Spot Instances.
    /// </para>
    ///  </note> 
    /// <para>
    /// In an unmanaged compute environment, you can manage your own EC2 compute resources
    /// and have a lot of flexibility with how you configure your compute resources. For example,
    /// you can use custom AMI. However, you need to verify that your AMI meets the Amazon
    /// ECS container instance AMI specification. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container_instance_AMIs.html">container
    /// instance AMIs</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// After you have created your unmanaged compute environment, you can use the <a>DescribeComputeEnvironments</a>
    /// operation to find the Amazon ECS cluster that's associated with it. Then, manually
    /// launch your container instances into that Amazon ECS cluster. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_container_instance.html">Launching
    /// an Amazon ECS container instance</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS Batch doesn't upgrade the AMIs in a compute environment after it's created. For
    /// example, it doesn't update the AMIs when a newer version of the Amazon ECS-optimized
    /// AMI is available. Therefore, you're responsible for the management of the guest operating
    /// system (including updates and security patches) and any additional application software
    /// or utilities that you install on the compute resources. To use a new AMI for your
    /// AWS Batch jobs, complete these steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create a new compute environment with the new AMI.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Add the compute environment to an existing job queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Remove the earlier compute environment from your job queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Delete the earlier compute environment.
    /// </para>
    ///  </li> </ol> </note>
    /// </summary>
    public partial class CreateComputeEnvironmentRequest : AmazonBatchRequest
    {
        private string _computeEnvironmentName;
        private ComputeResource _computeResources;
        private string _serviceRole;
        private CEState _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private CEType _type;

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentName. 
        /// <para>
        /// The name for your compute environment. Up to 128 letters (uppercase and lowercase),
        /// numbers, hyphens, and underscores are allowed.
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
        /// Environments</a> in the <i>AWS Batch User Guide</i>.
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
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make
        /// calls to other AWS services on your behalf. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/service_IAM_role.html">AWS
        /// Batch service IAM role</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If your specified role has a path other than <code>/</code>, then you must either
        /// specify the full role ARN (this is recommended) or prefix the role name with the path.
        /// </para>
        ///  <note> 
        /// <para>
        /// Depending on how you created your AWS Batch service role, its ARN might contain the
        /// <code>service-role</code> path prefix. When you only specify the name of the service
        /// role, AWS Batch assumes that your ARN doesn't use the <code>service-role</code> path
        /// prefix. Because of this, we recommend that you specify the full ARN of your service
        /// role when you create compute environments.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The state of the compute environment. If the state is <code>ENABLED</code>, then the
        /// compute environment accepts jobs from a queue and can scale out automatically based
        /// on queues.
        /// </para>
        ///  
        /// <para>
        /// If the state is <code>ENABLED</code>, then the AWS Batch scheduler can attempt to
        /// place jobs from an associated job queue on the compute resources within the environment.
        /// If the compute environment is managed, then it can scale its instances out or in automatically,
        /// based on the job queue demand.
        /// </para>
        ///  
        /// <para>
        /// If the state is <code>DISABLED</code>, then the AWS Batch scheduler doesn't attempt
        /// to place jobs within the environment. Jobs in a <code>STARTING</code> or <code>RUNNING</code>
        /// state continue to progress normally. Managed compute environments in the <code>DISABLED</code>
        /// state don't scale out. However, they scale in to <code>minvCpus</code> value after
        /// instances become idle.
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
        /// AWS Resources</a> in <i>AWS General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// These tags can be updated or removed using the <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_TagResource.html">TagResource</a>
        /// and <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_UntagResource.html">UntagResource</a>
        /// API operations. These tags don't propagate to the underlying compute resources.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the compute environment: <code>MANAGED</code> or <code>UNMANAGED</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// Environments</a> in the <i>AWS Batch User Guide</i>.
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

    }
}