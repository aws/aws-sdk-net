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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Connect.Model
{
    /// <summary>
    /// An object to specify the expiration of a routing step.
    /// </summary>
    public partial class Expiry
    {
        private int? _durationInSeconds;
        private DateTime? _expiryTimestamp;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The number of seconds to wait before expiring the routing step.
        /// </para>
        /// </summary>
        public int? DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiryTimestamp. 
        /// <para>
        /// The timestamp indicating when the routing step expires.
        /// </para>
        /// </summary>
        public DateTime? ExpiryTimestamp
        {
            get { return this._expiryTimestamp; }
            set { this._expiryTimestamp = value; }
        }

        // Check to see if ExpiryTimestamp property is set
        internal bool IsSetExpiryTimestamp()
        {
            return this._expiryTimestamp.HasValue; 
        }

    }
}