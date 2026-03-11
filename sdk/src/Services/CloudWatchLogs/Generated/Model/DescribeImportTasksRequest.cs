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
    /// Container for the parameters to the DescribeImportTasks operation.
    /// Lists and describes import tasks, with optional filtering by import status and source
    /// ARN.
    /// </summary>
    public partial class DescribeImportTasksRequest : AmazonCloudWatchLogsRequest
    {
        private string _importId;
        private string _importSourceArn;
        private ImportStatus _importStatus;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// Optional filter to describe a specific import task by its ID.
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
        /// Optional filter to list imports from a specific source
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
        /// Gets and sets the property ImportStatus. 
        /// <para>
        /// Optional filter to list imports by their status. Valid values are IN_PROGRESS, CANCELLED,
        /// COMPLETED and FAILED.
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of import tasks to return in the response. Default: 50
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}