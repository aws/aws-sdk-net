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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeReplicationTaskIndividualAssessmentsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ReplicationTaskIndividualAssessment> _replicationTaskIndividualAssessments = new List<ReplicationTaskIndividualAssessment>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token returned for you to pass to a subsequent request. If you pass this
        /// token as the <code>Marker</code> value in a subsequent request, the response includes
        /// only records beyond the marker, up to the value specified in the request by <code>MaxRecords</code>.
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
        /// Gets and sets the property ReplicationTaskIndividualAssessments. 
        /// <para>
        /// One or more individual assessments as specified by <code>Filters</code>.
        /// </para>
        /// </summary>
        public List<ReplicationTaskIndividualAssessment> ReplicationTaskIndividualAssessments
        {
            get { return this._replicationTaskIndividualAssessments; }
            set { this._replicationTaskIndividualAssessments = value; }
        }

        // Check to see if ReplicationTaskIndividualAssessments property is set
        internal bool IsSetReplicationTaskIndividualAssessments()
        {
            return this._replicationTaskIndividualAssessments != null && this._replicationTaskIndividualAssessments.Count > 0; 
        }

    }
}