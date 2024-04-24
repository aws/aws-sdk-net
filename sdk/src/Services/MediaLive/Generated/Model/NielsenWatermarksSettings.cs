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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private NielsenCBET _nielsenCbetSettings;
        private NielsenWatermarksDistributionTypes _nielsenDistributionType;
        private NielsenNaesIiNw _nielsenNaesIiNwSettings;

        /// <summary>
        /// Gets and sets the property NielsenCbetSettings. Complete these fields only if you
        /// want to insert watermarks of type Nielsen CBET
        /// </summary>
        public NielsenCBET NielsenCbetSettings
        {
            get { return this._nielsenCbetSettings; }
            set { this._nielsenCbetSettings = value; }
        }

        // Check to see if NielsenCbetSettings property is set
        internal bool IsSetNielsenCbetSettings()
        {
            return this._nielsenCbetSettings != null;
        }

        /// <summary>
        /// Gets and sets the property NielsenDistributionType. Choose the distribution types
        /// that you want to assign to the watermarks:- PROGRAM_CONTENT- FINAL_DISTRIBUTOR
        /// </summary>
        public NielsenWatermarksDistributionTypes NielsenDistributionType
        {
            get { return this._nielsenDistributionType; }
            set { this._nielsenDistributionType = value; }
        }

        // Check to see if NielsenDistributionType property is set
        internal bool IsSetNielsenDistributionType()
        {
            return this._nielsenDistributionType != null;
        }

        /// <summary>
        /// Gets and sets the property NielsenNaesIiNwSettings. Complete these fields only if
        /// you want to insert watermarks of type Nielsen NAES II (N2) and Nielsen NAES VI (NW).
        /// </summary>
        public NielsenNaesIiNw NielsenNaesIiNwSettings
        {
            get { return this._nielsenNaesIiNwSettings; }
            set { this._nielsenNaesIiNwSettings = value; }
        }

        // Check to see if NielsenNaesIiNwSettings property is set
        internal bool IsSetNielsenNaesIiNwSettings()
        {
            return this._nielsenNaesIiNwSettings != null;
        }

    }
}