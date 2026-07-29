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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the PutStorageTierPolicy operation.
    /// </summary>
    public partial class PutStorageTierPolicyResponse : AmazonWebServiceResponse
    {
        private long? _lastUpdatedTime;
        private StorageTier _storageTier;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the storage tier policy was last updated, expressed as the number of
        /// milliseconds after <c>Jan 1, 1970 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageTier. 
        /// <para>
        /// The storage tier that was set.
        /// </para>
        /// </summary>
        public StorageTier StorageTier
        {
            get { return this._storageTier; }
            set { this._storageTier = value; }
        }

        // Check to see if StorageTier property is set
        internal bool IsSetStorageTier()
        {
            return this._storageTier != null;
        }

    }
}