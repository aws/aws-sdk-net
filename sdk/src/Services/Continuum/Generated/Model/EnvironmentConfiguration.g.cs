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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Environment-level operating policy.
    /// </summary>
    public partial class EnvironmentConfiguration
    {
        /// <summary>
        /// Gets and sets the property Network. Network policy for agent execution.
        /// </summary>
        public EnvironmentNetworkConfiguration Network { get; set; }

        /// <summary>
        /// Checks to see if the Network property is set.
        /// </summary>
        internal bool IsSetNetwork() => this.Network != null;

        /// <summary>
        /// Gets and sets the property PatchCreationPolicy. Whether Continuum creates a patch
        /// for a proposed remediation. Defaults to DISABLED.
        /// </summary>
        public PatchCreationPolicy PatchCreationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the PatchCreationPolicy property is set.
        /// </summary>
        internal bool IsSetPatchCreationPolicy() => this.PatchCreationPolicy != null;

        /// <summary>
        /// Gets and sets the property ScanFrequency. Recurring scan interval: P1D (1 day), P2D
        /// (2 days), or P7D (7 days). PT0H disables recurring scans. Defaults to P1D when creating
        /// an environment.
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string ScanFrequency { get; set; }

        /// <summary>
        /// Checks to see if the ScanFrequency property is set.
        /// </summary>
        internal bool IsSetScanFrequency() => this.ScanFrequency != null;
    }
}
