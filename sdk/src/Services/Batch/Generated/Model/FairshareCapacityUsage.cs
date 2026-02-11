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
    /// The capacity usage for a fairshare scheduling job queue.
    /// </summary>
    public partial class FairshareCapacityUsage
    {
        private string _capacityUnit;
        private double? _quantity;

        /// <summary>
        /// Gets and sets the property CapacityUnit. 
        /// <para>
        /// The unit of measure for the capacity usage. For compute jobs, this is <c>VCPU</c>
        /// for Amazon EC2 and <c>cpu</c> for Amazon EKS. For service jobs, this is <c>NUM_INSTANCES</c>.
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
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The quantity of capacity being used, measured in the units specified by <c>capacityUnit</c>.
        /// </para>
        /// </summary>
        public double Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

    }
}