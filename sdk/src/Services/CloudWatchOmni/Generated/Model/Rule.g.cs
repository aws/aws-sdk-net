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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Top-level rule definition. {@code telemetryRule} members are optional at the Smithy
    /// level to support PATCH semantics on UpdateAlert (send only the sub-blocks you want
    /// to change). On CreateAlert, presence is enforced by the service-side validator.
    /// </summary>
    public partial class Rule
    {
        /// <summary>
        /// Gets and sets the property TelemetryRule. The telemetry-based rule definition.
        /// </summary>
        public TelemetryRule TelemetryRule { get; set; }

        /// <summary>
        /// Checks to see if the TelemetryRule property is set.
        /// </summary>
        internal bool IsSetTelemetryRule() => this.TelemetryRule != null;
    }
}
