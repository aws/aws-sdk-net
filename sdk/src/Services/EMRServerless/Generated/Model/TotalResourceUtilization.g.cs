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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The aggregate vCPU, memory, and storage resources used from the time job start executing
    /// till the time job is terminated, rounded up to the nearest second.
    /// </summary>
    public partial class TotalResourceUtilization
    {
        /// <summary>
        /// Gets and sets the property MemoryGBHour. 
        /// <para>
        /// The aggregated memory used per hour from the time job start executing till the time
        /// job is terminated.
        /// </para>
        /// </summary>
        public double? MemoryGBHour { get; set; }

        /// <summary>
        /// Checks to see if the MemoryGBHour property is set.
        /// </summary>
        internal bool IsSetMemoryGBHour() => this.MemoryGBHour.HasValue;

        /// <summary>
        /// Gets and sets the property StorageGBHour. 
        /// <para>
        /// The aggregated storage used per hour from the time job start executing till the time
        /// job is terminated.
        /// </para>
        /// </summary>
        public double? StorageGBHour { get; set; }

        /// <summary>
        /// Checks to see if the StorageGBHour property is set.
        /// </summary>
        internal bool IsSetStorageGBHour() => this.StorageGBHour.HasValue;

        /// <summary>
        /// Gets and sets the property VCPUHour. 
        /// <para>
        /// The aggregated vCPU used per hour from the time job start executing till the time
        /// job is terminated.
        /// </para>
        /// </summary>
        public double? VCPUHour { get; set; }

        /// <summary>
        /// Checks to see if the VCPUHour property is set.
        /// </summary>
        internal bool IsSetVCPUHour() => this.VCPUHour.HasValue;
    }
}
