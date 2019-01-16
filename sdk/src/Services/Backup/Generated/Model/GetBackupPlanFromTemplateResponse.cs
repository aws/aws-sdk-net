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
    /// This is the response object from the GetBackupPlanFromTemplate operation.
    /// </summary>
    public partial class GetBackupPlanFromTemplateResponse : AmazonWebServiceResponse
    {
        private BackupPlan _backupPlanDocument;

        /// <summary>
        /// Gets and sets the property BackupPlanDocument. 
        /// <para>
        /// Returns the body of a backup plan based on the target template, including the name,
        /// rules, and backup vault of the plan.
        /// </para>
        /// </summary>
        public BackupPlan BackupPlanDocument
        {
            get { return this._backupPlanDocument; }
            set { this._backupPlanDocument = value; }
        }

        // Check to see if BackupPlanDocument property is set
        internal bool IsSetBackupPlanDocument()
        {
            return this._backupPlanDocument != null;
        }

    }
}