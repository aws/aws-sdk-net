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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the GetDataset operation.
    /// Retrieves dataset metadata only.
    /// 
    ///  
    /// <para>
    /// Use <c>?datasetVersion=DRAFT</c> or <c>?datasetVersion=N</c> to retrieve a specific
    /// version's metadata. If absent, defaults to DRAFT (the mutable working copy). Returns
    /// ResourceNotFoundException if the specified version is not found.
    /// </para>
    ///  
    /// <para>
    /// <strong>Initial state after CreateDataset:</strong> When CreateDataset completes successfully
    /// (status transitions to ACTIVE), only a DRAFT working copy exists. No published versions
    /// exist until CreateDatasetVersion is called. At this point draftStatus is MODIFIED
    /// because the DRAFT has content that has never been published.
    /// </para>
    ///  
    /// <para>
    /// <strong>Default version behavior:</strong> When <c>datasetVersion</c> is omitted,
    /// the operation returns the DRAFT working copy. To retrieve a specific published version,
    /// pass the version number as a string (e.g. <c>?datasetVersion=1</c>).
    /// </para>
    ///  
    /// <para>
    /// <strong>State guard:</strong> Allowed for all statuses including DELETING. Returns
    /// the dataset record with its current status so callers can observe the deletion in
    /// progress.
    /// </para>
    ///  
    /// <para>
    /// For paginated example IDs use ListDatasetExamples.
    /// </para>
    /// </summary>
    public partial class GetDatasetRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _datasetId;
        private string _datasetVersion;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        ///  The unique identifier of the dataset to retrieve. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        /// Version to retrieve: &quot;DRAFT&quot; or a version number. Defaults to DRAFT if absent.
        /// </para>
        /// </summary>
        public string DatasetVersion
        {
            get { return this._datasetVersion; }
            set { this._datasetVersion = value; }
        }

        // Check to see if DatasetVersion property is set
        internal bool IsSetDatasetVersion()
        {
            return this._datasetVersion != null;
        }

    }
}