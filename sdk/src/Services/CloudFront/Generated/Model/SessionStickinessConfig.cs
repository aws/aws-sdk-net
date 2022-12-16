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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Session stickiness provides the ability to define multiple requests from a single
    /// viewer as a single session. This prevents the potentially inconsistent experience
    /// of sending some of a given user's requests to your staging distribution, while others
    /// are sent to your primary distribution. Define the session duration using TTL values.
    /// </summary>
    public partial class SessionStickinessConfig
    {
        private int? _idleTTL;
        private int? _maximumTTL;

        /// <summary>
        /// Gets and sets the property IdleTTL. 
        /// <para>
        /// The amount of time after which you want sessions to cease if no requests are received.
        /// Allowed values are 300–3600 seconds (5–60 minutes).
        /// </para>
        ///  
        /// <para>
        /// The value must be less than or equal to <code>MaximumTTL</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int IdleTTL
        {
            get { return this._idleTTL.GetValueOrDefault(); }
            set { this._idleTTL = value; }
        }

        // Check to see if IdleTTL property is set
        internal bool IsSetIdleTTL()
        {
            return this._idleTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumTTL. 
        /// <para>
        /// The maximum amount of time to consider requests from the viewer as being part of the
        /// same session. Allowed values are 300–3600 seconds (5–60 minutes).
        /// </para>
        ///  
        /// <para>
        /// The value must be less than or equal to <code>IdleTTL</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MaximumTTL
        {
            get { return this._maximumTTL.GetValueOrDefault(); }
            set { this._maximumTTL = value; }
        }

        // Check to see if MaximumTTL property is set
        internal bool IsSetMaximumTTL()
        {
            return this._maximumTTL.HasValue; 
        }

    }
}