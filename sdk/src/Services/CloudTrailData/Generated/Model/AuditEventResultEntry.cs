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
 * Do not modify this file. This file is generated from the cloudtrail-data-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrailData.Model
{
    /// <summary>
    /// A response that includes successful and failed event results.
    /// </summary>
    public partial class AuditEventResultEntry
    {
        private string _eventid;
        private string _id;

        /// <summary>
        /// Gets and sets the property EventID. 
        /// <para>
        /// The event ID assigned by CloudTrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string EventID
        {
            get { return this._eventid; }
            set { this._eventid = value; }
        }

        // Check to see if EventID property is set
        internal bool IsSetEventID()
        {
            return this._eventid != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The original event ID from the source event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}