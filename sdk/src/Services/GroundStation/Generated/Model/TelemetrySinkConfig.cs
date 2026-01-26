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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about a telemetry sink <c>Config</c>.
    /// </summary>
    public partial class TelemetrySinkConfig
    {
        private TelemetrySinkData _telemetrySinkData;
        private TelemetrySinkType _telemetrySinkType;

        /// <summary>
        /// Gets and sets the property TelemetrySinkData. 
        /// <para>
        /// Information about the telemetry sink specified by the <c>telemetrySinkType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TelemetrySinkData TelemetrySinkData
        {
            get { return this._telemetrySinkData; }
            set { this._telemetrySinkData = value; }
        }

        // Check to see if TelemetrySinkData property is set
        internal bool IsSetTelemetrySinkData()
        {
            return this._telemetrySinkData != null;
        }

        /// <summary>
        /// Gets and sets the property TelemetrySinkType. 
        /// <para>
        /// The type of telemetry sink.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TelemetrySinkType TelemetrySinkType
        {
            get { return this._telemetrySinkType; }
            set { this._telemetrySinkType = value; }
        }

        // Check to see if TelemetrySinkType property is set
        internal bool IsSetTelemetrySinkType()
        {
            return this._telemetrySinkType != null;
        }

    }
}