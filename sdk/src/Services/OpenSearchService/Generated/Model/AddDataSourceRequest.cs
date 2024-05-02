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
    /// Container for the parameters to the AddDataSource operation.
    /// Creates a new direct-query data source to the specified domain. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3-creating.html">Creating
    /// Amazon OpenSearch Service data source integrations with Amazon S3</a>.
    /// </summary>
    public partial class AddDataSourceRequest : AmazonOpenSearchServiceRequest
    {
        private DataSourceType _dataSourceType;
        private string _description;
        private string _domainName;
        private string _name;

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The type of data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceType DataSourceType
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
        /// A description of the data source.
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain to add the data source to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=80)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}