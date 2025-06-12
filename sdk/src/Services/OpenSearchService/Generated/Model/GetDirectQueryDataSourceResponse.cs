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
    /// This is the response object from the GetDirectQueryDataSource operation.
    /// </summary>
    public partial class GetDirectQueryDataSourceResponse : AmazonWebServiceResponse
    {
        private string _dataSourceArn;
        private string _dataSourceName;
        private DirectQueryDataSourceType _dataSourceType;
        private string _description;
        private List<string> _openSearchArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        ///  The unique, system-generated identifier that represents the data source. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DataSourceName. 
        /// <para>
        ///  A unique, user-defined label to identify the data source within your OpenSearch Service
        /// environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=80)]
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
        /// Gets and sets the property DataSourceType. 
        /// <para>
        ///  The supported Amazon Web Services service that is used as the source for direct queries
        /// in OpenSearch Service. 
        /// </para>
        /// </summary>
        public DirectQueryDataSourceType DataSourceType
        {
            get { return this._dataSourceType; }
            set { this._dataSourceType = value; }
        }

        // Check to see if DataSourceType property is set
        internal bool IsSetDataSourceType()
        {
            return this._dataSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description that provides additional context and details about the data source.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property OpenSearchArns. 
        /// <para>
        ///  A list of Amazon Resource Names (ARNs) for the OpenSearch collections that are associated
        /// with the direct query data source. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OpenSearchArns
        {
            get { return this._openSearchArns; }
            set { this._openSearchArns = value; }
        }

        // Check to see if OpenSearchArns property is set
        internal bool IsSetOpenSearchArns()
        {
            return this._openSearchArns != null && (this._openSearchArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}