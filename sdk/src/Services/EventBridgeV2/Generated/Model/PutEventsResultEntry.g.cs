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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Result entry for a published event. The position of each entry in the response list
    /// aligns 1:1 with the corresponding request entry.
    /// </summary>
    public partial class PutEventsResultEntry
    {
        /// <summary>
        /// Gets and sets the property ErrorCode.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property EventId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property SequenceNumber.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber != null;

        /// <summary>
        /// Gets and sets the property SuccessCode.
        /// </summary>
        public SuccessCode SuccessCode { get; set; }

        /// <summary>
        /// Checks to see if the SuccessCode property is set.
        /// </summary>
        internal bool IsSetSuccessCode() => this.SuccessCode != null;
    }
}
