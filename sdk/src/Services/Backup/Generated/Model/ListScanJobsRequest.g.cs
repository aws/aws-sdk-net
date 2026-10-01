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
    /// Container for the parameters to the ListScanJobs operation. Returns a list of existing
    /// scan jobs for an authenticated account for the last 30 days.
    /// </summary>
    public partial class ListScanJobsRequest : AmazonBackupRequest
    {
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
        public string ByAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ByAccountId property is set.
        /// </summary>
        internal bool IsSetByAccountId() => this.ByAccountId != null;

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
        public string ByBackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the ByBackupVaultName property is set.
        /// </summary>
        internal bool IsSetByBackupVaultName() => this.ByBackupVaultName != null;

        /// <summary>
        /// Gets and sets the property ByCompleteAfter. 
        /// <para>
        /// Returns only scan jobs completed after a date expressed in Unix format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? ByCompleteAfter { get; set; }

        /// <summary>
        /// Checks to see if the ByCompleteAfter property is set.
        /// </summary>
        internal bool IsSetByCompleteAfter() => this.ByCompleteAfter.HasValue;

        /// <summary>
        /// Gets and sets the property ByCompleteBefore. 
        /// <para>
        /// Returns only backup jobs completed before a date expressed in Unix format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? ByCompleteBefore { get; set; }

        /// <summary>
        /// Checks to see if the ByCompleteBefore property is set.
        /// </summary>
        internal bool IsSetByCompleteBefore() => this.ByCompleteBefore.HasValue;

        /// <summary>
        /// Gets and sets the property ByMalwareScanner. 
        /// <para>
        /// Returns only the scan jobs for the specified malware scanner. Currently only supports
        /// <c>GUARDDUTY</c>.
        /// </para>
        /// </summary>
        public MalwareScanner ByMalwareScanner { get; set; }

        /// <summary>
        /// Checks to see if the ByMalwareScanner property is set.
        /// </summary>
        internal bool IsSetByMalwareScanner() => this.ByMalwareScanner != null;

        /// <summary>
        /// Gets and sets the property ByRecoveryPointArn. 
        /// <para>
        /// Returns only the scan jobs that are ran against the specified recovery point.
        /// </para>
        /// </summary>
        public string ByRecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the ByRecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetByRecoveryPointArn() => this.ByRecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property ByResourceArn. 
        /// <para>
        /// Returns only scan jobs that match the specified resource Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string ByResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ByResourceArn property is set.
        /// </summary>
        internal bool IsSetByResourceArn() => this.ByResourceArn != null;

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
        public ScanResourceType ByResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ByResourceType property is set.
        /// </summary>
        internal bool IsSetByResourceType() => this.ByResourceType != null;

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
        public ScanResultStatus ByScanResultStatus { get; set; }

        /// <summary>
        /// Checks to see if the ByScanResultStatus property is set.
        /// </summary>
        internal bool IsSetByScanResultStatus() => this.ByScanResultStatus != null;

        /// <summary>
        /// Gets and sets the property ByState. 
        /// <para>
        /// Returns only the scan jobs for the specified scanning job state.
        /// </para>
        /// </summary>
        public ScanState ByState { get; set; }

        /// <summary>
        /// Checks to see if the ByState property is set.
        /// </summary>
        internal bool IsSetByState() => this.ByState != null;

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
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next item following a partial list of returned items. For example, if a request
        /// is made to return <c>MaxResults</c> number of items, <c>NextToken</c> allows you to
        /// return more items in your list starting at the location pointed to by the next token.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
