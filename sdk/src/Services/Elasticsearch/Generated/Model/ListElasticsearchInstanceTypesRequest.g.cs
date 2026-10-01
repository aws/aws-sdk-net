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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the ListElasticsearchInstanceTypes operation. List
    /// all Elasticsearch instance types that are supported for given ElasticsearchVersion
    /// </summary>
    public partial class ListElasticsearchInstanceTypesRequest : AmazonElasticsearchRequest
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// DomainName represents the name of the Domain that we are trying to modify. This should
        /// be present only if we are querying for list of available Elasticsearch instance types
        /// when modifying existing domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchVersion. 
        /// <para>
        /// Version of Elasticsearch for which list of supported elasticsearch instance types
        /// are needed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ElasticsearchVersion { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchVersion property is set.
        /// </summary>
        internal bool IsSetElasticsearchVersion() => this.ElasticsearchVersion != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Set this value to limit the number of results returned. Value provided must be greater
        /// than 30 else it wont be honored. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// NextToken should be sent in case if earlier API call produced result containing NextToken.
        /// It is used for pagination. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
