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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about the number of instances that can be launched onto the Dedicated
    /// Host.
    /// </summary>
    public partial class InstanceCapacity
    {
        /// <summary>
        /// Gets and sets the property AvailableCapacity. 
        /// <para>
        /// The number of instances that can be launched onto the Dedicated Host based on the
        /// host's available capacity.
        /// </para>
        /// </summary>
        public int? AvailableCapacity { get; set; }

        /// <summary>
        /// Checks to see if the AvailableCapacity property is set.
        /// </summary>
        internal bool IsSetAvailableCapacity() => this.AvailableCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type supported by the Dedicated Host.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property TotalCapacity. 
        /// <para>
        /// The total number of instances that can be launched onto the Dedicated Host if there
        /// are no instances running on it.
        /// </para>
        /// </summary>
        public int? TotalCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TotalCapacity property is set.
        /// </summary>
        internal bool IsSetTotalCapacity() => this.TotalCapacity.HasValue;
    }
}
