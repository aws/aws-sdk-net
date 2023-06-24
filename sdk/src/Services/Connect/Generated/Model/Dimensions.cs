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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the dimensions for a set of metrics.
    /// </summary>
    public partial class Dimensions
    {
        private Channel _channel;
        private QueueReference _queue;
        private RoutingProfileReference _routingProfile;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel used for grouping and filters.
        /// </para>
        /// </summary>
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property Queue. 
        /// <para>
        /// Information about the queue for which metrics are returned.
        /// </para>
        /// </summary>
        public QueueReference Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingProfile.
        /// </summary>
        public RoutingProfileReference RoutingProfile
        {
            get { return this._routingProfile; }
            set { this._routingProfile = value; }
        }

        // Check to see if RoutingProfile property is set
        internal bool IsSetRoutingProfile()
        {
            return this._routingProfile != null;
        }

    }
}