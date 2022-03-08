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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the CancelQuery operation.
    /// Cancels a query if the query is not in a terminated state, such as <code>CANCELLED</code>,
    /// <code>FAILED</code>, <code>TIMED_OUT</code>, or <code>FINISHED</code>. You must specify
    /// an ARN value for <code>EventDataStore</code>. The ID of the query that you want to
    /// cancel is also required. When you run <code>CancelQuery</code>, the query status might
    /// show as <code>CANCELLED</code> even if the operation is not yet finished.
    /// </summary>
    public partial class CancelQueryRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;
        private string _queryId;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or the ID suffix of the ARN) of an event data store on which the specified
        /// query is running.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
        public string EventDataStore
        {
            get { return this._eventDataStore; }
            set { this._eventDataStore = value; }
        }

        // Check to see if EventDataStore property is set
        internal bool IsSetEventDataStore()
        {
            return this._eventDataStore != null;
        }

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of the query that you want to cancel. The <code>QueryId</code> comes from the
        /// response of a <code>StartQuery</code> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

    }
}