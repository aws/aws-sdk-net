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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Avail Configuration
    /// </summary>
    public partial class AvailConfiguration
    {
        private AvailSettings _availSettings;

        /// <summary>
        /// Gets and sets the property AvailSettings. Controls how SCTE-35 messages create cues.
        /// Splice Insert mode treats all segmentation signals traditionally. With Time Signal
        /// APOS mode only Time Signal Placement Opportunity and Break messages create segment
        /// breaks. With ESAM mode, signals are forwarded to an ESAM server for possible update.
        /// </summary>
        public AvailSettings AvailSettings
        {
            get { return this._availSettings; }
            set { this._availSettings = value; }
        }

        // Check to see if AvailSettings property is set
        internal bool IsSetAvailSettings()
        {
            return this._availSettings != null;
        }

    }
}