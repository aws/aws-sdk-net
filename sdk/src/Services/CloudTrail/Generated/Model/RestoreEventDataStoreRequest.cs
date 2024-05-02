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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreEventDataStore operation.
    /// Restores a deleted event data store specified by <c>EventDataStore</c>, which accepts
    /// an event data store ARN. You can only restore a deleted event data store within the
    /// seven-day wait period after deletion. Restoring an event data store can take several
    /// minutes, depending on the size of the event data store.
    /// </summary>
    public partial class RestoreEventDataStoreRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or the ID suffix of the ARN) of the event data store that you want to restore.
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