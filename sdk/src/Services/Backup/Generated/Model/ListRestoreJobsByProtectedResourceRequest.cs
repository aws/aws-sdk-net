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
    /// Container for the parameters to the ListRestoreJobsByProtectedResource operation.
    /// This returns restore jobs that contain the specified protected resource.
    /// 
    ///  
    /// <para>
    /// You must include <c>ResourceArn</c>. You can optionally include <c>NextToken</c>,
    /// <c>ByStatus</c>, <c>MaxResults</c>, <c>ByRecoveryPointCreationDateAfter</c> , and
    /// <c>ByRecoveryPointCreationDateBefore</c>.
    /// </para>
    /// </summary>
    public partial class ListRestoreJobsByProtectedResourceRequest : AmazonBackupRequest
    {
        private DateTime? _byRecoveryPointCreationDateAfter;
        private DateTime? _byRecoveryPointCreationDateBefore;
        private RestoreJobStatus _byStatus;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ByRecoveryPointCreationDateAfter. 
        /// <para>
        /// Returns only restore jobs of recovery points that were created after the specified
        /// date.
        /// </para>
        /// </summary>
        public DateTime ByRecoveryPointCreationDateAfter
        {
            get { return this._byRecoveryPointCreationDateAfter.GetValueOrDefault(); }
            set { this._byRecoveryPointCreationDateAfter = value; }
        }

        // Check to see if ByRecoveryPointCreationDateAfter property is set
        internal bool IsSetByRecoveryPointCreationDateAfter()
        {
            return this._byRecoveryPointCreationDateAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByRecoveryPointCreationDateBefore. 
        /// <para>
        /// Returns only restore jobs of recovery points that were created before the specified
        /// date.
        /// </para>
        /// </summary>
        public DateTime ByRecoveryPointCreationDateBefore
        {
            get { return this._byRecoveryPointCreationDateBefore.GetValueOrDefault(); }
            set { this._byRecoveryPointCreationDateBefore = value; }
        }

        // Check to see if ByRecoveryPointCreationDateBefore property is set
        internal bool IsSetByRecoveryPointCreationDateBefore()
        {
            return this._byRecoveryPointCreationDateBefore.HasValue; 
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
        /// ismade to return <c>MaxResults</c> number of items, <c>NextToken</c> allows you to
        /// return more items in your list starting at the location pointed to by the next token.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Returns only restore jobs that match the specified resource Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}