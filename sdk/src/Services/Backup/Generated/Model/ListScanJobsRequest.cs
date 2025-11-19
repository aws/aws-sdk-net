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
    /// Container for the parameters to the ListScanJobs operation.
    /// Returns a list of existing scan jobs for an authenticated account for the last 30
    /// days.
    /// </summary>
    public partial class ListScanJobsRequest : AmazonBackupRequest
    {
        private string _byAccountId;
        private string _byBackupVaultName;
        private DateTime? _byCompleteAfter;
        private DateTime? _byCompleteBefore;
        private MalwareScanner _byMalwareScanner;
        private string _byRecoveryPointArn;
        private string _byResourceArn;
        private ScanResourceType _byResourceType;
        private ScanResultStatus _byScanResultStatus;
        private ScanState _byState;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ByAccountId. 
        /// <para>
        /// The account ID to list the jobs from. Returns only backup jobs associated with the
        /// specified account ID.
        /// </para>
        ///  
        /// <para>
        /// If used from an Amazon Web Services Organizations management account, passing <c>*</c>
        /// returns all jobs across the organization.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>^[0-9]{12}$</c> 
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
        /// Gets and sets the property ByBackupVaultName. 
        /// <para>
        /// Returns only scan jobs that will be stored in the specified backup vault. Backup vaults
        /// are identified by names that are unique to the account used to create them and the
        /// Amazon Web Services Region where they are created.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>^[a-zA-Z0-9\-\_\.]{2,50}$</c> 
        /// </para>
        /// </summary>
        public string ByBackupVaultName
        {
            get { return this._byBackupVaultName; }
            set { this._byBackupVaultName = value; }
        }

        // Check to see if ByBackupVaultName property is set
        internal bool IsSetByBackupVaultName()
        {
            return this._byBackupVaultName != null;
        }

        /// <summary>
        /// Gets and sets the property ByCompleteAfter. 
        /// <para>
        /// Returns only scan jobs completed after a date expressed in Unix format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime ByCompleteAfter
        {
            get { return this._byCompleteAfter.GetValueOrDefault(); }
            set { this._byCompleteAfter = value; }
        }

        // Check to see if ByCompleteAfter property is set
        internal bool IsSetByCompleteAfter()
        {
            return this._byCompleteAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByCompleteBefore. 
        /// <para>
        /// Returns only backup jobs completed before a date expressed in Unix format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime ByCompleteBefore
        {
            get { return this._byCompleteBefore.GetValueOrDefault(); }
            set { this._byCompleteBefore = value; }
        }

        // Check to see if ByCompleteBefore property is set
        internal bool IsSetByCompleteBefore()
        {
            return this._byCompleteBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByMalwareScanner. 
        /// <para>
        /// Returns only the scan jobs for the specified malware scanner. Currently only supports
        /// <c>GUARDDUTY</c>.
        /// </para>
        /// </summary>
        public MalwareScanner ByMalwareScanner
        {
            get { return this._byMalwareScanner; }
            set { this._byMalwareScanner = value; }
        }

        // Check to see if ByMalwareScanner property is set
        internal bool IsSetByMalwareScanner()
        {
            return this._byMalwareScanner != null;
        }

        /// <summary>
        /// Gets and sets the property ByRecoveryPointArn. 
        /// <para>
        /// Returns only the scan jobs that are ran against the specified recovery point.
        /// </para>
        /// </summary>
        public string ByRecoveryPointArn
        {
            get { return this._byRecoveryPointArn; }
            set { this._byRecoveryPointArn = value; }
        }

        // Check to see if ByRecoveryPointArn property is set
        internal bool IsSetByRecoveryPointArn()
        {
            return this._byRecoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ByResourceArn. 
        /// <para>
        /// Returns only scan jobs that match the specified resource Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string ByResourceArn
        {
            get { return this._byResourceArn; }
            set { this._byResourceArn = value; }
        }

        // Check to see if ByResourceArn property is set
        internal bool IsSetByResourceArn()
        {
            return this._byResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ByResourceType. 
        /// <para>
        /// Returns restore testing selections by the specified restore testing plan name.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EBS</c>for Amazon Elastic Block Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EC2</c>for Amazon Elastic Compute Cloud
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c>for Amazon Simple Storage Service (Amazon S3)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Pattern: <c>^[a-zA-Z0-9\-\_\.]{1,50}$</c> 
        /// </para>
        /// </summary>
        public ScanResourceType ByResourceType
        {
            get { return this._byResourceType; }
            set { this._byResourceType = value; }
        }

        // Check to see if ByResourceType property is set
        internal bool IsSetByResourceType()
        {
            return this._byResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ByScanResultStatus. 
        /// <para>
        /// Returns only the scan jobs for the specified scan results:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>THREATS_FOUND</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_THREATS_FOUND</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScanResultStatus ByScanResultStatus
        {
            get { return this._byScanResultStatus; }
            set { this._byScanResultStatus = value; }
        }

        // Check to see if ByScanResultStatus property is set
        internal bool IsSetByScanResultStatus()
        {
            return this._byScanResultStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ByState. 
        /// <para>
        /// Returns only the scan jobs for the specified scanning job state.
        /// </para>
        /// </summary>
        public ScanState ByState
        {
            get { return this._byState; }
            set { this._byState = value; }
        }

        // Check to see if ByState property is set
        internal bool IsSetByState()
        {
            return this._byState != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to be returned.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 1. Maximum value of 1000.
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
        /// is made to return <c>MaxResults</c> number of items, <c>NextToken</c> allows you to
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

    }
}