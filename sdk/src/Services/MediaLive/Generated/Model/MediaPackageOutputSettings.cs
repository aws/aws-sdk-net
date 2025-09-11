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
    /// Media Package Output Settings
    /// </summary>
    public partial class MediaPackageOutputSettings
    {
        private MediaPackageV2DestinationSettings _mediaPackageV2DestinationSettings;

        /// <summary>
        /// Gets and sets the property MediaPackageV2DestinationSettings. Optional settings for
        /// MediaPackage V2 destinations
        /// </summary>
        public MediaPackageV2DestinationSettings MediaPackageV2DestinationSettings
        {
            get { return this._mediaPackageV2DestinationSettings; }
            set { this._mediaPackageV2DestinationSettings = value; }
        }

        // Check to see if MediaPackageV2DestinationSettings property is set
        internal bool IsSetMediaPackageV2DestinationSettings()
        {
            return this._mediaPackageV2DestinationSettings != null;
        }

    }
}