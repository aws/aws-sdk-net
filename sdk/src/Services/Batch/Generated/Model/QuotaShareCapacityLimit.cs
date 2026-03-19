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
    /// Defines the capacity limit for a quota share, or the type and maximum quantity of
    /// a particular resource that can be allocated to jobs in the quota share without borrowing.
    /// </summary>
    public partial class QuotaShareCapacityLimit
    {
        private string _capacityUnit;
        private int? _maxCapacity;

        /// <summary>
        /// Gets and sets the property CapacityUnit. 
        /// <para>
        /// The unit of compute capacity for the capacityLimit. For example, <c>ml.m5.large</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The maximum capacity available for the quota share. This value represents the maximum
        /// quantity of a resource that can be allocated to jobs in the quota share without borrowing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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