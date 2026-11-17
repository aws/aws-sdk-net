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
    /// A dead-letter record whose visibility timeout is changed, and the new visibility timeout.
    /// </summary>
    public partial class UpdateDeadLetterQueueRecordsVisibilityRequestEntry
    {
        /// <summary>
        /// Gets and sets the property ReceiptHandle. 
        /// <para>
        /// The receipt handle of the record, as returned by <a>ReceiveDeadLetterQueueRecords</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ReceiptHandle { get; set; }

        /// <summary>
        /// Checks to see if the ReceiptHandle property is set.
        /// </summary>
        internal bool IsSetReceiptHandle() => this.ReceiptHandle != null;

        /// <summary>
        /// Gets and sets the property VisibilityTimeoutSeconds. 
        /// <para>
        /// The new duration, in seconds, that the record is in flight and not visible to any
        /// consumer instance, measured from when this request is processed. Specify <c>0</c>
        /// to make the record visible immediately.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 43200)]
        public int? VisibilityTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetVisibilityTimeoutSeconds() => this.VisibilityTimeoutSeconds.HasValue;
    }
}
