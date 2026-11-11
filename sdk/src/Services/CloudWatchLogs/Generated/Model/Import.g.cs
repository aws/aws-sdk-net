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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// An import job to move data from CloudTrail Event Data Store to CloudWatch.
    /// </summary>
    public partial class Import
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the import task was created, expressed as the number of milliseconds
        /// after Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message related to any failed imports
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ImportDestinationArn. 
        /// <para>
        /// The ARN of the managed CloudWatch Logs log group where the events are being imported
        /// to.
        /// </para>
        /// </summary>
        public string ImportDestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the ImportDestinationArn property is set.
        /// </summary>
        internal bool IsSetImportDestinationArn() => this.ImportDestinationArn != null;

        /// <summary>
        /// Gets and sets the property ImportFilter. 
        /// <para>
        /// The filter criteria used for this import task.
        /// </para>
        /// </summary>
        public ImportFilter ImportFilter { get; set; }

        /// <summary>
        /// Checks to see if the ImportFilter property is set.
        /// </summary>
        internal bool IsSetImportFilter() => this.ImportFilter != null;

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The unique identifier of the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ImportId { get; set; }

        /// <summary>
        /// Checks to see if the ImportId property is set.
        /// </summary>
        internal bool IsSetImportId() => this.ImportId != null;

        /// <summary>
        /// Gets and sets the property ImportSourceArn. 
        /// <para>
        /// The ARN of the CloudTrail Lake Event Data Store being imported from.
        /// </para>
        /// </summary>
        public string ImportSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ImportSourceArn property is set.
        /// </summary>
        internal bool IsSetImportSourceArn() => this.ImportSourceArn != null;

        /// <summary>
        /// Gets and sets the property ImportStatistics. 
        /// <para>
        /// Statistics about the import progress
        /// </para>
        /// </summary>
        public ImportStatistics ImportStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ImportStatistics property is set.
        /// </summary>
        internal bool IsSetImportStatistics() => this.ImportStatistics != null;

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        /// The current status of the import task. Valid values are IN_PROGRESS, CANCELLED, COMPLETED
        /// and FAILED.
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImportStatus property is set.
        /// </summary>
        internal bool IsSetImportStatus() => this.ImportStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the import task was last updated, expressed as the number of milliseconds
        /// after Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;
    }
}
