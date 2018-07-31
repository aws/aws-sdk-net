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
    /// This is the response object from the DescribeClusterTracks operation.
    /// </summary>
    public partial class DescribeClusterTracksResponse : AmazonWebServiceResponse
    {
        private List<MaintenanceTrack> _maintenanceTracks = new List<MaintenanceTrack>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property MaintenanceTracks. 
        /// <para>
        /// A list of maintenance tracks output by the <code>DescribeClusterTracks</code> operation.
        /// 
        /// </para>
        /// </summary>
        public List<MaintenanceTrack> MaintenanceTracks
        {
            get { return this._maintenanceTracks; }
            set { this._maintenanceTracks = value; }
        }

        // Check to see if MaintenanceTracks property is set
        internal bool IsSetMaintenanceTracks()
        {
            return this._maintenanceTracks != null && this._maintenanceTracks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The starting point to return a set of response tracklist records. You can retrieve
        /// the next set of response records by providing the returned marker value in the <code>Marker</code>
        /// parameter and retrying the request.
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

    }
}