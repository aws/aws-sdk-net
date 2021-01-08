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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for F4v container
    /// </summary>
    public partial class F4vSettings
    {
        private F4vMoovPlacement _moovPlacement;

        /// <summary>
        /// Gets and sets the property MoovPlacement. If set to PROGRESSIVE_DOWNLOAD, the MOOV
        /// atom is relocated to the beginning of the archive as required for progressive downloading.
        /// Otherwise it is placed normally at the end.
        /// </summary>
        public F4vMoovPlacement MoovPlacement
        {
            get { return this._moovPlacement; }
            set { this._moovPlacement = value; }
        }

        // Check to see if MoovPlacement property is set
        internal bool IsSetMoovPlacement()
        {
            return this._moovPlacement != null;
        }

    }
}