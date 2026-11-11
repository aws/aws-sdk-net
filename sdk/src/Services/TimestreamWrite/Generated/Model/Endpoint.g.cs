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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Represents an available endpoint against which to make API calls against, as well
    /// as the TTL for that endpoint.
    /// </summary>
    public partial class Endpoint
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// An endpoint address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property CachePeriodInMinutes. 
        /// <para>
        /// The TTL for the endpoint, in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? CachePeriodInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the CachePeriodInMinutes property is set.
        /// </summary>
        internal bool IsSetCachePeriodInMinutes() => this.CachePeriodInMinutes.HasValue;
    }
}
