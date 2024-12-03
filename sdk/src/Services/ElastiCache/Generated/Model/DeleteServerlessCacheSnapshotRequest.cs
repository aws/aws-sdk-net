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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteServerlessCacheSnapshot operation.
    /// Deletes an existing serverless cache snapshot. Available for Valkey, Redis OSS and
    /// Serverless Memcached only.
    /// </summary>
    public partial class DeleteServerlessCacheSnapshotRequest : AmazonElastiCacheRequest
    {
        private string _serverlessCacheSnapshotName;

        /// <summary>
        /// Gets and sets the property ServerlessCacheSnapshotName. 
        /// <para>
        /// Idenfitier of the snapshot to be deleted. Available for Valkey, Redis OSS and Serverless
        /// Memcached only.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServerlessCacheSnapshotName
        {
            get { return this._serverlessCacheSnapshotName; }
            set { this._serverlessCacheSnapshotName = value; }
        }

        // Check to see if ServerlessCacheSnapshotName property is set
        internal bool IsSetServerlessCacheSnapshotName()
        {
            return this._serverlessCacheSnapshotName != null;
        }

    }
}