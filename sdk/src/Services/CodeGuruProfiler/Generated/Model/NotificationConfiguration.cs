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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The configuration for notifications stored for each profiling group. This includes
    /// up to to two channels and a list of event publishers associated with each channel.
    /// </summary>
    public partial class NotificationConfiguration
    {
        private List<Channel> _channels = new List<Channel>();

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// List of up to two channels to be used for sending notifications for events detected
        /// from the application profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<Channel> Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels != null && this._channels.Count > 0; 
        }

    }
}