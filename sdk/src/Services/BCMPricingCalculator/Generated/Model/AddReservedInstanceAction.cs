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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents an action to add a Reserved Instance to a bill scenario.
    /// </summary>
    public partial class AddReservedInstanceAction
    {
        private int? _instanceCount;
        private string _reservedInstancesOfferingId;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        ///  The number of instances to add for this Reserved Instance offering. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property ReservedInstancesOfferingId. 
        /// <para>
        ///  The ID of the Reserved Instance offering to add. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeReservedInstancesOfferings.html">
        /// DescribeReservedInstancesOfferings</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ReservedInstancesOfferingId
        {
            get { return this._reservedInstancesOfferingId; }
            set { this._reservedInstancesOfferingId = value; }
        }

        // Check to see if ReservedInstancesOfferingId property is set
        internal bool IsSetReservedInstancesOfferingId()
        {
            return this._reservedInstancesOfferingId != null;
        }

    }
}