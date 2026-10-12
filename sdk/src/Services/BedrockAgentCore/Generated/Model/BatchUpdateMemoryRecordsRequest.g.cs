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
    /// Container for the parameters to the BatchUpdateMemoryRecords operation. Updates multiple
    /// memory records with custom content in a single batch operation within the specified
    /// memory.
    /// </summary>
    public partial class BatchUpdateMemoryRecordsRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The unique ID of the memory resource where records will be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property RecordExpirySpecification. 
        /// <para>
        /// The record expiry (long-term memory time-to-live) applied to every record updated
        /// by this request. Set <c>recordExpiryDurationDays</c> to configure or overwrite the
        /// number of days after which the records expire, or set <c>action</c> to <c>REMOVE</c>
        /// to clear a previously configured expiry so that the records no longer expire.
        /// </para>
        ///  
        /// <para>
        /// When you do not provide this value, the service determines each record's expiry from
        /// its current state:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the record already has an expiry configured, the service resets and reapplies the
        /// expiry based on the last applied <c>recordExpiryDurationDays</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the record does not have an expiry configured, no expiry is applied and the record
        /// remains non-expiring. This is the outcome regardless of whether the record's strategy
        /// configures an expiry.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Providing an explicit <c>recordExpiryDurationDays</c> always takes precedence: it
        /// overwrites an existing expiry, or sets one on a record that previously had none.
        /// </para>
        /// </summary>
        public RecordExpirySpecification RecordExpirySpecification { get; set; }

        /// <summary>
        /// Checks to see if the RecordExpirySpecification property is set.
        /// </summary>
        internal bool IsSetRecordExpirySpecification() => this.RecordExpirySpecification != null;

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// A list of memory record update inputs to be processed in the batch operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<MemoryRecordUpdateInput> Records { get; set; } = AWSConfigs.InitializeCollections ? new List<MemoryRecordUpdateInput>() : null;

        /// <summary>
        /// Checks to see if the Records property is set.
        /// </summary>
        internal bool IsSetRecords() => this.Records != null && (this.Records.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
