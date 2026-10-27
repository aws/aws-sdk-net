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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Specifies the EBS volume.
    /// </summary>
    public partial class Ec2EbsVolume
    {
        /// <summary>
        /// Gets and sets the property Iops. The IOPS per volume.
        /// </summary>
        [AWSProperty(Min = 3000, Max = 16000)]
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property SizeGiB. The EBS volume size in GiB.
        /// </summary>
        public int? SizeGiB { get; set; }

        /// <summary>
        /// Checks to see if the SizeGiB property is set.
        /// </summary>
        internal bool IsSetSizeGiB() => this.SizeGiB.HasValue;

        /// <summary>
        /// Gets and sets the property ThroughputMiB. The throughput per volume in MiB.
        /// </summary>
        [AWSProperty(Min = 125, Max = 1000)]
        public int? ThroughputMiB { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputMiB property is set.
        /// </summary>
        internal bool IsSetThroughputMiB() => this.ThroughputMiB.HasValue;
    }
}
