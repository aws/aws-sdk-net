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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// </summary>
    public partial class DataQualityTelemetry
    {
        /// <summary>
        /// Gets and sets the property Engine.
        /// </summary>
        public DataQualityEngine Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property FlagsEnabled.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public Dictionary<string, string> FlagsEnabled { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the FlagsEnabled property is set.
        /// </summary>
        internal bool IsSetFlagsEnabled() => this.FlagsEnabled != null && (this.FlagsEnabled.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HostRuntimeVersion.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string HostRuntimeVersion { get; set; }

        /// <summary>
        /// Checks to see if the HostRuntimeVersion property is set.
        /// </summary>
        internal bool IsSetHostRuntimeVersion() => this.HostRuntimeVersion != null;

        /// <summary>
        /// Gets and sets the property LibraryVersion.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LibraryVersion { get; set; }

        /// <summary>
        /// Checks to see if the LibraryVersion property is set.
        /// </summary>
        internal bool IsSetLibraryVersion() => this.LibraryVersion != null;

        /// <summary>
        /// Gets and sets the property SparkVersion.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SparkVersion { get; set; }

        /// <summary>
        /// Checks to see if the SparkVersion property is set.
        /// </summary>
        internal bool IsSetSparkVersion() => this.SparkVersion != null;

        /// <summary>
        /// Gets and sets the property VcpuHours.
        /// </summary>
        public double? VcpuHours { get; set; }

        /// <summary>
        /// Checks to see if the VcpuHours property is set.
        /// </summary>
        internal bool IsSetVcpuHours() => this.VcpuHours.HasValue;
    }
}
