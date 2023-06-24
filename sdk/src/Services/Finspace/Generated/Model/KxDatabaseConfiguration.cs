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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The configuration of data that is available for querying from this database.
    /// </summary>
    public partial class KxDatabaseConfiguration
    {
        private List<KxDatabaseCacheConfiguration> _cacheConfigurations = new List<KxDatabaseCacheConfiguration>();
        private string _changesetId;
        private string _databaseName;

        /// <summary>
        /// Gets and sets the property CacheConfigurations. 
        /// <para>
        /// Configuration details for the disk cache used to increase performance reading from
        /// a kdb database mounted to the cluster.
        /// </para>
        /// </summary>
        public List<KxDatabaseCacheConfiguration> CacheConfigurations
        {
            get { return this._cacheConfigurations; }
            set { this._cacheConfigurations = value; }
        }

        // Check to see if CacheConfigurations property is set
        internal bool IsSetCacheConfigurations()
        {
            return this._cacheConfigurations != null && this._cacheConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChangesetId. 
        /// <para>
        /// A unique identifier of the changeset that is associated with the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string ChangesetId
        {
            get { return this._changesetId; }
            set { this._changesetId = value; }
        }

        // Check to see if ChangesetId property is set
        internal bool IsSetChangesetId()
        {
            return this._changesetId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the kdb database. When this parameter is specified in the structure, S3
        /// with the whole database is included by default.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

    }
}