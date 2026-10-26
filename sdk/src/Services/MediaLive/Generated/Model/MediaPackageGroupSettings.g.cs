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
    /// Media Package Group Settings
    /// </summary>
    public partial class MediaPackageGroupSettings
    {
        /// <summary>
        /// Gets and sets the property Destination. MediaPackage channel destination.
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property MediapackageV2GroupSettings. Parameters that apply only
        /// if the destination parameter (for the output group) specifies a channelGroup and channelName.
        /// Use of these two paramters indicates that the output group is for MediaPackage V2
        /// (CMAF Ingest).
        /// </summary>
        public MediaPackageV2GroupSettings MediapackageV2GroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the MediapackageV2GroupSettings property is set.
        /// </summary>
        internal bool IsSetMediapackageV2GroupSettings() => this.MediapackageV2GroupSettings != null;
    }
}
