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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for manifest processing rules. Manifest processing rules enable
    /// customization of the personalized manifests created by MediaTailor.
    /// </summary>
    public partial class ManifestProcessingRules
    {
        private AdMarkerPassthrough _adMarkerPassthrough;

        /// <summary>
        /// Gets and sets the property AdMarkerPassthrough.
        /// </summary>
        public AdMarkerPassthrough AdMarkerPassthrough
        {
            get { return this._adMarkerPassthrough; }
            set { this._adMarkerPassthrough = value; }
        }

        // Check to see if AdMarkerPassthrough property is set
        internal bool IsSetAdMarkerPassthrough()
        {
            return this._adMarkerPassthrough != null;
        }

    }
}