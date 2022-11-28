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
    /// Container for the parameters to the DescribeBlueGreenDeployments operation.
    /// Returns information about blue/green deployments.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
    /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
    /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
    /// Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeBlueGreenDeploymentsRequest : AmazonRDSRequest
    {
        private string _blueGreenDeploymentIdentifier;
        private List<Filter> _filters = new List<Filter>();
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentIdentifier. 
        /// <para>
        /// The blue/green deployment identifier. If this parameter is specified, information
        /// from only the specific blue/green deployment is returned. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match an existing blue/green deployment identifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string BlueGreenDeploymentIdentifier
        {
            get { return this._blueGreenDeploymentIdentifier; }
            set { this._blueGreenDeploymentIdentifier = value; }
        }

        // Check to see if BlueGreenDeploymentIdentifier property is set
        internal bool IsSetBlueGreenDeploymentIdentifier()
        {
            return this._blueGreenDeploymentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies one or more blue/green deployments to describe.
        /// </para>
        ///  
        /// <para>
        /// Supported filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>blue-green-deployment-identifier</code> - Accepts system-generated identifiers
        /// for blue/green deployments. The results list only includes information about the blue/green
        /// deployments with the specified identifiers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>blue-green-deployment-name</code> - Accepts user-supplied names for blue/green
        /// deployments. The results list only includes information about the blue/green deployments
        /// with the specified names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>source</code> - Accepts source databases for a blue/green deployment. The results
        /// list only includes information about the blue/green deployments with the specified
        /// source databases.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>target</code> - Accepts target databases for a blue/green deployment. The results
        /// list only includes information about the blue/green deployments with the specified
        /// target databases.
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <code>DescribeBlueGreenDeployments</code>
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
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <code>MaxRecords</code> value, a pagination token called a marker is
        /// included in the response so you can retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 20, maximum 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=100)]
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