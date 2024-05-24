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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Maps a particular data source sync job to a particular data source.
    /// </summary>
    public partial class DataSourceSyncJobMetricTarget
    {
        private string _dataSourceId;
        private string _dataSourceSyncJobId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID of the data source that is running the sync job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceSyncJobId. 
        /// <para>
        /// The ID of the sync job that is running on the data source.
        /// </para>
        ///  
        /// <para>
        /// If the ID of a sync job is not provided and there is a sync job running, then the
        /// ID of this sync job is used and metrics are generated for this sync job.
        /// </para>
        ///  
        /// <para>
        /// If the ID of a sync job is not provided and there is no sync job running, then no
        /// metrics are generated and documents are indexed/deleted at the index level without
        /// sync job metrics included.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DataSourceSyncJobId
        {
            get { return this._dataSourceSyncJobId; }
            set { this._dataSourceSyncJobId = value; }
        }

        // Check to see if DataSourceSyncJobId property is set
        internal bool IsSetDataSourceSyncJobId()
        {
            return this._dataSourceSyncJobId != null;
        }

    }
}