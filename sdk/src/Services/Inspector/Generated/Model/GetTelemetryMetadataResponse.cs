/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// <zonbook/> <xhtml/>
    /// </summary>
    public partial class GetTelemetryMetadataResponse : AmazonWebServiceResponse
    {
        private List<TelemetryMetadata> _telemetryMetadata = new List<TelemetryMetadata>();

        /// <summary>
        /// Gets and sets the property TelemetryMetadata. 
        /// <para>
        /// Telemetry details.
        /// </para>
        /// </summary>
        public List<TelemetryMetadata> TelemetryMetadata
        {
            get { return this._telemetryMetadata; }
            set { this._telemetryMetadata = value; }
        }

        // Check to see if TelemetryMetadata property is set
        internal bool IsSetTelemetryMetadata()
        {
            return this._telemetryMetadata != null && this._telemetryMetadata.Count > 0; 
        }

    }
}