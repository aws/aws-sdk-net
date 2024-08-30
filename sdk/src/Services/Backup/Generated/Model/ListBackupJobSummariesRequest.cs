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
    /// Container for the parameters to the ListBackupJobSummaries operation.
    /// This is a request for a summary of backup jobs created or running within the most
    /// recent 30 days. You can include parameters AccountID, State, ResourceType, MessageCategory,
    /// AggregationPeriod, MaxResults, or NextToken to filter results.
    /// 
    ///  
    /// <para>
    /// This request returns a summary that contains Region, Account, State, ResourceType,
    /// MessageCategory, StartTime, EndTime, and Count of included jobs.
    /// </para>
    /// </summary>
    public partial class ListBackupJobSummariesRequest : AmazonBackupRequest
    {
        private string _accountId;
        private AggregationPeriod _aggregationPeriod;
        private int? _maxResults;
        private string _messageCategory;
        private string _nextToken;
        private string _resourceType;
        private BackupJobStatus _state;

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
        /// Root, admin, and delegated administrator accounts can use the value ANY to return
        /// job counts from every account in the organization.
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
        ///  <c>ONE_DAY</c> - The daily job count for the prior 14 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SEVEN_DAYS</c> - The aggregated job count for the prior 7 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FOURTEEN_DAYS</c> - The aggregated job count for prior 14 days.
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
        /// Gets and sets the property MessageCategory. 
        /// <para>
        /// This parameter returns the job count for the specified message category.
        /// </para>
        ///  
        /// <para>
        /// Example accepted strings include <c>AccessDenied</c>, <c>Success</c>, and <c>InvalidParameters</c>.
        /// See <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">Monitoring</a>
        /// for a list of accepted MessageCategory strings.
        /// </para>
        ///  
        /// <para>
        /// The the value ANY returns count of all message categories.
        /// </para>
        ///  
        /// <para>
        ///  <c>AGGREGATE_ALL</c> aggregates job counts for all message categories and returns
        /// the sum.
        /// </para>
        /// </summary>
        public string MessageCategory
        {
            get { return this._messageCategory; }
            set { this._messageCategory = value; }
        }

        // Check to see if MessageCategory property is set
        internal bool IsSetMessageCategory()
        {
            return this._messageCategory != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next item following a partial list of returned resources. For example, if a request
        /// is made to return <c>MaxResults</c> number of resources, <c>NextToken</c> allows you
        /// to return more items in your list starting at the location pointed to by the next
        /// token.
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
        /// The the value ANY returns count of all resource types.
        /// </para>
        ///  
        /// <para>
        ///  <c>AGGREGATE_ALL</c> aggregates job counts for all resource types and returns the
        /// sum.
        /// </para>
        ///  
        /// <para>
        /// The type of Amazon Web Services resource to be backed up; for example, an Amazon Elastic
        /// Block Store (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS)
        /// database.
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
        /// Gets and sets the property State. 
        /// <para>
        /// This parameter returns the job count for jobs with the specified state.
        /// </para>
        ///  
        /// <para>
        /// The the value ANY returns count of all states.
        /// </para>
        ///  
        /// <para>
        ///  <c>AGGREGATE_ALL</c> aggregates job counts for all states and returns the sum.
        /// </para>
        ///  
        /// <para>
        ///  <c>Completed with issues</c> is a status found only in the Backup console. For API,
        /// this status refers to jobs with a state of <c>COMPLETED</c> and a <c>MessageCategory</c>
        /// with a value other than <c>SUCCESS</c>; that is, the status is completed but comes
        /// with a status message. To obtain the job count for <c>Completed with issues</c>, run
        /// two GET requests, and subtract the second, smaller number:
        /// </para>
        ///  
        /// <para>
        /// GET /audit/backup-job-summaries?AggregationPeriod=FOURTEEN_DAYS&amp;State=COMPLETED
        /// </para>
        ///  
        /// <para>
        /// GET /audit/backup-job-summaries?AggregationPeriod=FOURTEEN_DAYS&amp;MessageCategory=SUCCESS&amp;State=COMPLETED
        /// </para>
        /// </summary>
        public BackupJobStatus State
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