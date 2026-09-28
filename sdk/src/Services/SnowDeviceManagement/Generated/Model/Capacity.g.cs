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

namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// The physical capacity of the Amazon Web Services Snow Family device.
    /// </summary>
    public partial class Capacity
    {
        /// <summary>
        /// Gets and sets the property Available. 
        /// <para>
        /// The amount of capacity available for use on the device.
        /// </para>
        /// </summary>
        public long? Available { get; set; }

        /// <summary>
        /// Checks to see if the Available property is set.
        /// </summary>
        internal bool IsSetAvailable() => this.Available.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the type of capacity, such as memory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total capacity on the device.
        /// </para>
        /// </summary>
        public long? Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measure for the type of capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Used. 
        /// <para>
        /// The amount of capacity used on the device.
        /// </para>
        /// </summary>
        public long? Used { get; set; }

        /// <summary>
        /// Checks to see if the Used property is set.
        /// </summary>
        internal bool IsSetUsed() => this.Used.HasValue;
    }
}
