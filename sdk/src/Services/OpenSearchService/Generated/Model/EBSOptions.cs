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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters required to enable EBS-based storage for an OpenSearch
    /// Service domain.
    /// </summary>
    public partial class EBSOptions
    {
        private bool? _ebsEnabled;
        private int? _iops;
        private int? _throughput;
        private int? _volumeSize;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property EBSEnabled. 
        /// <para>
        /// Indicates whether EBS volumes are attached to data nodes in an OpenSearch Service
        /// domain.
        /// </para>
        /// </summary>
        public bool? EBSEnabled
        {
            get { return this._ebsEnabled; }
            set { this._ebsEnabled = value; }
        }

        // Check to see if EBSEnabled property is set
        internal bool IsSetEBSEnabled()
        {
            return this._ebsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Specifies the baseline input/output (I/O) performance of EBS volumes attached to data
        /// nodes. Applicable only for the <c>gp3</c> and provisioned IOPS EBS volume types.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Throughput. 
        /// <para>
        /// Specifies the throughput (in MiB/s) of the EBS volumes attached to data nodes. Applicable
        /// only for the <c>gp3</c> volume type.
        /// </para>
        /// </summary>
        public int? Throughput
        {
            get { return this._throughput; }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// Specifies the size (in GiB) of EBS volumes attached to data nodes.
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
        /// Specifies the type of EBS volumes attached to data nodes.
        /// </para>
        /// </summary>
        public VolumeType VolumeType
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