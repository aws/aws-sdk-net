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
    /// Media Package Group Settings
    /// </summary>
    public partial class MediaPackageGroupSettings
    {
        private OutputLocationRef _destination;
        private MediaPackageV2GroupSettings _mediapackageV2GroupSettings;

        /// <summary>
        /// Gets and sets the property Destination. MediaPackage channel destination.
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputLocationRef Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property MediapackageV2GroupSettings. Parameters that apply only
        /// if the destination parameter (for the output group) specifies a channelGroup and channelName.
        /// Use of these two paramters indicates that the output group is for MediaPackage V2
        /// (CMAF Ingest).
        /// </summary>
        public MediaPackageV2GroupSettings MediapackageV2GroupSettings
        {
            get { return this._mediapackageV2GroupSettings; }
            set { this._mediapackageV2GroupSettings = value; }
        }

        // Check to see if MediapackageV2GroupSettings property is set
        internal bool IsSetMediapackageV2GroupSettings()
        {
            return this._mediapackageV2GroupSettings != null;
        }

    }
}