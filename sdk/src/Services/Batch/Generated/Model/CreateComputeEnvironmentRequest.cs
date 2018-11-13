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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComputeEnvironment operation.
    /// Creates an AWS Batch compute environment. You can create <code>MANAGED</code> or <code>UNMANAGED</code>
    /// compute environments.
    /// 
    ///  
    /// <para>
    /// In a managed compute environment, AWS Batch manages the capacity and instance types
    /// of the compute resources within the environment, based on the compute resource specification
    /// that you define or <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
    /// template</a> that you specify when you create the compute environment. You can choose
    /// to use Amazon EC2 On-Demand Instances or Spot Instances in your managed compute environment.
    /// You can optionally set a maximum price so that Spot Instances only launch when the
    /// Spot Instance price is below a specified percentage of the On-Demand price.
    /// </para>
    ///  
    /// <para>
    /// In an unmanaged compute environment, you can manage your own compute resources. This
    /// provides more compute resource configuration options, such as using a custom AMI,
    /// but you must ensure that your AMI meets the Amazon ECS container instance AMI specification.
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/container_instance_AMIs.html">Container
    /// Instance AMIs</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// After you have created your unmanaged compute environment, you can use the <a>DescribeComputeEnvironments</a>
    /// operation to find the Amazon ECS cluster that is associated with it and then manually
    /// launch your container instances into that Amazon ECS cluster. For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_container_instance.html">Launching
    /// an Amazon ECS Container Instance</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS Batch does not upgrade the AMIs in a compute environment after it is created (for
    /// example, when a newer version of the Amazon ECS-optimized AMI is available). You are
    /// responsible for the management of the guest operating system (including updates and
    /// security patches) and any additional application software or utilities that you install
    /// on the compute resources. To use a new AMI for your AWS Batch jobs:
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
    /// Remove the old compute environment from your job queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Delete the old compute environment.
    /// </para>
    ///  </li> </ol> </note>
    /// </summary>
    public partial class CreateComputeEnvironmentRequest : AmazonBatchRequest
    {
        private string _computeEnvironmentName;
        private ComputeResource _computeResources;
        private string _serviceRole;
        private CEState _state;
        private CEType _type;

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentName. 
        /// <para>
        /// The name for your compute environment. Up to 128 letters (uppercase and lowercase),
        /// numbers, hyphens, and underscores are allowed.
        /// </para>
        /// </summary>
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
        /// Details of the compute resources managed by the compute environment. This parameter
        /// is required for managed compute environments.
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
        /// calls to other AWS services on your behalf.
        /// </para>
        ///  
        /// <para>
        /// If your specified role has a path other than <code>/</code>, then you must either
        /// specify the full role ARN (this is recommended) or prefix the role name with the path.
        /// </para>
        ///  <note> 
        /// <para>
        /// Depending on how you created your AWS Batch service role, its ARN may contain the
        /// <code>service-role</code> path prefix. When you only specify the name of the service
        /// role, AWS Batch assumes that your ARN does not use the <code>service-role</code> path
        /// prefix. Because of this, we recommend that you specify the full ARN of your service
        /// role when you create compute environments.
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
        /// The state of the compute environment. If the state is <code>ENABLED</code>, then the
        /// compute environment accepts jobs from a queue and can scale out automatically based
        /// on queues.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the compute environment. For more information, see <a href="http://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// Environments</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        /// </summary>
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