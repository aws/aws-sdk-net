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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
    /// Configuration of requested EBS block device associated with the instance group with
    /// count of volumes that are associated to every instance.
    /// </summary>
    public partial class EbsBlockDeviceConfig
    {
        private VolumeSpecification _volumeSpecification;
        private int? _volumesPerInstance;

        /// <summary>
        /// Gets and sets the property VolumeSpecification. 
        /// <para>
        /// EBS volume specifications such as volume type, IOPS, size (GiB) and throughput (MiB/s)
        /// that are requested for the EBS volume attached to an Amazon EC2 instance in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VolumeSpecification VolumeSpecification
        {
            get { return this._volumeSpecification; }
            set { this._volumeSpecification = value; }
        }

        // Check to see if VolumeSpecification property is set
        internal bool IsSetVolumeSpecification()
        {
            return this._volumeSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property VolumesPerInstance. 
        /// <para>
        /// Number of EBS volumes with a specific volume configuration that are associated with
        /// every instance in the instance group
        /// </para>
        /// </summary>
        public int? VolumesPerInstance
        {
            get { return this._volumesPerInstance; }
            set { this._volumesPerInstance = value; }
        }

        // Check to see if VolumesPerInstance property is set
        internal bool IsSetVolumesPerInstance()
        {
            return this._volumesPerInstance.HasValue; 
        }

    }
}