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
    /// Configuration of requested EBS block device associated with the instance group.
    /// </summary>
    public partial class EbsBlockDevice
    {
        private string _device;
        private VolumeSpecification _volumeSpecification;

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device name that is exposed to the instance, such as /dev/sdh.
        /// </para>
        /// </summary>
        public string Device
        {
            get { return this._device; }
            set { this._device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeSpecification. 
        /// <para>
        /// EBS volume specifications such as volume type, IOPS, size (GiB) and throughput (MiB/s)
        /// that are requested for the EBS volume attached to an Amazon EC2 instance in the cluster.
        /// </para>
        /// </summary>
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

    }
}