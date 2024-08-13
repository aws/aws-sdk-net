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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Summary information about the Kinesis data stream
    /// </summary>
    public partial class DestinationSummary
    {
        private EventStreamDestinationStatus _status;
        private DateTime? _unhealthySince;
        private string _uri;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of enabling the Kinesis stream as a destination for export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventStreamDestinationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UnhealthySince. 
        /// <para>
        /// The timestamp when the status last changed to <c>UNHEALHY</c>.
        /// </para>
        /// </summary>
        public DateTime? UnhealthySince
        {
            get { return this._unhealthySince; }
            set { this._unhealthySince = value; }
        }

        // Check to see if UnhealthySince property is set
        internal bool IsSetUnhealthySince()
        {
            return this._unhealthySince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The StreamARN of the destination to deliver profile events to. For example, arn:aws:kinesis:region:account-id:stream/stream-name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}