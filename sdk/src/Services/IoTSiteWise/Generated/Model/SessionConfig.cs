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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains the session configuration for a session-type dataset.
    /// </summary>
    public partial class SessionConfig
    {
        private TimeInNanos _sessionEndTimestamp;
        private TimeInNanos _sessionStartTimestamp;

        /// <summary>
        /// Gets and sets the property SessionEndTimestamp. 
        /// <para>
        /// The nanosecond-precision end time of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeInNanos SessionEndTimestamp
        {
            get { return this._sessionEndTimestamp; }
            set { this._sessionEndTimestamp = value; }
        }

        // Check to see if SessionEndTimestamp property is set
        internal bool IsSetSessionEndTimestamp()
        {
            return this._sessionEndTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property SessionStartTimestamp. 
        /// <para>
        /// The nanosecond-precision start time of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeInNanos SessionStartTimestamp
        {
            get { return this._sessionStartTimestamp; }
            set { this._sessionStartTimestamp = value; }
        }

        // Check to see if SessionStartTimestamp property is set
        internal bool IsSetSessionStartTimestamp()
        {
            return this._sessionStartTimestamp != null;
        }

    }
}