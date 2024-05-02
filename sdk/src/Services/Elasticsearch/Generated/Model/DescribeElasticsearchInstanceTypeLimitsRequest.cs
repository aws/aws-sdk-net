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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
    /// Container for the parameters to the DescribeElasticsearchInstanceTypeLimits operation.
    /// Describe Elasticsearch Limits for a given InstanceType and ElasticsearchVersion.
    /// When modifying existing Domain, specify the <c> <a>DomainName</a> </c> to know what
    /// Limits are supported for modifying.
    /// </summary>
    public partial class DescribeElasticsearchInstanceTypeLimitsRequest : AmazonElasticsearchRequest
    {
        private string _domainName;
        private string _elasticsearchVersion;
        private ESPartitionInstanceType _instanceType;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  DomainName represents the name of the Domain that we are trying to modify. This should
        /// be present only if we are querying for Elasticsearch <c> <a>Limits</a> </c> for existing
        /// domain. 
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
        /// Gets and sets the property ElasticsearchVersion. 
        /// <para>
        ///  Version of Elasticsearch for which <c> <a>Limits</a> </c> are needed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ElasticsearchVersion
        {
            get { return this._elasticsearchVersion; }
            set { this._elasticsearchVersion = value; }
        }

        // Check to see if ElasticsearchVersion property is set
        internal bool IsSetElasticsearchVersion()
        {
            return this._elasticsearchVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The instance type for an Elasticsearch cluster for which Elasticsearch <c> <a>Limits</a>
        /// </c> are needed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ESPartitionInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

    }
}