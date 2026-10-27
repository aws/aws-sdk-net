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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Contains details for the restore.
    /// </summary>
    public partial class RestoreSummary
    {
        /// <summary>
        /// Gets and sets the property RestoreDateTime. 
        /// <para>
        /// Point in time or source backup time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? RestoreDateTime { get; set; }

        /// <summary>
        /// Checks to see if the RestoreDateTime property is set.
        /// </summary>
        internal bool IsSetRestoreDateTime() => this.RestoreDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property RestoreInProgress. 
        /// <para>
        /// Indicates if a restore is in progress or not.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? RestoreInProgress { get; set; }

        /// <summary>
        /// Checks to see if the RestoreInProgress property is set.
        /// </summary>
        internal bool IsSetRestoreInProgress() => this.RestoreInProgress.HasValue;

        /// <summary>
        /// Gets and sets the property SourceBackupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the backup from which the table was restored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string SourceBackupArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackupArn property is set.
        /// </summary>
        internal bool IsSetSourceBackupArn() => this.SourceBackupArn != null;

        /// <summary>
        /// Gets and sets the property SourceTableArn. 
        /// <para>
        /// The ARN of the source table of the backup that is being restored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SourceTableArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceTableArn property is set.
        /// </summary>
        internal bool IsSetSourceTableArn() => this.SourceTableArn != null;
    }
}
