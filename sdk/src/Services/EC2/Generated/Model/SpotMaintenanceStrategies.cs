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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The strategies for managing your Spot Instances that are at an elevated risk of being
    /// interrupted.
    /// </summary>
    public partial class SpotMaintenanceStrategies
    {
        private SpotCapacityRebalance _capacityRebalance;

        /// <summary>
        /// Gets and sets the property CapacityRebalance. 
        /// <para>
        /// The strategy to use when Amazon EC2 emits a signal that your Spot Instance is at an
        /// elevated risk of being interrupted.
        /// </para>
        /// </summary>
        public SpotCapacityRebalance CapacityRebalance
        {
            get { return this._capacityRebalance; }
            set { this._capacityRebalance = value; }
        }

        // Check to see if CapacityRebalance property is set
        internal bool IsSetCapacityRebalance()
        {
            return this._capacityRebalance != null;
        }

    }
}