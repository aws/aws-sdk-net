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
    /// Container for the parameters to the ListBackupJobs operation.
    /// Returns a list of existing backup jobs for an authenticated account for the last 30
    /// days. For a longer period of time, consider using these <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">monitoring
    /// tools</a>.
    /// </summary>
    public partial class ListBackupJobsRequest : AmazonBackupRequest
    {
        private string _byAccountId;
        private string _byBackupVaultName;
        private DateTime? _byCompleteAfter;
        private DateTime? _byCompleteBefore;
        private DateTime? _byCreatedAfter;
        private DateTime? _byCreatedBefore;
        private string _byParentJobId;
        private string _byResourceArn;
        private string _byResourceType;
        private BackupJobState _byState;
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
        /// If used from an Organizations management account, passing <code>*</code> returns all
        /// jobs across the organization.
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
        /// Returns only backup jobs that will be stored in the specified backup vault. Backup
        /// vaults are identified by names that are unique to the account used to create them
        /// and the Amazon Web Services Region where they are created. They consist of lowercase
        /// letters, numbers, and hyphens.
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
        /// Returns only backup jobs completed after a date expressed in Unix format and Coordinated
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
        /// Gets and sets the property ByCreatedAfter. 
        /// <para>
        /// Returns only backup jobs that were created after the specified date.
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
        /// Returns only backup jobs that were created before the specified date.
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
        /// This is a filter to list child (nested) jobs based on parent job ID.
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
        /// Gets and sets the property ByResourceArn. 
        /// <para>
        /// Returns only backup jobs that match the specified resource Amazon Resource Name (ARN).
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
        /// Returns only backup jobs for the specified resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Aurora</code> for Amazon Aurora
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DocumentDB</code> for Amazon DocumentDB (with MongoDB compatibility)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DynamoDB</code> for Amazon DynamoDB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EBS</code> for Amazon Elastic Block Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EC2</code> for Amazon Elastic Compute Cloud
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EFS</code> for Amazon Elastic File System
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FSx</code> for Amazon FSx
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Neptune</code> for Amazon Neptune
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RDS</code> for Amazon Relational Database Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Storage Gateway</code> for Storage Gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>S3</code> for Amazon S3
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VirtualMachine</code> for virtual machines
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
        /// Gets and sets the property ByState. 
        /// <para>
        /// Returns only backup jobs that are in the specified state.
        /// </para>
        /// </summary>
        public BackupJobState ByState
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