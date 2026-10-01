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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
    /// System metadata for PutEvents entries. ContentType is not applicable (always application/eventbridge+json,
    /// set server-side).
    /// </summary>
    public partial class PutEventsSystemMetadata
    {
        private string _deduplicationId;
        private string _eventGroupId;

        /// <summary>
        /// Gets and sets the property DeduplicationId. 
        /// <para>
        /// Deduplication ID for FIFO deduplication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DeduplicationId
        {
            get { return this._deduplicationId; }
            set { this._deduplicationId = value; }
        }

        // Check to see if DeduplicationId property is set
        internal bool IsSetDeduplicationId()
        {
            return this._deduplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property EventGroupId. 
        /// <para>
        /// Event group ID for FIFO ordering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EventGroupId
        {
            get { return this._eventGroupId; }
            set { this._eventGroupId = value; }
        }

        // Check to see if EventGroupId property is set
        internal bool IsSetEventGroupId()
        {
            return this._eventGroupId != null;
        }

    }
}