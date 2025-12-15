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
    /// This is the response object from the CancelImportTask operation.
    /// </summary>
    public partial class CancelImportTaskResponse : AmazonWebServiceResponse
    {
        private long? _creationTime;
        private string _importId;
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
        public long? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The ID of the cancelled import task.
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
        /// Gets and sets the property ImportStatistics. 
        /// <para>
        /// Statistics about the import progress at the time of cancellation.
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
        /// The final status of the import task. This will be set to CANCELLED.
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
        /// The timestamp when the import task was cancelled, expressed as the number of milliseconds
        /// after Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

    }
}