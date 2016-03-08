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
 * Do not modify this file. This file is generated from the events-2014-02-03.normal.json service model.
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
    /// Container for the parameters to the PutEvents operation.
    /// Sends custom events to Amazon CloudWatch Events so that they can be matched to rules.
    /// </summary>
    public partial class PutEventsRequest : AmazonCloudWatchEventsRequest
    {
        private List<PutEventsRequestEntry> _entries = new List<PutEventsRequestEntry>();

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The entry that defines an event in your system. You can specify several parameters
        /// for the entry such as the source and type of the event, resources associated with
        /// the event, and so on.
        /// </para>
        /// </summary>
        public List<PutEventsRequestEntry> Entries
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