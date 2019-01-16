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
    /// Container for the parameters to the GetBackupPlanFromJSON operation.
    /// Returns a valid JSON document specifying a backup plan or an error.
    /// </summary>
    public partial class GetBackupPlanFromJSONRequest : AmazonBackupRequest
    {
        private string _backupPlanTemplateJson;

        /// <summary>
        /// Gets and sets the property BackupPlanTemplateJson. 
        /// <para>
        /// A customer-supplied backup plan document in JSON format.
        /// </para>
        /// </summary>
        public string BackupPlanTemplateJson
        {
            get { return this._backupPlanTemplateJson; }
            set { this._backupPlanTemplateJson = value; }
        }

        // Check to see if BackupPlanTemplateJson property is set
        internal bool IsSetBackupPlanTemplateJson()
        {
            return this._backupPlanTemplateJson != null;
        }

    }
}