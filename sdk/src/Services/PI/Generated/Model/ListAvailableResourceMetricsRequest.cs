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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// Container for the parameters to the ListAvailableResourceMetrics operation.
    /// Retrieve metrics of the specified types that can be queried for a specified DB instance.
    /// </summary>
    public partial class ListAvailableResourceMetricsRequest : AmazonPIRequest
    {
        private string _identifier;
        private int? _maxResults;
        private List<string> _metricTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextToken;
        private ServiceType _serviceType;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An immutable identifier for a data source that is unique within an Amazon Web Services
        /// Region. Performance Insights gathers metrics from this data source. To use an Amazon
        /// RDS DB instance as a data source, specify its <c>DbiResourceId</c> value. For example,
        /// specify <c>db-ABCDEFGHIJKLMNOPQRSTU1VWZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return. If the <c>MaxRecords</c> value is less than
        /// the number of existing items, the response includes a pagination token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
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
        /// Gets and sets the property MetricTypes. 
        /// <para>
        /// The types of metrics to return in the response. Valid values in the array include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>os</c> (OS counter metrics) - All engines
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db</c> (DB load metrics) - All engines except for Amazon DocumentDB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.sql.stats</c> (per-SQL metrics) - All engines except for Amazon DocumentDB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.sql_tokenized.stats</c> (per-SQL digest metrics) - All engines except for Amazon
        /// DocumentDB
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> MetricTypes
        {
            get { return this._metricTypes; }
            set { this._metricTypes = value; }
        }

        // Check to see if MetricTypes property is set
        internal bool IsSetMetricTypes()
        {
            return this._metricTypes != null && (this._metricTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the token, up to the value specified
        /// by <c>MaxRecords</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The Amazon Web Services service for which Performance Insights returns metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceType ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

    }
}