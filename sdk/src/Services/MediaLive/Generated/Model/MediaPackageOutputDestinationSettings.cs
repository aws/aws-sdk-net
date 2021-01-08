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
    /// MediaPackage Output Destination Settings
    /// </summary>
    public partial class MediaPackageOutputDestinationSettings
    {
        private string _channelId;

        /// <summary>
        /// Gets and sets the property ChannelId. ID of the channel in MediaPackage that is the
        /// destination for this output group. You do not need to specify the individual inputs
        /// in MediaPackage; MediaLive will handle the connection of the two MediaLive pipelines
        /// to the two MediaPackage inputs. The MediaPackage channel and MediaLive channel must
        /// be in the same region.
        /// </summary>
        [AWSProperty(Min=1)]
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

    }
}