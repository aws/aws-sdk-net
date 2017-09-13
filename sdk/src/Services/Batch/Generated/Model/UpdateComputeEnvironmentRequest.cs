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
    /// Container for the parameters to the UpdateComputeEnvironment operation.
    /// Updates an AWS Batch compute environment.
    /// </summary>
    public partial class UpdateComputeEnvironmentRequest : AmazonBatchRequest
    {
        private string _computeEnvironment;
        private ComputeResourceUpdate _computeResources;
        private string _serviceRole;
        private CEState _state;

        /// <summary>
        /// Gets and sets the property ComputeEnvironment. 
        /// <para>
        /// The name or full Amazon Resource Name (ARN) of the compute environment to update.
        /// </para>
        /// </summary>
        public string ComputeEnvironment
        {
            get { return this._computeEnvironment; }
            set { this._computeEnvironment = value; }
        }

        // Check to see if ComputeEnvironment property is set
        internal bool IsSetComputeEnvironment()
        {
            return this._computeEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeResources. 
        /// <para>
        /// Details of the compute resources managed by the compute environment. Required for
        /// a managed compute environment.
        /// </para>
        /// </summary>
        public ComputeResourceUpdate ComputeResources
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
        /// The state of the compute environment. Compute environments in the <code>ENABLED</code>
        /// state can accept jobs from a queue and scale in or out automatically based on the
        /// workload demand of its associated queues.
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

    }
}