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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBRecommendations operation.
    /// Describes the recommendations to resolve the issues for your DB instances, DB clusters,
    /// and DB parameter groups.
    /// </summary>
    public partial class DescribeDBRecommendationsRequest : AmazonRDSRequest
    {
        private List<Filter> _filters = new List<Filter>();
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
        ///  <code>recommendation-id</code> - Accepts a list of recommendation identifiers. The
        /// results list only includes the recommendations whose identifier is one of the specified
        /// filter values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status</code> - Accepts a list of recommendation statuses.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>active</code> - The recommendations which are ready for you to apply.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending</code> - The applied or scheduled recommendations which are in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resolved</code> - The recommendations which are completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dismissed</code> - The recommendations that you dismissed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The results list only includes the recommendations whose status is one of the specified
        /// filter values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>severity</code> - Accepts a list of recommendation severities. The results
        /// list only includes the recommendations whose severity is one of the specified filter
        /// values.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>high</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>medium</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>low</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>informational</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>type-id</code> - Accepts a list of recommendation type identifiers. The results
        /// list only includes the recommendations whose type is one of the specified filter values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dbi-resource-id</code> - Accepts a list of database resource identifiers. The
        /// results list only includes the recommendations that generated for the specified databases.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cluster-resource-id</code> - Accepts a list of cluster resource identifiers.
        /// The results list only includes the recommendations that generated for the specified
        /// clusters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pg-arn</code> - Accepts a list of parameter group ARNs. The results list only
        /// includes the recommendations that generated for the specified parameter groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cluster-pg-arn</code> - Accepts a list of cluster parameter group ARNs. The
        /// results list only includes the recommendations that generated for the specified cluster
        /// parameter groups.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAfter. 
        /// <para>
        /// A filter to include only the recommendations that were updated after this specified
        /// time.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAfter
        {
            get { return this._lastUpdatedAfter.GetValueOrDefault(); }
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
        public DateTime LastUpdatedBefore
        {
            get { return this._lastUpdatedBefore.GetValueOrDefault(); }
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
        ///  <code>en</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>en_UK</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>de</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>es</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fr</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>id</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>it</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ja</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ko</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pt_BR</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh_TW</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh_CN</code> 
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
        /// An optional pagination token provided by a previous <code>DescribeDBRecommendations</code>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <code>MaxRecords</code>. 
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
        /// exist than the specified <code>MaxRecords</code> value, a pagination token called
        /// a marker is included in the response so that you can retrieve the remaining results.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

    }
}