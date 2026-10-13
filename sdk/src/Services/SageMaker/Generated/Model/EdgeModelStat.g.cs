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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Status of edge devices with this model.
    /// </summary>
    public partial class EdgeModelStat
    {
        /// <summary>
        /// Gets and sets the property ActiveDeviceCount. 
        /// <para>
        /// The number of devices that have this model version, a heart beat, and are currently
        /// running.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ActiveDeviceCount { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDeviceCount property is set.
        /// </summary>
        internal bool IsSetActiveDeviceCount() => this.ActiveDeviceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectedDeviceCount. 
        /// <para>
        /// The number of devices that have this model version and have a heart beat. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ConnectedDeviceCount { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedDeviceCount property is set.
        /// </summary>
        internal bool IsSetConnectedDeviceCount() => this.ConnectedDeviceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The model version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersion property is set.
        /// </summary>
        internal bool IsSetModelVersion() => this.ModelVersion != null;

        /// <summary>
        /// Gets and sets the property OfflineDeviceCount. 
        /// <para>
        /// The number of devices that have this model version and do not have a heart beat.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? OfflineDeviceCount { get; set; }

        /// <summary>
        /// Checks to see if the OfflineDeviceCount property is set.
        /// </summary>
        internal bool IsSetOfflineDeviceCount() => this.OfflineDeviceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SamplingDeviceCount. 
        /// <para>
        /// The number of devices with this model version and are producing sample data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? SamplingDeviceCount { get; set; }

        /// <summary>
        /// Checks to see if the SamplingDeviceCount property is set.
        /// </summary>
        internal bool IsSetSamplingDeviceCount() => this.SamplingDeviceCount.HasValue;
    }
}
