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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// Tunnel timeout configuration.
    /// </summary>
    public partial class TimeoutConfig
    {
        private int? _maxLifetimeTimeoutMinutes;

        /// <summary>
        /// Gets and sets the property MaxLifetimeTimeoutMinutes. 
        /// <para>
        /// The maximum amount of time (in minutes) a tunnel can remain open. If not specified,
        /// maxLifetimeTimeoutMinutes defaults to 720 minutes. Valid values are from 1 minute
        /// to 12 hours (720 minutes) 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=720)]
        public int MaxLifetimeTimeoutMinutes
        {
            get { return this._maxLifetimeTimeoutMinutes.GetValueOrDefault(); }
            set { this._maxLifetimeTimeoutMinutes = value; }
        }

        // Check to see if MaxLifetimeTimeoutMinutes property is set
        internal bool IsSetMaxLifetimeTimeoutMinutes()
        {
            return this._maxLifetimeTimeoutMinutes.HasValue; 
        }

    }
}