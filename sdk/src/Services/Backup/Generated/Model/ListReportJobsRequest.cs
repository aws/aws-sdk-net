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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the ListReportJobs operation.
    /// Returns details about your report jobs.
    /// </summary>
    public partial class ListReportJobsRequest : AmazonBackupRequest
    {
        private DateTime? _byCreationAfter;
        private DateTime? _byCreationBefore;
        private string _byReportPlanName;
        private string _byStatus;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ByCreationAfter. 
        /// <para>
        /// Returns only report jobs that were created after the date and time specified in Unix
        /// format and Coordinated Universal Time (UTC). For example, the value 1516925490 represents
        /// Friday, January 26, 2018 12:11:30 AM.
        /// </para>
        /// </summary>
        public DateTime? ByCreationAfter
        {
            get { return this._byCreationAfter; }
            set { this._byCreationAfter = value; }
        }

        // Check to see if ByCreationAfter property is set
        internal bool IsSetByCreationAfter()
        {
            return this._byCreationAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByCreationBefore. 
        /// <para>
        /// Returns only report jobs that were created before the date and time specified in Unix
        /// format and Coordinated Universal Time (UTC). For example, the value 1516925490 represents
        /// Friday, January 26, 2018 12:11:30 AM.
        /// </para>
        /// </summary>
        public DateTime? ByCreationBefore
        {
            get { return this._byCreationBefore; }
            set { this._byCreationBefore = value; }
        }

        // Check to see if ByCreationBefore property is set
        internal bool IsSetByCreationBefore()
        {
            return this._byCreationBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByReportPlanName. 
        /// <para>
        /// Returns only report jobs with the specified report plan name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ByReportPlanName
        {
            get { return this._byReportPlanName; }
            set { this._byReportPlanName = value; }
        }

        // Check to see if ByReportPlanName property is set
        internal bool IsSetByReportPlanName()
        {
            return this._byReportPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property ByStatus. 
        /// <para>
        /// Returns only report jobs that are in the specified status. The statuses are:
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATED | RUNNING | COMPLETED | FAILED | COMPLETED_WITH_ISSUES</c> 
        /// </para>
        ///  
        /// <para>
        ///  Please note that only scanning jobs finish with state completed with issues. For
        /// backup jobs this is a console interpretation of a job that finishes in completed state
        /// and has a status message.
        /// </para>
        /// </summary>
        public string ByStatus
        {
            get { return this._byStatus; }
            set { this._byStatus = value; }
        }

        // Check to see if ByStatus property is set
        internal bool IsSetByStatus()
        {
            return this._byStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of desired results from 1 to 1000. Optional. If unspecified, the query
        /// will return 1 MB of data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
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

    }
}