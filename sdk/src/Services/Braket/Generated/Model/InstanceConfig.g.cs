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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Configures the resource instances to use while running the Amazon Braket hybrid job
    /// on Amazon Braket.
    /// </summary>
    public partial class InstanceConfig
    {
        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Configures the number of resource instances to use while running an Amazon Braket
        /// hybrid job on Amazon Braket. The default value is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Configures the type of resource instances to use while running an Amazon Braket hybrid
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeInGb. 
        /// <para>
        /// The size of the storage volume, in GB, to provision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? VolumeSizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInGb property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInGb() => this.VolumeSizeInGb.HasValue;
    }
}
