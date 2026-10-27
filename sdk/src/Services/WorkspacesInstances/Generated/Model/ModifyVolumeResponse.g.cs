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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// This is the response object from the ModifyVolume operation.
    /// </summary>
    public partial class ModifyVolumeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property TargetIops. 
        /// <para>
        /// Specifies the target IOPS rate of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TargetIops { get; set; }

        /// <summary>
        /// Checks to see if the TargetIops property is set.
        /// </summary>
        internal bool IsSetTargetIops() => this.TargetIops.HasValue;

        /// <summary>
        /// Gets and sets the property TargetSize. 
        /// <para>
        /// Specifies the target size of the volume, in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TargetSize { get; set; }

        /// <summary>
        /// Checks to see if the TargetSize property is set.
        /// </summary>
        internal bool IsSetTargetSize() => this.TargetSize.HasValue;

        /// <summary>
        /// Gets and sets the property TargetThroughput. 
        /// <para>
        /// Specifies the target throughput of the volume, in MiB/s.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TargetThroughput { get; set; }

        /// <summary>
        /// Checks to see if the TargetThroughput property is set.
        /// </summary>
        internal bool IsSetTargetThroughput() => this.TargetThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property TargetVolumeType. 
        /// <para>
        /// Specifies the target Amazon EBS volume type.
        /// </para>
        /// </summary>
        public VolumeTypeEnum TargetVolumeType { get; set; }

        /// <summary>
        /// Checks to see if the TargetVolumeType property is set.
        /// </summary>
        internal bool IsSetTargetVolumeType() => this.TargetVolumeType != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// Specifies the identifier of the modified volume.
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}
