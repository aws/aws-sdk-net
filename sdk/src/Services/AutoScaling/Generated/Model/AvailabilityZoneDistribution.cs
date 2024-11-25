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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an Availability Zone distribution.
    /// </summary>
    public partial class AvailabilityZoneDistribution
    {
        private CapacityDistributionStrategy _capacityDistributionStrategy;

        /// <summary>
        /// Gets and sets the property CapacityDistributionStrategy. 
        /// <para>
        ///  If launches fail in an Availability Zone, the following strategies are available.
        /// The default is <c>balanced-best-effort</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>balanced-only</c> - If launches fail in an Availability Zone, Auto Scaling will
        /// continue to attempt to launch in the unhealthy zone to preserve a balanced distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>balanced-best-effort</c> - If launches fail in an Availability Zone, Auto Scaling
        /// will attempt to launch in another healthy Availability Zone instead.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityDistributionStrategy CapacityDistributionStrategy
        {
            get { return this._capacityDistributionStrategy; }
            set { this._capacityDistributionStrategy = value; }
        }

        // Check to see if CapacityDistributionStrategy property is set
        internal bool IsSetCapacityDistributionStrategy()
        {
            return this._capacityDistributionStrategy != null;
        }

    }
}