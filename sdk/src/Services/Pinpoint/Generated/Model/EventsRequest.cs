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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Put Events request
    /// </summary>
    public partial class EventsRequest
    {
        private Dictionary<string, EventsBatch> _batchItem = new Dictionary<string, EventsBatch>();

        /// <summary>
        /// Gets and sets the property BatchItem. Batch of events with endpoint id as the key
        /// and an object of EventsBatch as value. The EventsBatch object has the PublicEndpoint
        /// and a map of event Id's to events
        /// </summary>
        public Dictionary<string, EventsBatch> BatchItem
        {
            get { return this._batchItem; }
            set { this._batchItem = value; }
        }

        // Check to see if BatchItem property is set
        internal bool IsSetBatchItem()
        {
            return this._batchItem != null && this._batchItem.Count > 0; 
        }

    }
}