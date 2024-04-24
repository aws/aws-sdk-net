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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the restore for the table.
    /// </summary>
    public partial class AwsDynamoDbTableRestoreSummary
    {
        private string _restoreDateTime;
        private bool? _restoreInProgress;
        private string _sourceBackupArn;
        private string _sourceTableArn;

        /// <summary>
        /// Gets and sets the property RestoreDateTime. 
        /// <para>
        /// Indicates the point in time that the table was restored to.
        /// </para>
        ///  
        /// <para>
        /// This field accepts only the specified formats. Timestamps can end with <c>Z</c> or
        /// <c>("+" / "-") time-hour [":" time-minute]</c>. The time-secfrac after seconds is
        /// limited to a maximum of 9 digits. The offset is bounded by +/-18:00. Here are valid
        /// timestamp formats with examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SSZ</c> (for example, <c>2019-01-31T23:00:00Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmmZ</c> (for example, <c>2019-01-31T23:00:00.123456789Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS+HH:MM</c> (for example, <c>2024-01-04T15:25:10+17:59</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS-HHMM</c> (for example, <c>2024-01-04T15:25:10-1759</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmm+HH:MM</c> (for example, <c>2024-01-04T15:25:10.123456789+17:59</c>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string RestoreDateTime
        {
            get { return this._restoreDateTime; }
            set { this._restoreDateTime = value; }
        }

        // Check to see if RestoreDateTime property is set
        internal bool IsSetRestoreDateTime()
        {
            return this._restoreDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreInProgress. 
        /// <para>
        /// Whether a restore is currently in progress.
        /// </para>
        /// </summary>
        public bool RestoreInProgress
        {
            get { return this._restoreInProgress.GetValueOrDefault(); }
            set { this._restoreInProgress = value; }
        }

        // Check to see if RestoreInProgress property is set
        internal bool IsSetRestoreInProgress()
        {
            return this._restoreInProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceBackupArn. 
        /// <para>
        /// The ARN of the source backup from which the table was restored.
        /// </para>
        /// </summary>
        public string SourceBackupArn
        {
            get { return this._sourceBackupArn; }
            set { this._sourceBackupArn = value; }
        }

        // Check to see if SourceBackupArn property is set
        internal bool IsSetSourceBackupArn()
        {
            return this._sourceBackupArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTableArn. 
        /// <para>
        /// The ARN of the source table for the backup.
        /// </para>
        /// </summary>
        public string SourceTableArn
        {
            get { return this._sourceTableArn; }
            set { this._sourceTableArn = value; }
        }

        // Check to see if SourceTableArn property is set
        internal bool IsSetSourceTableArn()
        {
            return this._sourceTableArn != null;
        }

    }
}