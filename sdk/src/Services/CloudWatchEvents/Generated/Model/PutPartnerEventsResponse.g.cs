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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// This is the response object from the PutPartnerEvents operation.
    /// </summary>
    public partial class PutPartnerEventsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The list of events from this operation that were successfully written to the partner
        /// event bus.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PutPartnerEventsResultEntry> Entries { get; set; } = AWSConfigs.InitializeCollections ? new List<PutPartnerEventsResultEntry>() : null;

        /// <summary>
        /// Checks to see if the Entries property is set.
        /// </summary>
        internal bool IsSetEntries() => this.Entries != null && (this.Entries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailedEntryCount. 
        /// <para>
        /// The number of events from this operation that could not be written to the partner
        /// event bus.
        /// </para>
        /// </summary>
        public int? FailedEntryCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedEntryCount property is set.
        /// </summary>
        internal bool IsSetFailedEntryCount() => this.FailedEntryCount.HasValue;
    }
}
