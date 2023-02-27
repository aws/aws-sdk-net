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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Represents an available endpoint against which to make API calls against, as well
    /// as the TTL for that endpoint.
    /// </summary>
    public partial class Endpoint
    {
        private string _address;
        private long? _cachePeriodInMinutes;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// An endpoint address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property CachePeriodInMinutes. 
        /// <para>
        /// The TTL for the endpoint, in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long CachePeriodInMinutes
        {
            get { return this._cachePeriodInMinutes.GetValueOrDefault(); }
            set { this._cachePeriodInMinutes = value; }
        }

        // Check to see if CachePeriodInMinutes property is set
        internal bool IsSetCachePeriodInMinutes()
        {
            return this._cachePeriodInMinutes.HasValue; 
        }

    }
}