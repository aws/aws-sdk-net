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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// The <code>ConnectionSettings</code> data type.
    /// </summary>
    public partial class ConnectionSettings
    {
        private int? _idleTimeout;

        /// <summary>
        /// Gets and sets the property IdleTimeout. 
        /// <para>
        /// Specifies the time (in seconds) the connection is allowed to be idle (no data has
        /// been sent over the connection) before it is closed by the load balancer.
        /// </para>
        /// </summary>
        public int IdleTimeout
        {
            get { return this._idleTimeout.GetValueOrDefault(); }
            set { this._idleTimeout = value; }
        }

        // Check to see if IdleTimeout property is set
        internal bool IsSetIdleTimeout()
        {
            return this._idleTimeout.HasValue; 
        }

    }
}