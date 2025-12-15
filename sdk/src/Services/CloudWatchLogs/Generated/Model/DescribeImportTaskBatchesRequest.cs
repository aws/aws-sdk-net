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
    /// Container for the parameters to the DescribeImportTaskBatches operation.
    /// Gets detailed information about the individual batches within an import task, including
    /// their status and any error messages. For CloudTrail Event Data Store sources, a batch
    /// refers to a subset of stored events grouped by their eventTime.
    /// </summary>
    public partial class DescribeImportTaskBatchesRequest : AmazonCloudWatchLogsRequest
    {
        private List<string> _batchImportStatus = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _importId;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BatchImportStatus. 
        /// <para>
        /// Optional filter to list import batches by their status. Accepts multiple status values:
        /// IN_PROGRESS, CANCELLED, COMPLETED and FAILED.
        /// </para>
        /// </summary>
        public List<string> BatchImportStatus
        {
            get { return this._batchImportStatus; }
            set { this._batchImportStatus = value; }
        }

        // Check to see if BatchImportStatus property is set
        internal bool IsSetBatchImportStatus()
        {
            return this._batchImportStatus != null && (this._batchImportStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The ID of the import task to get batch information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of import batches to return in the response. Default: 10
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
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