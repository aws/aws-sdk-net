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
    /// Container for the parameters to the DeleteEventDataStore operation.
    /// Disables the event data store specified by <code>EventDataStore</code>, which accepts
    /// an event data store ARN. After you run <code>DeleteEventDataStore</code>, the event
    /// data store enters a <code>PENDING_DELETION</code> state, and is automatically deleted
    /// after a wait period of seven days. <code>TerminationProtectionEnabled</code> must
    /// be set to <code>False</code> on the event data store; this operation cannot work if
    /// <code>TerminationProtectionEnabled</code> is <code>True</code>.
    /// 
    ///  
    /// <para>
    /// After you run <code>DeleteEventDataStore</code> on an event data store, you cannot
    /// run <code>ListQueries</code>, <code>DescribeQuery</code>, or <code>GetQueryResults</code>
    /// on queries that are using an event data store in a <code>PENDING_DELETION</code> state.
    /// An event data store in the <code>PENDING_DELETION</code> state does not incur costs.
    /// </para>
    /// </summary>
    public partial class DeleteEventDataStoreRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or the ID suffix of the ARN) of the event data store to delete.
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

    }
}