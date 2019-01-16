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
    /// Container for the parameters to the GetBackupSelection operation.
    /// Returns selection metadata and a document in JSON format that specifies a list of
    /// resources that are associated with a backup plan.
    /// </summary>
    public partial class GetBackupSelectionRequest : AmazonBackupRequest
    {
        private string _backupPlanId;
        private string _selectionId;

        /// <summary>
        /// Gets and sets the property BackupPlanId. 
        /// <para>
        /// Uniquely identifies a backup plan.
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
        /// Gets and sets the property SelectionId. 
        /// <para>
        /// Uniquely identifies the body of a request to assign a set of resources to a backup
        /// plan.
        /// </para>
        /// </summary>
        public string SelectionId
        {
            get { return this._selectionId; }
            set { this._selectionId = value; }
        }

        // Check to see if SelectionId property is set
        internal bool IsSetSelectionId()
        {
            return this._selectionId != null;
        }

    }
}