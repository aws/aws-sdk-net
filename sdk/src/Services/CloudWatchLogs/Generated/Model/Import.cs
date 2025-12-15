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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
        private long? _creationTime;
        private string _errorMessage;
        private string _importDestinationArn;
        private ImportFilter _importFilter;
        private string _importId;
        private string _importSourceArn;
        private ImportStatistics _importStatistics;
        private ImportStatus _importStatus;
        private long? _lastUpdatedTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the import task was created, expressed as the number of milliseconds
        /// after Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message related to any failed imports
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ImportDestinationArn. 
        /// <para>
        /// The ARN of the managed CloudWatch Logs log group where the events are being imported
        /// to.
        /// </para>
        /// </summary>
        public string ImportDestinationArn
        {
            get { return this._importDestinationArn; }
            set { this._importDestinationArn = value; }
        }

        // Check to see if ImportDestinationArn property is set
        internal bool IsSetImportDestinationArn()
        {
            return this._importDestinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImportFilter. 
        /// <para>
        /// The filter criteria used for this import task.
        /// </para>
        /// </summary>
        public ImportFilter ImportFilter
        {
            get { return this._importFilter; }
            set { this._importFilter = value; }
        }

        // Check to see if ImportFilter property is set
        internal bool IsSetImportFilter()
        {
            return this._importFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The unique identifier of the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ImportId
        {
            get { return this._importId; }
            set { this._importId = value; }
        }

        // Check to see if ImportId property is set
        internal bool IsSetImportId()
        {
            return this._importId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportSourceArn. 
        /// <para>
        /// The ARN of the CloudTrail Lake Event Data Store being imported from.
        /// </para>
        /// </summary>
        public string ImportSourceArn
        {
            get { return this._importSourceArn; }
            set { this._importSourceArn = value; }
        }

        // Check to see if ImportSourceArn property is set
        internal bool IsSetImportSourceArn()
        {
            return this._importSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImportStatistics. 
        /// <para>
        /// Statistics about the import progress
        /// </para>
        /// </summary>
        public ImportStatistics ImportStatistics
        {
            get { return this._importStatistics; }
            set { this._importStatistics = value; }
        }

        // Check to see if ImportStatistics property is set
        internal bool IsSetImportStatistics()
        {
            return this._importStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        /// The current status of the import task. Valid values are IN_PROGRESS, CANCELLED, COMPLETED
        /// and FAILED.
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus
        {
            get { return this._importStatus; }
            set { this._importStatus = value; }
        }

        // Check to see if ImportStatus property is set
        internal bool IsSetImportStatus()
        {
            return this._importStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the import task was last updated, expressed as the number of milliseconds
        /// after Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

    }
}