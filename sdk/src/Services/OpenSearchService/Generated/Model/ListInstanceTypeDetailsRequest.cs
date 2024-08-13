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
    /// Container for the parameters to the ListInstanceTypeDetails operation.
    /// Lists all instance types and available features for a given OpenSearch or Elasticsearch
    /// version.
    /// </summary>
    public partial class ListInstanceTypeDetailsRequest : AmazonOpenSearchServiceRequest
    {
        private string _domainName;
        private string _engineVersion;
        private string _instanceType;
        private int? _maxResults;
        private string _nextToken;
        private bool? _retrieveAZs;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=28)]
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of OpenSearch or Elasticsearch, in the format Elasticsearch_X.Y or OpenSearch_X.Y.
        /// Defaults to the latest version of OpenSearch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=18)]
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// An optional parameter that lists information for a given instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=40)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional parameter that specifies the maximum number of results to return. You
        /// can use <c>nextToken</c> to get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If your initial <c>ListInstanceTypeDetails</c> operation returns a <c>nextToken</c>,
        /// you can include the returned <c>nextToken</c> in subsequent <c>ListInstanceTypeDetails</c>
        /// operations, which returns results in the next page.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RetrieveAZs. 
        /// <para>
        /// An optional parameter that specifies the Availability Zones for the domain.
        /// </para>
        /// </summary>
        public bool? RetrieveAZs
        {
            get { return this._retrieveAZs; }
            set { this._retrieveAZs = value; }
        }

        // Check to see if RetrieveAZs property is set
        internal bool IsSetRetrieveAZs()
        {
            return this._retrieveAZs.HasValue; 
        }

    }
}