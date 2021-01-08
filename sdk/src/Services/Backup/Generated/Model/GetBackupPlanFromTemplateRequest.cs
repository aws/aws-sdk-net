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
    /// Container for the parameters to the GetBackupPlanFromTemplate operation.
    /// Returns the template specified by its <code>templateId</code> as a backup plan.
    /// </summary>
    public partial class GetBackupPlanFromTemplateRequest : AmazonBackupRequest
    {
        private string _backupPlanTemplateId;

        /// <summary>
        /// Gets and sets the property BackupPlanTemplateId. 
        /// <para>
        /// Uniquely identifies a stored backup plan template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupPlanTemplateId
        {
            get { return this._backupPlanTemplateId; }
            set { this._backupPlanTemplateId = value; }
        }

        // Check to see if BackupPlanTemplateId property is set
        internal bool IsSetBackupPlanTemplateId()
        {
            return this._backupPlanTemplateId != null;
        }

    }
}