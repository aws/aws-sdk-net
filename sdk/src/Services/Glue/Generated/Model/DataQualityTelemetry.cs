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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// 
    /// </summary>
    public partial class DataQualityTelemetry
    {
        private DataQualityEngine _engine;
        private Dictionary<string, string> _flagsEnabled = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _hostRuntimeVersion;
        private string _libraryVersion;
        private string _sparkVersion;
        private double? _vcpuHours;

        /// <summary>
        /// Gets and sets the property Engine.
        /// </summary>
        public DataQualityEngine Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property FlagsEnabled.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public Dictionary<string, string> FlagsEnabled
        {
            get { return this._flagsEnabled; }
            set { this._flagsEnabled = value; }
        }

        // Check to see if FlagsEnabled property is set
        internal bool IsSetFlagsEnabled()
        {
            return this._flagsEnabled != null && (this._flagsEnabled.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HostRuntimeVersion.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string HostRuntimeVersion
        {
            get { return this._hostRuntimeVersion; }
            set { this._hostRuntimeVersion = value; }
        }

        // Check to see if HostRuntimeVersion property is set
        internal bool IsSetHostRuntimeVersion()
        {
            return this._hostRuntimeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LibraryVersion.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LibraryVersion
        {
            get { return this._libraryVersion; }
            set { this._libraryVersion = value; }
        }

        // Check to see if LibraryVersion property is set
        internal bool IsSetLibraryVersion()
        {
            return this._libraryVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SparkVersion.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SparkVersion
        {
            get { return this._sparkVersion; }
            set { this._sparkVersion = value; }
        }

        // Check to see if SparkVersion property is set
        internal bool IsSetSparkVersion()
        {
            return this._sparkVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VcpuHours.
        /// </summary>
        public double? VcpuHours
        {
            get { return this._vcpuHours; }
            set { this._vcpuHours = value; }
        }

        // Check to see if VcpuHours property is set
        internal bool IsSetVcpuHours()
        {
            return this._vcpuHours.HasValue; 
        }

    }
}