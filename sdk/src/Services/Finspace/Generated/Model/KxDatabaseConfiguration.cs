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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The configuration of data that is available for querying from this database.
    /// </summary>
    public partial class KxDatabaseConfiguration
    {
        private List<KxDatabaseCacheConfiguration> _cacheConfigurations = AWSConfigs.InitializeCollections ? new List<KxDatabaseCacheConfiguration>() : null;
        private string _changesetId;
        private string _databaseName;
        private KxDataviewConfiguration _dataviewConfiguration;
        private string _dataviewName;

        /// <summary>
        /// Gets and sets the property CacheConfigurations. 
        /// <para>
        /// Configuration details for the disk cache used to increase performance reading from
        /// a kdb database mounted to the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KxDatabaseCacheConfiguration> CacheConfigurations
        {
            get { return this._cacheConfigurations; }
            set { this._cacheConfigurations = value; }
        }

        // Check to see if CacheConfigurations property is set
        internal bool IsSetCacheConfigurations()
        {
            return this._cacheConfigurations != null && (this._cacheConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property DataviewConfiguration. 
        /// <para>
        ///  The configuration of the dataview to be used with specified cluster. 
        /// </para>
        /// </summary>
        public KxDataviewConfiguration DataviewConfiguration
        {
            get { return this._dataviewConfiguration; }
            set { this._dataviewConfiguration = value; }
        }

        // Check to see if DataviewConfiguration property is set
        internal bool IsSetDataviewConfiguration()
        {
            return this._dataviewConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DataviewName. 
        /// <para>
        ///  The name of the dataview to be used for caching historical data on disk. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string DataviewName
        {
            get { return this._dataviewName; }
            set { this._dataviewName = value; }
        }

        // Check to see if DataviewName property is set
        internal bool IsSetDataviewName()
        {
            return this._dataviewName != null;
        }

    }
}