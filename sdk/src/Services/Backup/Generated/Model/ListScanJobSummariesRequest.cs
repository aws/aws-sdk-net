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
    /// Container for the parameters to the ListScanJobSummaries operation.
    /// This is a request for a summary of scan jobs created or running within the most recent
    /// 30 days.
    /// </summary>
    public partial class ListScanJobSummariesRequest : AmazonBackupRequest
    {
        private string _accountId;
        private AggregationPeriod _aggregationPeriod;
        private MalwareScanner _malwareScanner;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceType;
        private ScanResultStatus _scanResultStatus;
        private ScanJobStatus _state;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Returns the job count for the specified account.
        /// </para>
        ///  
        /// <para>
        /// If the request is sent from a member account or an account not part of Amazon Web
        /// Services Organizations, jobs within requestor's account will be returned.
        /// </para>
        ///  
        /// <para>
        /// Root, admin, and delegated administrator accounts can use the value <c>ANY</c> to
        /// return job counts from every account in the organization.
        /// </para>
        ///  
        /// <para>
        ///  <c>AGGREGATE_ALL</c> aggregates job counts from all accounts within the authenticated
        /// organization, then returns the sum.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AggregationPeriod. 
        /// <para>
        /// The period for the returned results.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ONE_DAY</c>The daily job count for the prior 1 day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SEVEN_DAYS</c>The daily job count for the prior 7 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FOURTEEN_DAYS</c>The daily job count for the prior 14 days.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AggregationPeriod AggregationPeriod
        {
            get { return this._aggregationPeriod; }
            set { this._aggregationPeriod = value; }
        }

        // Check to see if AggregationPeriod property is set
        internal bool IsSetAggregationPeriod()
        {
            return this._aggregationPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// Returns only the scan jobs for the specified malware scanner. Currently the only MalwareScanner
        /// is <c>GUARDDUTY</c>. But the field also supports <c>ANY</c>, and <c>AGGREGATE_ALL</c>.
        /// </para>
        /// </summary>
        public MalwareScanner MalwareScanner
        {
            get { return this._malwareScanner; }
            set { this._malwareScanner = value; }
        }

        // Check to see if MalwareScanner property is set
        internal bool IsSetMalwareScanner()
        {
            return this._malwareScanner != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to be returned.
        /// </para>
        ///  
        /// <para>
        /// The value is an integer. Range of accepted values is from 1 to 500.
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

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Returns the job count for the specified resource type. Use request <c>GetSupportedResourceTypes</c>
        /// to obtain strings for supported resource types.
        /// </para>
        ///  
        /// <para>
        /// The the value <c>ANY</c> returns count of all resource types.
        /// </para>
        ///  
        /// <para>
        ///  <c>AGGREGATE_ALL</c> aggregates job counts for all resource types and returns the
        /// sum.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ScanResultStatus. 
        /// <para>
        /// Returns only the scan jobs for the specified scan results.
        /// </para>
        /// </summary>
        public ScanResultStatus ScanResultStatus
        {
            get { return this._scanResultStatus; }
            set { this._scanResultStatus = value; }
        }

        // Check to see if ScanResultStatus property is set
        internal bool IsSetScanResultStatus()
        {
            return this._scanResultStatus != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Returns only the scan jobs for the specified scanning job state.
        /// </para>
        /// </summary>
        public ScanJobStatus State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}