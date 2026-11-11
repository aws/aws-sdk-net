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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// EBS volume specifications such as volume type, IOPS, size (GiB) and throughput (MiB/s)
    /// that are requested for the EBS volume attached to an Amazon EC2 instance in the cluster.
    /// </summary>
    public partial class VolumeSpecification
    {
        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS) that the volume supports.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInGB. 
        /// <para>
        /// The volume size, in gibibytes (GiB). This can be a number from 1 - 1024. If the volume
        /// type is EBS-optimized, the minimum value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the SizeInGB property is set.
        /// </summary>
        internal bool IsSetSizeInGB() => this.SizeInGB.HasValue;

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput, in mebibyte per second (MiB/s). This optional parameter can be a number
        /// from 125 - 1000 and is valid only for gp3 volumes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Throughput { get; set; }

        /// <summary>
        /// Checks to see if the Throughput property is set.
        /// </summary>
        internal bool IsSetThroughput() => this.Throughput.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. Volume types supported are gp3, gp2, io1, st1, sc1, and standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}
