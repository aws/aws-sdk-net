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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeReplicationTaskAssessmentResultsResponse : AmazonWebServiceResponse
    {
        private string _bucketName;
        private string _marker;
        private List<ReplicationTaskAssessmentResult> _replicationTaskAssessmentResults = new List<ReplicationTaskAssessmentResult>();

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// - The Amazon S3 bucket where the task assessment report is located. 
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <code>MaxRecords</code>. 
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
        /// Gets and sets the property ReplicationTaskAssessmentResults. 
        /// <para>
        ///  The task assessment report. 
        /// </para>
        /// </summary>
        public List<ReplicationTaskAssessmentResult> ReplicationTaskAssessmentResults
        {
            get { return this._replicationTaskAssessmentResults; }
            set { this._replicationTaskAssessmentResults = value; }
        }

        // Check to see if ReplicationTaskAssessmentResults property is set
        internal bool IsSetReplicationTaskAssessmentResults()
        {
            return this._replicationTaskAssessmentResults != null && this._replicationTaskAssessmentResults.Count > 0; 
        }

    }
}