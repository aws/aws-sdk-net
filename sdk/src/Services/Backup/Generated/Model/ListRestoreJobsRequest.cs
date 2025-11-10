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
    /// Container for the parameters to the ListRestoreJobs operation.
    /// Returns a list of jobs that Backup initiated to restore a saved resource, including
    /// details about the recovery process.
    /// </summary>
    public partial class ListRestoreJobsRequest : AmazonBackupRequest
    {
        private string _byAccountId;
        private DateTime? _byCompleteAfter;
        private DateTime? _byCompleteBefore;
        private DateTime? _byCreatedAfter;
        private DateTime? _byCreatedBefore;
        private string _byParentJobId;
        private string _byResourceType;
        private string _byRestoreTestingPlanArn;
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
        /// Gets and sets the property ByCompleteAfter. 
        /// <para>
        /// Returns only copy jobs completed after a date expressed in Unix format and Coordinated
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
        /// Returns only copy jobs completed before a date expressed in Unix format and Coordinated
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
        /// Gets and sets the property ByParentJobId. 
        /// <para>
        /// This is a filter to list child (nested) restore jobs based on parent restore job ID.
        /// </para>
        /// </summary>
        public string ByParentJobId
        {
            get { return this._byParentJobId; }
            set { this._byParentJobId = value; }
        }

        // Check to see if ByParentJobId property is set
        internal bool IsSetByParentJobId()
        {
            return this._byParentJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ByResourceType. 
        /// <para>
        /// Include this parameter to return only restore jobs for the specified resources:
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
        public string ByResourceType
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
        /// Gets and sets the property ByRestoreTestingPlanArn. 
        /// <para>
        /// This returns only restore testing jobs that match the specified resource Amazon Resource
        /// Name (ARN).
        /// </para>
        /// </summary>
        public string ByRestoreTestingPlanArn
        {
            get { return this._byRestoreTestingPlanArn; }
            set { this._byRestoreTestingPlanArn = value; }
        }

        // Check to see if ByRestoreTestingPlanArn property is set
        internal bool IsSetByRestoreTestingPlanArn()
        {
            return this._byRestoreTestingPlanArn != null;
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