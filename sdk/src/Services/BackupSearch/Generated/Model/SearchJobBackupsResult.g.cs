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

namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This contains the information about recovery points returned in results of a search
    /// job.
    /// </summary>
    public partial class SearchJobBackupsResult
    {
        /// <summary>
        /// Gets and sets the property BackupCreationTime. 
        /// <para>
        /// This is the creation time of the backup (recovery point).
        /// </para>
        /// </summary>
        public DateTime? BackupCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the BackupCreationTime property is set.
        /// </summary>
        internal bool IsSetBackupCreationTime() => this.BackupCreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property BackupResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the backup resources.
        /// </para>
        /// </summary>
        public string BackupResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupResourceArn property is set.
        /// </summary>
        internal bool IsSetBackupResourceArn() => this.BackupResourceArn != null;

        /// <summary>
        /// Gets and sets the property IndexCreationTime. 
        /// <para>
        /// This is the creation time of the backup index.
        /// </para>
        /// </summary>
        public DateTime? IndexCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the IndexCreationTime property is set.
        /// </summary>
        internal bool IsSetIndexCreationTime() => this.IndexCreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// This is the resource type of the search.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the source resources.
        /// </para>
        /// </summary>
        public string SourceResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceResourceArn property is set.
        /// </summary>
        internal bool IsSetSourceResourceArn() => this.SourceResourceArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This is the status of the search job backup result.
        /// </para>
        /// </summary>
        public SearchJobState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// This is the status message included with the results.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
