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
    /// This is the response object from the DescribeImportTaskBatches operation.
    /// </summary>
    public partial class DescribeImportTaskBatchesResponse : AmazonWebServiceResponse
    {
        private List<ImportBatch> _importBatches = AWSConfigs.InitializeCollections ? new List<ImportBatch>() : null;
        private string _importId;
        private string _importSourceArn;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImportBatches. 
        /// <para>
        /// The list of import batches that match the request filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImportBatch> ImportBatches
        {
            get { return this._importBatches; }
            set { this._importBatches = value; }
        }

        // Check to see if ImportBatches property is set
        internal bool IsSetImportBatches()
        {
            return this._importBatches != null && (this._importBatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The ID of the import task.
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
        /// The ARN of the source being imported from.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of results. Not present if there are
        /// no additional results to retrieve.
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