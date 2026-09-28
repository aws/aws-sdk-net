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
    /// Container for the parameters to the ListBackupJobs operation. Returns a list of existing
    /// backup jobs for an authenticated account for the last 30 days. For a longer period
    /// of time, consider using these <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">monitoring
    /// tools</a>.
    /// </summary>
    public partial class ListBackupJobsRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property ByAccountId. 
        /// <para>
        /// The account ID to list the jobs from. Returns only backup jobs associated with the
        /// specified account ID.
        /// </para>
        ///  
        /// <para>
        /// If used from an Organizations management account, passing <c>*</c> returns all jobs
        /// across the organization.
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
        /// Returns only backup jobs that will be stored in the specified backup vault. Backup
        /// vaults are identified by names that are unique to the account used to create them
        /// and the Amazon Web Services Region where they are created.
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
        /// Returns only backup jobs completed after a date expressed in Unix format and Coordinated
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
        /// Gets and sets the property ByCreatedAfter. 
        /// <para>
        /// Returns only backup jobs that were created after the specified date.
        /// </para>
        /// </summary>
        public DateTime? ByCreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the ByCreatedAfter property is set.
        /// </summary>
        internal bool IsSetByCreatedAfter() => this.ByCreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property ByCreatedBefore. 
        /// <para>
        /// Returns only backup jobs that were created before the specified date.
        /// </para>
        /// </summary>
        public DateTime? ByCreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the ByCreatedBefore property is set.
        /// </summary>
        internal bool IsSetByCreatedBefore() => this.ByCreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property ByMessageCategory. 
        /// <para>
        /// This is an optional parameter that can be used to filter out jobs with a MessageCategory
        /// which matches the value you input.
        /// </para>
        ///  
        /// <para>
        /// Example strings may include <c>AccessDenied</c>, <c>SUCCESS</c>, <c>AGGREGATE_ALL</c>,
        /// and <c>InvalidParameters</c>.
        /// </para>
        ///  
        /// <para>
        /// View <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">Monitoring</a>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The wildcard () returns count of all message categories.
        /// </para>
        ///  
        /// <para>
        ///  <c>AGGREGATE_ALL</c> aggregates job counts for all message categories and returns
        /// the sum.
        /// </para>
        /// </summary>
        public string ByMessageCategory { get; set; }

        /// <summary>
        /// Checks to see if the ByMessageCategory property is set.
        /// </summary>
        internal bool IsSetByMessageCategory() => this.ByMessageCategory != null;

        /// <summary>
        /// Gets and sets the property ByParentJobId. 
        /// <para>
        /// This is a filter to list child (nested) jobs based on parent job ID.
        /// </para>
        /// </summary>
        public string ByParentJobId { get; set; }

        /// <summary>
        /// Checks to see if the ByParentJobId property is set.
        /// </summary>
        internal bool IsSetByParentJobId() => this.ByParentJobId != null;

        /// <summary>
        /// Gets and sets the property ByResourceArn. 
        /// <para>
        /// Returns only backup jobs that match the specified resource Amazon Resource Name (ARN).
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
        /// Returns only backup jobs for the specified resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Aurora</c> for Amazon Aurora
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CloudFormation</c> for CloudFormation
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DocumentDB</c> for Amazon DocumentDB (with MongoDB compatibility)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DynamoDB</c> for Amazon DynamoDB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EBS</c> for Amazon Elastic Block Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EC2</c> for Amazon Elastic Compute Cloud
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EFS</c> for Amazon Elastic File System
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EKS</c> for Amazon Elastic Kubernetes Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FSx</c> for Amazon FSx
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Neptune</c> for Amazon Neptune
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RDS</c> for Amazon Relational Database Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Redshift</c> for Amazon Redshift
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> for Amazon Simple Storage Service (Amazon S3)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAP HANA on Amazon EC2</c> for SAP HANA databases on Amazon Elastic Compute Cloud
        /// instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Storage Gateway</c> for Storage Gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Timestream</c> for Amazon Timestream
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VirtualMachine</c> for VMware virtual machines
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ByResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ByResourceType property is set.
        /// </summary>
        internal bool IsSetByResourceType() => this.ByResourceType != null;

        /// <summary>
        /// Gets and sets the property ByState. 
        /// <para>
        /// Returns only backup jobs that are in the specified state.
        /// </para>
        ///  
        /// <para>
        ///  <c>Completed with issues</c> is a status found only in the Backup console. For API,
        /// this status refers to jobs with a state of <c>COMPLETED</c> and a <c>MessageCategory</c>
        /// with a value other than <c>SUCCESS</c>; that is, the status is completed but comes
        /// with a status message.
        /// </para>
        ///  
        /// <para>
        /// To obtain the job count for <c>Completed with issues</c>, run two GET requests, and
        /// subtract the second, smaller number:
        /// </para>
        ///  
        /// <para>
        /// GET /backup-jobs/?state=COMPLETED
        /// </para>
        ///  
        /// <para>
        /// GET /backup-jobs/?messageCategory=SUCCESS&amp;state=COMPLETED
        /// </para>
        /// </summary>
        public BackupJobState ByState { get; set; }

        /// <summary>
        /// Checks to see if the ByState property is set.
        /// </summary>
        internal bool IsSetByState() => this.ByState != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to be returned.
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
