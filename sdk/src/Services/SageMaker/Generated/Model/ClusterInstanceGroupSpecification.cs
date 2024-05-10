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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The specifications of an instance group that you need to define.
    /// </summary>
    public partial class ClusterInstanceGroupSpecification
    {
        private string _executionRole;
        private int? _instanceCount;
        private string _instanceGroupName;
        private ClusterInstanceType _instanceType;
        private ClusterLifeCycleConfig _lifeCycleConfig;
        private int? _threadsPerCore;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// Specifies an IAM execution role to be assumed by the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Specifies the number of instances to add to the instance group of a SageMaker HyperPod
        /// cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// Specifies the name of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string InstanceGroupName
        {
            get { return this._instanceGroupName; }
            set { this._instanceGroupName = value; }
        }

        // Check to see if InstanceGroupName property is set
        internal bool IsSetInstanceGroupName()
        {
            return this._instanceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Specifies the instance type of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LifeCycleConfig. 
        /// <para>
        /// Specifies the LifeCycle configuration for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterLifeCycleConfig LifeCycleConfig
        {
            get { return this._lifeCycleConfig; }
            set { this._lifeCycleConfig = value; }
        }

        // Check to see if LifeCycleConfig property is set
        internal bool IsSetLifeCycleConfig()
        {
            return this._lifeCycleConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        /// Specifies the value for <b>Threads per core</b>. For instance types that support multithreading,
        /// you can specify <c>1</c> for disabling multithreading and <c>2</c> for enabling multithreading.
        /// For instance types that doesn't support multithreading, specify <c>1</c>. For more
        /// information, see the reference table of <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cpu-options-supported-instances-values.html">CPU
        /// cores and threads per CPU core per instance type</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public int? ThreadsPerCore
        {
            get { return this._threadsPerCore; }
            set { this._threadsPerCore = value; }
        }

        // Check to see if ThreadsPerCore property is set
        internal bool IsSetThreadsPerCore()
        {
            return this._threadsPerCore.HasValue; 
        }

    }
}