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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListReportJobs operation. Returns details about
    /// your report jobs.
    /// </summary>
    public partial class ListReportJobsRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property ByCreationAfter. 
        /// <para>
        /// Returns only report jobs that were created after the date and time specified in Unix
        /// format and Coordinated Universal Time (UTC). For example, the value 1516925490 represents
        /// Friday, January 26, 2018 12:11:30 AM.
        /// </para>
        /// </summary>
        public DateTime? ByCreationAfter { get; set; }

        /// <summary>
        /// Checks to see if the ByCreationAfter property is set.
        /// </summary>
        internal bool IsSetByCreationAfter() => this.ByCreationAfter.HasValue;

        /// <summary>
        /// Gets and sets the property ByCreationBefore. 
        /// <para>
        /// Returns only report jobs that were created before the date and time specified in Unix
        /// format and Coordinated Universal Time (UTC). For example, the value 1516925490 represents
        /// Friday, January 26, 2018 12:11:30 AM.
        /// </para>
        /// </summary>
        public DateTime? ByCreationBefore { get; set; }

        /// <summary>
        /// Checks to see if the ByCreationBefore property is set.
        /// </summary>
        internal bool IsSetByCreationBefore() => this.ByCreationBefore.HasValue;

        /// <summary>
        /// Gets and sets the property ByReportPlanName. 
        /// <para>
        /// Returns only report jobs with the specified report plan name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ByReportPlanName { get; set; }

        /// <summary>
        /// Checks to see if the ByReportPlanName property is set.
        /// </summary>
        internal bool IsSetByReportPlanName() => this.ByReportPlanName != null;

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
        public string ByStatus { get; set; }

        /// <summary>
        /// Checks to see if the ByStatus property is set.
        /// </summary>
        internal bool IsSetByStatus() => this.ByStatus != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of desired results from 1 to 1000. Optional. If unspecified, the query
        /// will return 1 MB of data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
