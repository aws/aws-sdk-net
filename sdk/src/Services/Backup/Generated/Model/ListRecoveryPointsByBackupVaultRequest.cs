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
    /// Container for the parameters to the ListRecoveryPointsByBackupVault operation.
    /// Returns detailed information about the recovery points stored in a backup vault.
    /// </summary>
    public partial class ListRecoveryPointsByBackupVaultRequest : AmazonBackupRequest
    {
        private string _backupVaultName;
        private string _byBackupPlanId;
        private DateTime? _byCreatedAfter;
        private DateTime? _byCreatedBefore;
        private string _byParentRecoveryPointArn;
        private string _byResourceArn;
        private string _byResourceType;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created. They consist of lowercase letters, numbers, and hyphens.
        /// </para>
        ///  <note> 
        /// <para>
        /// Backup vault name might not be available when a supported service creates the backup.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupVaultName
        {
            get { return this._backupVaultName; }
            set { this._backupVaultName = value; }
        }

        // Check to see if BackupVaultName property is set
        internal bool IsSetBackupVaultName()
        {
            return this._backupVaultName != null;
        }

        /// <summary>
        /// Gets and sets the property ByBackupPlanId. 
        /// <para>
        /// Returns only recovery points that match the specified backup plan ID.
        /// </para>
        /// </summary>
        public string ByBackupPlanId
        {
            get { return this._byBackupPlanId; }
            set { this._byBackupPlanId = value; }
        }

        // Check to see if ByBackupPlanId property is set
        internal bool IsSetByBackupPlanId()
        {
            return this._byBackupPlanId != null;
        }

        /// <summary>
        /// Gets and sets the property ByCreatedAfter. 
        /// <para>
        /// Returns only recovery points that were created after the specified timestamp.
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
        /// Returns only recovery points that were created before the specified timestamp.
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
        /// Gets and sets the property ByParentRecoveryPointArn. 
        /// <para>
        /// This returns only recovery points that match the specified parent (composite) recovery
        /// point Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string ByParentRecoveryPointArn
        {
            get { return this._byParentRecoveryPointArn; }
            set { this._byParentRecoveryPointArn = value; }
        }

        // Check to see if ByParentRecoveryPointArn property is set
        internal bool IsSetByParentRecoveryPointArn()
        {
            return this._byParentRecoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ByResourceArn. 
        /// <para>
        /// Returns only recovery points that match the specified resource Amazon Resource Name
        /// (ARN).
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
        /// Returns only recovery points that match the specified resource type.
        /// </para>
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