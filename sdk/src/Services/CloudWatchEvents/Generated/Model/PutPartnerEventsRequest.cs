/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the PutPartnerEvents operation.
    /// This is used by SaaS partners to write events to a customer's partner event bus. AWS
    /// customers do not use this operation.
    /// </summary>
    public partial class PutPartnerEventsRequest : AmazonCloudWatchEventsRequest
    {
        private List<PutPartnerEventsRequestEntry> _entries = new List<PutPartnerEventsRequestEntry>();

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The list of events to write to the event bus.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<PutPartnerEventsRequestEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && this._entries.Count > 0; 
        }

    }
}