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
    /// This structure contains information about the OpenSearch Service data source used
    /// for this integration. This data source was created as part of the integration setup.
    /// An OpenSearch Service data source defines the source and destination for OpenSearch
    /// Service queries. It includes the role required to execute queries and write to collections.
    /// 
    ///  
    /// <para>
    /// For more information about OpenSearch Service data sources , see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3-creating.html">Creating
    /// OpenSearch Service data source integrations with Amazon S3.</a> 
    /// </para>
    /// </summary>
    public partial class OpenSearchDataSource
    {
        private string _dataSourceName;
        private OpenSearchResourceStatus _status;

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// The name of the OpenSearch Service data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DataSourceName
        {
            get { return this._dataSourceName; }
            set { this._dataSourceName = value; }
        }

        // Check to see if DataSourceName property is set
        internal bool IsSetDataSourceName()
        {
            return this._dataSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This structure contains information about the status of this OpenSearch Service resource.
        /// </para>
        /// </summary>
        public OpenSearchResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}