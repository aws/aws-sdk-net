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
    /// Defines the capacity limit for a service environment. This structure specifies the
    /// maximum amount of resources that can be used by service jobs in the environment.
    /// </summary>
    public partial class CapacityLimit
    {
        private string _capacityUnit;
        private int? _maxCapacity;

        /// <summary>
        /// Gets and sets the property CapacityUnit. 
        /// <para>
        /// The unit of measure for the capacity limit. This defines how the maxCapacity value
        /// should be interpreted. For <c>SAGEMAKER_TRAINING</c> jobs, use <c>NUM_INSTANCES</c>.
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
        /// The maximum capacity available for the service environment. This value represents
        /// the maximum amount of resources that can be allocated to service jobs.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>maxCapacity=50</c>, <c>capacityUnit=NUM_INSTANCES</c>. This indicates
        /// that the maximum number of instances that can be run on this service environment is
        /// 50. You could then run 5 SageMaker Training jobs that each use 10 instances. However,
        /// if you submit another job that requires 10 instances, it will wait in the queue.
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