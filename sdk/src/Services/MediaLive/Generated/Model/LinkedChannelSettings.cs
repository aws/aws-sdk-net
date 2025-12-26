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
    /// Configuration for linked channel relationships
    /// </summary>
    public partial class LinkedChannelSettings
    {
        private FollowerChannelSettings _followerChannelSettings;
        private PrimaryChannelSettings _primaryChannelSettings;

        /// <summary>
        /// Gets and sets the property FollowerChannelSettings.
        /// </summary>
        public FollowerChannelSettings FollowerChannelSettings
        {
            get { return this._followerChannelSettings; }
            set { this._followerChannelSettings = value; }
        }

        // Check to see if FollowerChannelSettings property is set
        internal bool IsSetFollowerChannelSettings()
        {
            return this._followerChannelSettings != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryChannelSettings.
        /// </summary>
        public PrimaryChannelSettings PrimaryChannelSettings
        {
            get { return this._primaryChannelSettings; }
            set { this._primaryChannelSettings = value; }
        }

        // Check to see if PrimaryChannelSettings property is set
        internal bool IsSetPrimaryChannelSettings()
        {
            return this._primaryChannelSettings != null;
        }

    }
}