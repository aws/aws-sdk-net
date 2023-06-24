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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// The failover configuration for an endpoint. This includes what triggers failover and
    /// what happens when it's triggered.
    /// </summary>
    public partial class FailoverConfig
    {
        private Primary _primary;
        private Secondary _secondary;

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// The main Region of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Primary Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary != null;
        }

        /// <summary>
        /// Gets and sets the property Secondary. 
        /// <para>
        /// The Region that events are routed to when failover is triggered or event replication
        /// is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Secondary Secondary
        {
            get { return this._secondary; }
            set { this._secondary = value; }
        }

        // Check to see if Secondary property is set
        internal bool IsSetSecondary()
        {
            return this._secondary != null;
        }

    }
}