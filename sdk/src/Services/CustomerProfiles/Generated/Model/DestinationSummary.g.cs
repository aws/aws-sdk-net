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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Summary information about the Kinesis data stream
    /// </summary>
    public partial class DestinationSummary
    {
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of enabling the Kinesis stream as a destination for export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventStreamDestinationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UnhealthySince. 
        /// <para>
        /// The timestamp when the status last changed to <c>UNHEALHY</c>.
        /// </para>
        /// </summary>
        public DateTime? UnhealthySince { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthySince property is set.
        /// </summary>
        internal bool IsSetUnhealthySince() => this.UnhealthySince.HasValue;

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The StreamARN of the destination to deliver profile events to. For example, arn:aws:kinesis:region:account-id:stream/stream-name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;
    }
}
