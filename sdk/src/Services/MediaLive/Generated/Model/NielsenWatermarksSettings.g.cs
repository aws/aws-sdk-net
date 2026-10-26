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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Nielsen Watermarks Settings
    /// </summary>
    public partial class NielsenWatermarksSettings
    {
        /// <summary>
        /// Gets and sets the property NielsenCbetSettings. Complete these fields only if you
        /// want to insert watermarks of type Nielsen CBET
        /// </summary>
        public NielsenCBET NielsenCbetSettings { get; set; }

        /// <summary>
        /// Checks to see if the NielsenCbetSettings property is set.
        /// </summary>
        internal bool IsSetNielsenCbetSettings() => this.NielsenCbetSettings != null;

        /// <summary>
        /// Gets and sets the property NielsenDistributionType. Choose the distribution types
        /// that you want to assign to the watermarks: - PROGRAM_CONTENT - FINAL_DISTRIBUTOR
        /// </summary>
        public NielsenWatermarksDistributionTypes NielsenDistributionType { get; set; }

        /// <summary>
        /// Checks to see if the NielsenDistributionType property is set.
        /// </summary>
        internal bool IsSetNielsenDistributionType() => this.NielsenDistributionType != null;

        /// <summary>
        /// Gets and sets the property NielsenNaesIiNwSettings. Complete these fields only if
        /// you want to insert watermarks of type Nielsen NAES II (N2) and Nielsen NAES VI (NW).
        /// </summary>
        public NielsenNaesIiNw NielsenNaesIiNwSettings { get; set; }

        /// <summary>
        /// Checks to see if the NielsenNaesIiNwSettings property is set.
        /// </summary>
        internal bool IsSetNielsenNaesIiNwSettings() => this.NielsenNaesIiNwSettings != null;

        /// <summary>
        /// Gets and sets the property NielsenNwOnlySettings. Complete these fields only if you
        /// want to insert watermarks of type Nielsen NAES VI (NW) only, without inserting NAES
        /// II (N2) watermarks.
        /// </summary>
        public NielsenNwOnly NielsenNwOnlySettings { get; set; }

        /// <summary>
        /// Checks to see if the NielsenNwOnlySettings property is set.
        /// </summary>
        internal bool IsSetNielsenNwOnlySettings() => this.NielsenNwOnlySettings != null;
    }
}
