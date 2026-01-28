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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration for Lambda-managed instances used by the capacity provider.
    /// </summary>
    public partial class LambdaManagedInstancesCapacityProviderConfig
    {
        private string _capacityProviderArn;
        private double? _executionEnvironmentMemoryGiBPerVCpu;
        private int? _perExecutionEnvironmentMaxConcurrency;

        /// <summary>
        /// Gets and sets the property CapacityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string CapacityProviderArn
        {
            get { return this._capacityProviderArn; }
            set { this._capacityProviderArn = value; }
        }

        // Check to see if CapacityProviderArn property is set
        internal bool IsSetCapacityProviderArn()
        {
            return this._capacityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionEnvironmentMemoryGiBPerVCpu. 
        /// <para>
        /// The amount of memory in GiB allocated per vCPU for execution environments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=8)]
        public double? ExecutionEnvironmentMemoryGiBPerVCpu
        {
            get { return this._executionEnvironmentMemoryGiBPerVCpu; }
            set { this._executionEnvironmentMemoryGiBPerVCpu = value; }
        }

        // Check to see if ExecutionEnvironmentMemoryGiBPerVCpu property is set
        internal bool IsSetExecutionEnvironmentMemoryGiBPerVCpu()
        {
            return this._executionEnvironmentMemoryGiBPerVCpu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerExecutionEnvironmentMaxConcurrency. 
        /// <para>
        /// The maximum number of concurrent execution environments that can run on each compute
        /// instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public int? PerExecutionEnvironmentMaxConcurrency
        {
            get { return this._perExecutionEnvironmentMaxConcurrency; }
            set { this._perExecutionEnvironmentMaxConcurrency = value; }
        }

        // Check to see if PerExecutionEnvironmentMaxConcurrency property is set
        internal bool IsSetPerExecutionEnvironmentMaxConcurrency()
        {
            return this._perExecutionEnvironmentMaxConcurrency.HasValue; 
        }

    }
}