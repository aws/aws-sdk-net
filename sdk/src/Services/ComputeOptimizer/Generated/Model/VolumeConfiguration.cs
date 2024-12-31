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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the configuration of an Amazon Elastic Block Store (Amazon EBS) volume.
    /// </summary>
    public partial class VolumeConfiguration
    {
        private bool? _rootVolume;
        private int? _volumeBaselineIOPS;
        private int? _volumeBaselineThroughput;
        private int? _volumeBurstIOPS;
        private int? _volumeBurstThroughput;
        private int? _volumeSize;
        private string _volumeType;

        /// <summary>
        /// Gets and sets the property RootVolume. 
        /// <para>
        ///  Contains the image used to boot the instance during launch. 
        /// </para>
        /// </summary>
        public bool? RootVolume
        {
            get { return this._rootVolume; }
            set { this._rootVolume = value; }
        }

        // Check to see if RootVolume property is set
        internal bool IsSetRootVolume()
        {
            return this._rootVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeBaselineIOPS. 
        /// <para>
        /// The baseline IOPS of the volume.
        /// </para>
        /// </summary>
        public int? VolumeBaselineIOPS
        {
            get { return this._volumeBaselineIOPS; }
            set { this._volumeBaselineIOPS = value; }
        }

        // Check to see if VolumeBaselineIOPS property is set
        internal bool IsSetVolumeBaselineIOPS()
        {
            return this._volumeBaselineIOPS.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeBaselineThroughput. 
        /// <para>
        /// The baseline throughput of the volume.
        /// </para>
        /// </summary>
        public int? VolumeBaselineThroughput
        {
            get { return this._volumeBaselineThroughput; }
            set { this._volumeBaselineThroughput = value; }
        }

        // Check to see if VolumeBaselineThroughput property is set
        internal bool IsSetVolumeBaselineThroughput()
        {
            return this._volumeBaselineThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeBurstIOPS. 
        /// <para>
        /// The burst IOPS of the volume.
        /// </para>
        /// </summary>
        public int? VolumeBurstIOPS
        {
            get { return this._volumeBurstIOPS; }
            set { this._volumeBurstIOPS = value; }
        }

        // Check to see if VolumeBurstIOPS property is set
        internal bool IsSetVolumeBurstIOPS()
        {
            return this._volumeBurstIOPS.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeBurstThroughput. 
        /// <para>
        /// The burst throughput of the volume.
        /// </para>
        /// </summary>
        public int? VolumeBurstThroughput
        {
            get { return this._volumeBurstThroughput; }
            set { this._volumeBurstThroughput = value; }
        }

        // Check to see if VolumeBurstThroughput property is set
        internal bool IsSetVolumeBurstThroughput()
        {
            return this._volumeBurstThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        /// </summary>
        public int? VolumeSize
        {
            get { return this._volumeSize; }
            set { this._volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this._volumeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type.
        /// </para>
        ///  
        /// <para>
        /// The volume types can be the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose SSD <c>gp2</c> and <c>gp3</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS SSD <c>io1</c>, <c>io2</c>, and <c>io2 Block Express</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Throughput Optimized HDD <c>st1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cold HDD <c>sc1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic volumes <c>standard</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}