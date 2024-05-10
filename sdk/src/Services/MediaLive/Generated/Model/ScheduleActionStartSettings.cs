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
    /// Settings to specify when an action should occur. Only one of the options must be selected.
    /// </summary>
    public partial class ScheduleActionStartSettings
    {
        private FixedModeScheduleActionStartSettings _fixedModeScheduleActionStartSettings;
        private FollowModeScheduleActionStartSettings _followModeScheduleActionStartSettings;
        private ImmediateModeScheduleActionStartSettings _immediateModeScheduleActionStartSettings;

        /// <summary>
        /// Gets and sets the property FixedModeScheduleActionStartSettings. Option for specifying
        /// the start time for an action.
        /// </summary>
        public FixedModeScheduleActionStartSettings FixedModeScheduleActionStartSettings
        {
            get { return this._fixedModeScheduleActionStartSettings; }
            set { this._fixedModeScheduleActionStartSettings = value; }
        }

        // Check to see if FixedModeScheduleActionStartSettings property is set
        internal bool IsSetFixedModeScheduleActionStartSettings()
        {
            return this._fixedModeScheduleActionStartSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FollowModeScheduleActionStartSettings. Option for specifying
        /// an action as relative to another action.
        /// </summary>
        public FollowModeScheduleActionStartSettings FollowModeScheduleActionStartSettings
        {
            get { return this._followModeScheduleActionStartSettings; }
            set { this._followModeScheduleActionStartSettings = value; }
        }

        // Check to see if FollowModeScheduleActionStartSettings property is set
        internal bool IsSetFollowModeScheduleActionStartSettings()
        {
            return this._followModeScheduleActionStartSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ImmediateModeScheduleActionStartSettings. Option for specifying
        /// an action that should be applied immediately.
        /// </summary>
        public ImmediateModeScheduleActionStartSettings ImmediateModeScheduleActionStartSettings
        {
            get { return this._immediateModeScheduleActionStartSettings; }
            set { this._immediateModeScheduleActionStartSettings = value; }
        }

        // Check to see if ImmediateModeScheduleActionStartSettings property is set
        internal bool IsSetImmediateModeScheduleActionStartSettings()
        {
            return this._immediateModeScheduleActionStartSettings != null;
        }

    }
}