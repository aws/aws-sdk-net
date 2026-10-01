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
    /// Container for the parameters to the ListRestoreJobSummaries operation. This request
    /// obtains a summary of restore jobs created or running within the the most recent 14
    /// days. You can include parameters AccountID, State, ResourceType, AggregationPeriod,
    /// MaxResults, or NextToken to filter results. <para> This request returns a summary
    /// that contains Region, Account, State, RestourceType, MessageCategory, StartTime, EndTime,
    /// and Count of included jobs. </para>
    /// </summary>
    public partial class ListRestoreJobSummariesRequest : AmazonBackupRequest
    {
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
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

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
        public AggregationPeriod AggregationPeriod { get; set; }

        /// <summary>
        /// Checks to see if the AggregationPeriod property is set.
        /// </summary>
        internal bool IsSetAggregationPeriod() => this.AggregationPeriod != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// This parameter sets the maximum number of items to be returned.
        /// </para>
        ///  
        /// <para>
        /// The value is an integer. Range of accepted values is from 1 to 500.
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
        /// The next item following a partial list of returned resources. For example, if a request
        /// is made to return <c>MaxResults</c> number of resources, <c>NextToken</c> allows you
        /// to return more items in your list starting at the location pointed to by the next
        /// token.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

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
        /// </summary>
        public RestoreJobState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
