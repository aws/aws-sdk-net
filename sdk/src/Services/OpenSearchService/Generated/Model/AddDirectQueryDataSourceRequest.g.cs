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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the AddDirectQueryDataSource operation. Adds a new
    /// data source in Amazon OpenSearch Service so that you can perform direct queries on
    /// external data.
    /// </summary>
    public partial class AddDirectQueryDataSourceRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DataSourceAccessPolicy. 
        /// <para>
        ///  An optional IAM access policy document that defines the permissions for accessing
        /// the data source. The policy document must be in valid JSON format and follow IAM policy
        /// syntax.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 102400)]
        public string DataSourceAccessPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceAccessPolicy property is set.
        /// </summary>
        internal bool IsSetDataSourceAccessPolicy() => this.DataSourceAccessPolicy != null;

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        ///  A unique, user-defined label to identify the data source within your OpenSearch Service
        /// environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 80)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceName property is set.
        /// </summary>
        internal bool IsSetDataSourceName() => this.DataSourceName != null;

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        ///  The supported Amazon Web Services service that you want to use as the source for
        /// direct queries in OpenSearch Service. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DirectQueryDataSourceType DataSourceType { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceType property is set.
        /// </summary>
        internal bool IsSetDataSourceType() => this.DataSourceType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  An optional text field for providing additional context and details about the data
        /// source. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property OpenSearchArns. 
        /// <para>
        ///  An optional list of Amazon Resource Names (ARNs) for the OpenSearch collections that
        /// are associated with the direct query data source. This field is required for CloudWatchLogs
        /// and SecurityLake datasource types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OpenSearchArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OpenSearchArns property is set.
        /// </summary>
        internal bool IsSetOpenSearchArns() => this.OpenSearchArns != null && (this.OpenSearchArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
