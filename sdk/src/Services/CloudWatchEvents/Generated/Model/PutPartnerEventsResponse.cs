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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// This is the response object from the PutPartnerEvents operation.
    /// </summary>
    public partial class PutPartnerEventsResponse : AmazonWebServiceResponse
    {
        private List<PutPartnerEventsResultEntry> _entries = new List<PutPartnerEventsResultEntry>();
        private int? _failedEntryCount;

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The list of events from this operation that were successfully written to the partner
        /// event bus.
        /// </para>
        /// </summary>
        public List<PutPartnerEventsResultEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && this._entries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailedEntryCount. 
        /// <para>
        /// The number of events from this operation that could not be written to the partner
        /// event bus.
        /// </para>
        /// </summary>
        public int FailedEntryCount
        {
            get { return this._failedEntryCount.GetValueOrDefault(); }
            set { this._failedEntryCount = value; }
        }

        // Check to see if FailedEntryCount property is set
        internal bool IsSetFailedEntryCount()
        {
            return this._failedEntryCount.HasValue; 
        }

    }
}