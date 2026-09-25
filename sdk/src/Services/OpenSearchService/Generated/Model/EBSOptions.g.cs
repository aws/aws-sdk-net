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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters required to enable EBS-based storage for an OpenSearch
    /// Service domain.
    /// </summary>
    public partial class EBSOptions
    {
        /// <summary>
        /// Gets and sets the property EBSEnabled. 
        /// <para>
        /// Indicates whether EBS volumes are attached to data nodes in an OpenSearch Service
        /// domain.
        /// </para>
        /// </summary>
        public bool? EBSEnabled { get; set; }

        /// <summary>
        /// Checks to see if the EBSEnabled property is set.
        /// </summary>
        internal bool IsSetEBSEnabled() => this.EBSEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Specifies the baseline input/output (I/O) performance of EBS volumes attached to data
        /// nodes. Applicable only for the <c>gp3</c> and provisioned IOPS EBS volume types.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// Specifies the throughput (in MiB/s) of the EBS volumes attached to data nodes. Applicable
        /// only for the <c>gp3</c> volume type.
        /// </para>
        /// </summary>
        public int? Throughput { get; set; }

        /// <summary>
        /// Checks to see if the Throughput property is set.
        /// </summary>
        internal bool IsSetThroughput() => this.Throughput.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// Specifies the size (in GiB) of EBS volumes attached to data nodes.
        /// </para>
        /// </summary>
        public int? VolumeSize { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSize property is set.
        /// </summary>
        internal bool IsSetVolumeSize() => this.VolumeSize.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// Specifies the type of EBS volumes attached to data nodes.
        /// </para>
        /// </summary>
        public VolumeType VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}
