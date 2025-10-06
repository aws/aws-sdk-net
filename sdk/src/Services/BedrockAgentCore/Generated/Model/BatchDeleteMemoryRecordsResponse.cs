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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the BatchDeleteMemoryRecords operation.
    /// </summary>
    public partial class BatchDeleteMemoryRecordsResponse : AmazonWebServiceResponse
    {
        private List<MemoryRecordOutput> _failedRecords = AWSConfigs.InitializeCollections ? new List<MemoryRecordOutput>() : null;
        private List<MemoryRecordOutput> _successfulRecords = AWSConfigs.InitializeCollections ? new List<MemoryRecordOutput>() : null;

        /// <summary>
        /// Gets and sets the property FailedRecords. 
        /// <para>
        /// A list of memory records that failed to be deleted, including error details for each
        /// failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MemoryRecordOutput> FailedRecords
        {
            get { return this._failedRecords; }
            set { this._failedRecords = value; }
        }

        // Check to see if FailedRecords property is set
        internal bool IsSetFailedRecords()
        {
            return this._failedRecords != null && (this._failedRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulRecords. 
        /// <para>
        /// A list of memory records that were successfully deleted during the batch operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MemoryRecordOutput> SuccessfulRecords
        {
            get { return this._successfulRecords; }
            set { this._successfulRecords = value; }
        }

        // Check to see if SuccessfulRecords property is set
        internal bool IsSetSuccessfulRecords()
        {
            return this._successfulRecords != null && (this._successfulRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}