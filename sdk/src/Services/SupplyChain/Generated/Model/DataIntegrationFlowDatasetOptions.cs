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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The dataset options used in dataset source and target configurations.
    /// </summary>
    public partial class DataIntegrationFlowDatasetOptions
    {
        private bool? _dedupeRecords;
        private DataIntegrationFlowDedupeStrategy _dedupeStrategy;
        private DataIntegrationFlowLoadType _loadType;

        /// <summary>
        /// Gets and sets the property DedupeRecords. 
        /// <para>
        /// The option to perform deduplication on data records sharing same primary key values.
        /// If disabled, transformed data with duplicate primary key values will ingest into dataset,
        /// for datasets within <b>asc</b> namespace, such duplicates will cause ingestion fail.
        /// If enabled without dedupeStrategy, deduplication is done by retaining a random data
        /// record among those sharing the same primary key values. If enabled with dedupeStragtegy,
        /// the deduplication is done following the strategy.
        /// </para>
        ///  
        /// <para>
        /// Note that target dataset may have partition configured, when dedupe is enabled, it
        /// only dedupe against primary keys and retain only one record out of those duplicates
        /// regardless of its partition status.
        /// </para>
        /// </summary>
        public bool? DedupeRecords
        {
            get { return this._dedupeRecords; }
            set { this._dedupeRecords = value; }
        }

        // Check to see if DedupeRecords property is set
        internal bool IsSetDedupeRecords()
        {
            return this._dedupeRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DedupeStrategy. 
        /// <para>
        /// The deduplication strategy to dedupe the data records sharing same primary key values
        /// of the target dataset. This strategy only applies to target dataset with primary keys
        /// and with dedupeRecords option enabled. If transformed data still got duplicates after
        /// the dedupeStrategy evaluation, a random data record is chosen to be retained.
        /// </para>
        /// </summary>
        public DataIntegrationFlowDedupeStrategy DedupeStrategy
        {
            get { return this._dedupeStrategy; }
            set { this._dedupeStrategy = value; }
        }

        // Check to see if DedupeStrategy property is set
        internal bool IsSetDedupeStrategy()
        {
            return this._dedupeStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property LoadType. 
        /// <para>
        /// The target dataset's data load type. This only affects how source S3 files are selected
        /// in the S3-to-dataset flow.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>REPLACE</b> - Target dataset will get replaced with the new file added under the
        /// source s3 prefix.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>INCREMENTAL</b> - Target dataset will get updated with the up-to-date content
        /// under S3 prefix incorporating any file additions or removals there.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataIntegrationFlowLoadType LoadType
        {
            get { return this._loadType; }
            set { this._loadType = value; }
        }

        // Check to see if LoadType property is set
        internal bool IsSetLoadType()
        {
            return this._loadType != null;
        }

    }
}