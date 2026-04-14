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
    /// Details about a specific instance type within a flexible instance group, including
    /// the count and configuration.
    /// </summary>
    public partial class ClusterInstanceTypeDetail
    {
        private int? _currentCount;
        private ClusterInstanceType _instanceType;
        private int? _threadsPerCore;

        /// <summary>
        /// Gets and sets the property CurrentCount. 
        /// <para>
        /// The number of instances of this type currently running in the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? CurrentCount
        {
            get { return this._currentCount; }
            set { this._currentCount = value; }
        }

        // Check to see if CurrentCount property is set
        internal bool IsSetCurrentCount()
        {
            return this._currentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        /// The number of threads per CPU core for this instance type.
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