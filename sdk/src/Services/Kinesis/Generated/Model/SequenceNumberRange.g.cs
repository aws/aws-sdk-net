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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The range of possible sequence numbers for the shard.
    /// </summary>
    public partial class SequenceNumberRange
    {
        /// <summary>
        /// Gets and sets the property EndingSequenceNumber. 
        /// <para>
        /// The ending sequence number for the range. Shards that are in the OPEN state have an
        /// ending sequence number of <c>null</c>.
        /// </para>
        /// </summary>
        public string EndingSequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the EndingSequenceNumber property is set.
        /// </summary>
        internal bool IsSetEndingSequenceNumber() => this.EndingSequenceNumber != null;

        /// <summary>
        /// Gets and sets the property StartingSequenceNumber. 
        /// <para>
        /// The starting sequence number for the range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StartingSequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the StartingSequenceNumber property is set.
        /// </summary>
        internal bool IsSetStartingSequenceNumber() => this.StartingSequenceNumber != null;
    }
}
