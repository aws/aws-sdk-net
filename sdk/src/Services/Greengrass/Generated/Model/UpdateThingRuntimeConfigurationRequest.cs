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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateThingRuntimeConfiguration operation.
    /// Updates the runtime configuration of a thing.
    /// </summary>
    public partial class UpdateThingRuntimeConfigurationRequest : AmazonGreengrassRequest
    {
        private TelemetryConfigurationUpdate _telemetryConfiguration;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property TelemetryConfiguration. Configuration for telemetry service.
        /// </summary>
        public TelemetryConfigurationUpdate TelemetryConfiguration
        {
            get { return this._telemetryConfiguration; }
            set { this._telemetryConfiguration = value; }
        }

        // Check to see if TelemetryConfiguration property is set
        internal bool IsSetTelemetryConfiguration()
        {
            return this._telemetryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. The thing name.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}