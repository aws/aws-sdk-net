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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// An asset property timestamp entry containing the following information.
    /// </summary>
    public partial class AssetPropertyTimestamp
    {
        /// <summary>
        /// Gets and sets the property OffsetInNanos. 
        /// <para>
        /// Optional. A string that contains the nanosecond time offset. Accepts substitution
        /// templates.
        /// </para>
        /// </summary>
        public string OffsetInNanos { get; set; }

        /// <summary>
        /// Checks to see if the OffsetInNanos property is set.
        /// </summary>
        internal bool IsSetOffsetInNanos() => this.OffsetInNanos != null;

        /// <summary>
        /// Gets and sets the property TimeInSeconds. 
        /// <para>
        /// A string that contains the time in seconds since epoch. Accepts substitution templates.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeInSeconds property is set.
        /// </summary>
        internal bool IsSetTimeInSeconds() => this.TimeInSeconds != null;
    }
}
