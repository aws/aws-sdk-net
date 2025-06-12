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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBRecommendations operation.
    /// Describes the recommendations to resolve the issues for your DB instances, DB clusters,
    /// and DB parameter groups.
    /// </summary>
    public partial class DescribeDBRecommendationsRequest : AmazonRDSRequest
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private DateTime? _lastUpdatedAfter;
        private DateTime? _lastUpdatedBefore;
        private string _locale;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies one or more recommendations to describe.
        /// </para>
        ///  
        /// <para>
        /// Supported Filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>recommendation-id</c> - Accepts a list of recommendation identifiers. The results
        /// list only includes the recommendations whose identifier is one of the specified filter
        /// values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> - Accepts a list of recommendation statuses.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c> - The recommendations which are ready for you to apply.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c> - The applied or scheduled recommendations which are in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolved</c> - The recommendations which are completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dismissed</c> - The recommendations that you dismissed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The results list only includes the recommendations whose status is one of the specified
        /// filter values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>severity</c> - Accepts a list of recommendation severities. The results list only
        /// includes the recommendations whose severity is one of the specified filter values.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>high</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>medium</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>low</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>informational</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>type-id</c> - Accepts a list of recommendation type identifiers. The results list
        /// only includes the recommendations whose type is one of the specified filter values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dbi-resource-id</c> - Accepts a list of database resource identifiers. The results
        /// list only includes the recommendations that generated for the specified databases.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cluster-resource-id</c> - Accepts a list of cluster resource identifiers. The
        /// results list only includes the recommendations that generated for the specified clusters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pg-arn</c> - Accepts a list of parameter group ARNs. The results list only includes
        /// the recommendations that generated for the specified parameter groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cluster-pg-arn</c> - Accepts a list of cluster parameter group ARNs. The results
        /// list only includes the recommendations that generated for the specified cluster parameter
        /// groups.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAfter. 
        /// <para>
        /// A filter to include only the recommendations that were updated after this specified
        /// time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAfter
        {
            get { return this._lastUpdatedAfter; }
            set { this._lastUpdatedAfter = value; }
        }

        // Check to see if LastUpdatedAfter property is set
        internal bool IsSetLastUpdatedAfter()
        {
            return this._lastUpdatedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBefore. 
        /// <para>
        /// A filter to include only the recommendations that were updated before this specified
        /// time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedBefore
        {
            get { return this._lastUpdatedBefore; }
            set { this._lastUpdatedBefore = value; }
        }

        // Check to see if LastUpdatedBefore property is set
        internal bool IsSetLastUpdatedBefore()
        {
            return this._lastUpdatedBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The language that you choose to return the list of recommendations.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>en</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>en_UK</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>de</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>es</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fr</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>it</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ja</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ko</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pt_BR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh_TW</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh_CN</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeDBRecommendations</c>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <c>MaxRecords</c>. 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of recommendations to include in the response. If more records
        /// exist than the specified <c>MaxRecords</c> value, a pagination token called a marker
        /// is included in the response so that you can retrieve the remaining results.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

    }
}