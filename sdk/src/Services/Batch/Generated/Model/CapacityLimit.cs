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
    /// Defines the type and maximum quantity of resources that can be allocated to service
    /// jobs in a service environment.
    /// </summary>
    public partial class CapacityLimit
    {
        private string _capacityUnit;
        private int? _maxCapacity;

        /// <summary>
        /// Gets and sets the property CapacityUnit. 
        /// <para>
        /// The unit of measure for the capacity limit, which defines how <c>maxCapacity</c> is
        /// interpreted. For <c>SAGEMAKER_TRAINING</c> jobs in a quota management enabled service
        /// environment, specify the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ResourceConfig.html#sagemaker-Type-ResourceConfig-InstanceType">instance
        /// type</a> (for example, <c>ml.m5.large</c>). Otherwise, use <c>NUM_INSTANCES</c>.
        /// </para>
        /// </summary>
        public string CapacityUnit
        {
            get { return this._capacityUnit; }
            set { this._capacityUnit = value; }
        }

        // Check to see if CapacityUnit property is set
        internal bool IsSetCapacityUnit()
        {
            return this._capacityUnit != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum capacity available for the service environment. For a quota management
        /// enabled service environment, this value represents the maximum quantity of a particular
        /// resource type (specified by <c>capacityUnit</c>) that can be allocated to service
        /// jobs. For other service environments, this value represents the maximum quantity of
        /// all resources that can be allocated to service jobs.
        /// </para>
        ///  
        /// <para>
        /// For example, if <c>maxCapacity=50</c> and <c>capacityUnit=NUM_INSTANCES</c>, you can
        /// run up to 50 instances concurrently. If you run 5 SageMaker Training jobs that each
        /// use 10 instances, a subsequent job requiring 10 instances waits in the queue until
        /// capacity is available. In a quota management enabled service environment with <c>capacityUnit=ml.m5.large</c>,
        /// only <c>ml.m5.large</c> instances count against this limit, and jobs requiring other
        /// instance types wait until a matching capacity limit is configured.
        /// </para>
        /// </summary>
        public int? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

    }
}