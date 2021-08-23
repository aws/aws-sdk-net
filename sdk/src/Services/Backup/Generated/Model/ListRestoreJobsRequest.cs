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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the ListRestoreJobs operation.
    /// Returns a list of jobs that Backup initiated to restore a saved resource, including
    /// details about the recovery process.
    /// </summary>
    public partial class ListRestoreJobsRequest : AmazonBackupRequest
    {
        private string _byAccountId;
        private DateTime? _byCreatedAfter;
        private DateTime? _byCreatedBefore;
        private RestoreJobStatus _byStatus;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ByAccountId. 
        /// <para>
        /// The account ID to list the jobs from. Returns only restore jobs associated with the
        /// specified account ID.
        /// </para>
        /// </summary>
        public string ByAccountId
        {
            get { return this._byAccountId; }
            set { this._byAccountId = value; }
        }

        // Check to see if ByAccountId property is set
        internal bool IsSetByAccountId()
        {
            return this._byAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ByCreatedAfter. 
        /// <para>
        /// Returns only restore jobs that were created after the specified date.
        /// </para>
        /// </summary>
        public DateTime ByCreatedAfter
        {
            get { return this._byCreatedAfter.GetValueOrDefault(); }
            set { this._byCreatedAfter = value; }
        }

        // Check to see if ByCreatedAfter property is set
        internal bool IsSetByCreatedAfter()
        {
            return this._byCreatedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByCreatedBefore. 
        /// <para>
        /// Returns only restore jobs that were created before the specified date.
        /// </para>
        /// </summary>
        public DateTime ByCreatedBefore
        {
            get { return this._byCreatedBefore.GetValueOrDefault(); }
            set { this._byCreatedBefore = value; }
        }

        // Check to see if ByCreatedBefore property is set
        internal bool IsSetByCreatedBefore()
        {
            return this._byCreatedBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByStatus. 
        /// <para>
        /// Returns only restore jobs associated with the specified job status.
        /// </para>
        /// </summary>
        public RestoreJobStatus ByStatus
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
        /// The maximum number of items to be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The next item following a partial list of returned items. For example, if a request
        /// is made to return <code>maxResults</code> number of items, <code>NextToken</code>
        /// allows you to return more items in your list starting at the location pointed to by
        /// the next token.
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