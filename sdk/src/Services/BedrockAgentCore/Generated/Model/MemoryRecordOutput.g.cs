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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Output information returned after processing a memory record operation.
    /// </summary>
    public partial class MemoryRecordOutput
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code returned when the memory record operation fails.
        /// </para>
        /// </summary>
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A human-readable error message describing why the memory record operation failed.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property MemoryRecordId. 
        /// <para>
        /// The unique ID associated to the memory record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 40, Max = 50)]
        public string MemoryRecordId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryRecordId property is set.
        /// </summary>
        internal bool IsSetMemoryRecordId() => this.MemoryRecordId != null;

        /// <summary>
        /// Gets and sets the property RequestIdentifier. 
        /// <para>
        /// The client-provided identifier that was used to track this record operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string RequestIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RequestIdentifier property is set.
        /// </summary>
        internal bool IsSetRequestIdentifier() => this.RequestIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the memory record operation (e.g., SUCCEEDED, FAILED).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryRecordStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
