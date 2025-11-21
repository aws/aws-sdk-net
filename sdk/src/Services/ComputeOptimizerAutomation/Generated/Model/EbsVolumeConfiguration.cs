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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
        private int? _iops;
        private int? _sizeInGib;
        private int? _throughput;
        private string _type;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS) provisioned for the volume.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInGib. 
        /// <para>
        /// The size of the EBS volume in gibibytes (GiB).
        /// </para>
        /// </summary>
        public int SizeInGib
        {
            get { return this._sizeInGib.GetValueOrDefault(); }
            set { this._sizeInGib = value; }
        }

        // Check to see if SizeInGib property is set
        internal bool IsSetSizeInGib()
        {
            return this._sizeInGib.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput in MiB/s provisioned for the volume (applicable to gp3, io1, and io2bx
        /// volumes).
        /// </para>
        /// </summary>
        public int Throughput
        {
            get { return this._throughput.GetValueOrDefault(); }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The EBS volume type, such as gp2, gp3, io1, io2, st1, or sc1.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}