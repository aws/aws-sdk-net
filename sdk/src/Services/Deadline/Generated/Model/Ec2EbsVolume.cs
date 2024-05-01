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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
        private int? _iops;
        private int? _sizeGiB;
        private int? _throughputMiB;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The IOPS per volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3000, Max=16000)]
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeGiB. 
        /// <para>
        /// The EBS volume size in GiB.
        /// </para>
        /// </summary>
        public int? SizeGiB
        {
            get { return this._sizeGiB; }
            set { this._sizeGiB = value; }
        }

        // Check to see if SizeGiB property is set
        internal bool IsSetSizeGiB()
        {
            return this._sizeGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputMiB. 
        /// <para>
        /// The throughput per volume in MiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=125, Max=1000)]
        public int? ThroughputMiB
        {
            get { return this._throughputMiB; }
            set { this._throughputMiB = value; }
        }

        // Check to see if ThroughputMiB property is set
        internal bool IsSetThroughputMiB()
        {
            return this._throughputMiB.HasValue; 
        }

    }
}