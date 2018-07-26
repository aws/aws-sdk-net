/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusterTracks operation.
    /// Returns a list of all the available maintenance tracks.
    /// </summary>
    public partial class DescribeClusterTracksRequest : AmazonRedshiftRequest
    {
        private string _maintenanceTrackName;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name of the maintenance track. 
        /// </para>
        /// </summary>
        public string MaintenanceTrackName
        {
            get { return this._maintenanceTrackName; }
            set { this._maintenanceTrackName = value; }
        }

        // Check to see if MaintenanceTrackName property is set
        internal bool IsSetMaintenanceTrackName()
        {
            return this._maintenanceTrackName != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <code>DescribeClusterTracks</code> request exceed the
        /// value specified in <code>MaxRecords</code>, Amazon Redshift returns a value in the
        /// <code>Marker</code> field of the response. You can retrieve the next set of response
        /// records by providing the returned marker value in the <code>Marker</code> parameter
        /// and retrying the request. 
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
        /// An integer value for the maximum number of maintenance tracks to return.
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