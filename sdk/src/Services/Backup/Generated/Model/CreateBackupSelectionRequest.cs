/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBackupSelection operation.
    /// Creates a JSON document that specifies a set of resources to assign to a backup plan.
    /// Resources can be included by specifying patterns for a <code>ListOfTags</code> and
    /// selected <code>Resources</code>. 
    /// 
    ///  
    /// <para>
    /// For example, consider the following patterns:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Resources: "arn:aws:ec2:region:account-id:volume/volume-id"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ConditionKey:"department"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>ConditionValue:"finance"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>ConditionType:"StringEquals"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ConditionKey:"importance"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>ConditionValue:"critical"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>ConditionType:"StringEquals"</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Using these patterns would back up all Amazon Elastic Block Store (Amazon EBS) volumes
    /// that are tagged as <code>"department=finance"</code>, <code>"importance=critical"</code>,
    /// in addition to an EBS volume with the specified volume Id.
    /// </para>
    ///  
    /// <para>
    /// Resources and conditions are additive in that all resources that match the pattern
    /// are selected. This shouldn't be confused with a logical AND, where all conditions
    /// must match. The matching patterns are logically 'put together using the OR operator.
    /// In other words, all patterns that match are selected for backup.
    /// </para>
    /// </summary>
    public partial class CreateBackupSelectionRequest : AmazonBackupRequest
    {
        private string _backupPlanId;
        private BackupSelection _backupSelection;
        private string _creatorRequestId;

        /// <summary>
        /// Gets and sets the property BackupPlanId. 
        /// <para>
        /// Uniquely identifies the backup plan to be associated with the selection of resources.
        /// </para>
        /// </summary>
        public string BackupPlanId
        {
            get { return this._backupPlanId; }
            set { this._backupPlanId = value; }
        }

        // Check to see if BackupPlanId property is set
        internal bool IsSetBackupPlanId()
        {
            return this._backupPlanId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupSelection. 
        /// <para>
        /// Specifies the body of a request to assign a set of resources to a backup plan.
        /// </para>
        ///  
        /// <para>
        /// It includes an array of resources, an optional array of patterns to exclude resources,
        /// an optional role to provide access to the AWS service the resource belongs to, and
        /// an optional array of tags used to identify a set of resources.
        /// </para>
        /// </summary>
        public BackupSelection BackupSelection
        {
            get { return this._backupSelection; }
            set { this._backupSelection = value; }
        }

        // Check to see if BackupSelection property is set
        internal bool IsSetBackupSelection()
        {
            return this._backupSelection != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and allows failed requests to be retried
        /// without the risk of executing the operation twice.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

    }
}