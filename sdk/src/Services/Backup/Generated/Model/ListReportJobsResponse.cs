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
    /// This is the response object from the ListReportJobs operation.
    /// </summary>
    public partial class ListReportJobsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReportJob> _reportJobs = AWSConfigs.InitializeCollections ? new List<ReportJob>() : null;

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

        /// <summary>
        /// Gets and sets the property ReportJobs. 
        /// <para>
        /// Details about your report jobs in JSON format.
        /// </para>
        /// </summary>
        public List<ReportJob> ReportJobs
        {
            get { return this._reportJobs; }
            set { this._reportJobs = value; }
        }

        // Check to see if ReportJobs property is set
        internal bool IsSetReportJobs()
        {
            return this._reportJobs != null && (this._reportJobs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}