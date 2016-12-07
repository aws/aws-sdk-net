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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// The capacity information for the fleet.
    /// </summary>
    public partial class ComputeCapacityStatus
    {
        private int? _available;
        private int? _desired;
        private int? _inUse;
        private int? _running;

        /// <summary>
        /// Gets and sets the property Available. 
        /// <para>
        /// The number of currently available instances that can be used to stream sessions.
        /// </para>
        /// </summary>
        public int Available
        {
            get { return this._available.GetValueOrDefault(); }
            set { this._available = value; }
        }

        // Check to see if Available property is set
        internal bool IsSetAvailable()
        {
            return this._available.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Desired. 
        /// <para>
        /// The desired number of streaming instances.
        /// </para>
        /// </summary>
        public int Desired
        {
            get { return this._desired.GetValueOrDefault(); }
            set { this._desired = value; }
        }

        // Check to see if Desired property is set
        internal bool IsSetDesired()
        {
            return this._desired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InUse. 
        /// <para>
        /// The number of instances that are being used for streaming.
        /// </para>
        /// </summary>
        public int InUse
        {
            get { return this._inUse.GetValueOrDefault(); }
            set { this._inUse = value; }
        }

        // Check to see if InUse property is set
        internal bool IsSetInUse()
        {
            return this._inUse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Running. 
        /// <para>
        /// The total number of simultaneous streaming instances that are running.
        /// </para>
        /// </summary>
        public int Running
        {
            get { return this._running.GetValueOrDefault(); }
            set { this._running = value; }
        }

        // Check to see if Running property is set
        internal bool IsSetRunning()
        {
            return this._running.HasValue; 
        }

    }
}