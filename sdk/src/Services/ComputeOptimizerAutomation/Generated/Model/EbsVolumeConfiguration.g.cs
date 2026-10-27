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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Configuration details for an Amazon EBS volume.
    /// </summary>
    public partial class EbsVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS) provisioned for the volume.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInGib. 
        /// <para>
        /// The size of the EBS volume in gibibytes (GiB).
        /// </para>
        /// </summary>
        public int? SizeInGib { get; set; }

        /// <summary>
        /// Checks to see if the SizeInGib property is set.
        /// </summary>
        internal bool IsSetSizeInGib() => this.SizeInGib.HasValue;

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput in MiB/s provisioned for the volume (applicable to gp3, io1, and io2bx
        /// volumes).
        /// </para>
        /// </summary>
        public int? Throughput { get; set; }

        /// <summary>
        /// Checks to see if the Throughput property is set.
        /// </summary>
        internal bool IsSetThroughput() => this.Throughput.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The EBS volume type, such as gp2, gp3, io1, io2, st1, or sc1.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
