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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Launch template disk configuration.
    /// </summary>
    public partial class LaunchTemplateDiskConf
    {
        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Launch template disk delete on termination configuration.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Launch template disk iops configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 64000)]
        public long? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// Launch template disk throughput configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 125, Max = 2000)]
        public long? Throughput { get; set; }

        /// <summary>
        /// Checks to see if the Throughput property is set.
        /// </summary>
        internal bool IsSetThroughput() => this.Throughput.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeInitializationRate. 
        /// <para>
        /// Launch template disk volume initialization rate configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 300)]
        public long? VolumeInitializationRate { get; set; }

        /// <summary>
        /// Checks to see if the VolumeInitializationRate property is set.
        /// </summary>
        internal bool IsSetVolumeInitializationRate() => this.VolumeInitializationRate.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// Launch template disk volume type configuration.
        /// </para>
        /// </summary>
        public VolumeType VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}
