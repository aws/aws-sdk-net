/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Settings for the require check in feature that are applied to a room profile. Require
    /// check in allows a meeting room’s Alexa or AVS device to prompt the user to check in;
    /// otherwise, the room will be released.
    /// </summary>
    public partial class RequireCheckIn
    {
        private bool? _enabled;
        private int? _releaseAfterMinutes;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether require check in is enabled or not.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReleaseAfterMinutes. 
        /// <para>
        /// Duration between 5 and 20 minutes to determine when to release the room if it's not
        /// checked into. 
        /// </para>
        /// </summary>
        public int ReleaseAfterMinutes
        {
            get { return this._releaseAfterMinutes.GetValueOrDefault(); }
            set { this._releaseAfterMinutes = value; }
        }

        // Check to see if ReleaseAfterMinutes property is set
        internal bool IsSetReleaseAfterMinutes()
        {
            return this._releaseAfterMinutes.HasValue; 
        }

    }
}