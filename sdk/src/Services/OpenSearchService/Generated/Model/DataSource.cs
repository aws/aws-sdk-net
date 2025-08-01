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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Data sources that are associated with an OpenSearch application.
    /// </summary>
    public partial class DataSource
    {
        private string _dataSourceArn;
        private string _dataSourceDescription;

        /// <summary>
        /// Gets and sets the property DataSourceArn.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DataSourceArn
        {
            get { return this._dataSourceArn; }
            set { this._dataSourceArn = value; }
        }

        // Check to see if DataSourceArn property is set
        internal bool IsSetDataSourceArn()
        {
            return this._dataSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceDescription. 
        /// <para>
        /// Detailed description of a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string DataSourceDescription
        {
            get { return this._dataSourceDescription; }
            set { this._dataSourceDescription = value; }
        }

        // Check to see if DataSourceDescription property is set
        internal bool IsSetDataSourceDescription()
        {
            return this._dataSourceDescription != null;
        }

    }
}