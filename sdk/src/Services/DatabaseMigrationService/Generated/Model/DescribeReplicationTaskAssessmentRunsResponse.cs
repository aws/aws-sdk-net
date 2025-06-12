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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeReplicationTaskAssessmentRunsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ReplicationTaskAssessmentRun> _replicationTaskAssessmentRuns = AWSConfigs.InitializeCollections ? new List<ReplicationTaskAssessmentRun>() : null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token returned for you to pass to a subsequent request. If you pass this
        /// token as the <c>Marker</c> value in a subsequent request, the response includes only
        /// records beyond the marker, up to the value specified in the request by <c>MaxRecords</c>.
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
        /// Gets and sets the property ReplicationTaskAssessmentRuns. 
        /// <para>
        /// One or more premigration assessment runs as specified by <c>Filters</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicationTaskAssessmentRun> ReplicationTaskAssessmentRuns
        {
            get { return this._replicationTaskAssessmentRuns; }
            set { this._replicationTaskAssessmentRuns = value; }
        }

        // Check to see if ReplicationTaskAssessmentRuns property is set
        internal bool IsSetReplicationTaskAssessmentRuns()
        {
            return this._replicationTaskAssessmentRuns != null && (this._replicationTaskAssessmentRuns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}