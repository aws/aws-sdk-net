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
    /// Container for the parameters to the StopMigration operation.
    /// Stops an ongoing data sync between the source and the serverless cache. The migration
    /// remains open and the data sync can be restarted. This operation is valid only while
    /// the migration is syncing; during cutover it returns <c>InvalidServerlessCacheStateFault</c>.
    /// </summary>
    public partial class StopMigrationRequest : AmazonElastiCacheRequest
    {
        private string _serverlessCacheName;

        /// <summary>
        /// Gets and sets the property ServerlessCacheName. 
        /// <para>
        /// The name of the serverless cache for which to stop the data sync.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServerlessCacheName
        {
            get { return this._serverlessCacheName; }
            set { this._serverlessCacheName = value; }
        }

        // Check to see if ServerlessCacheName property is set
        internal bool IsSetServerlessCacheName()
        {
            return this._serverlessCacheName != null;
        }

    }
}