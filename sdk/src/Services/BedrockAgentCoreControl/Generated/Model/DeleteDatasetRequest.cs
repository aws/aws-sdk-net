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
    /// Container for the parameters to the DeleteDataset operation.
    /// Deletes a dataset version or an entire dataset (all versions + name claim). Asynchronous
    /// 202.
    /// 
    ///  
    /// <para>
    /// <strong>State transitions:</strong>
    /// </para>
    ///  <ul> <li>If <c>datasetVersion</c> is absent (full delete): status transitions to
    /// DELETING immediately.</li> <li>If <c>datasetVersion</c> is provided (version-specific
    /// delete): status transitions to UPDATING.</li> </ul> 
    /// <para>
    /// <strong>State guard (full delete):</strong> Returns ConflictException (DATASET_NOT_READY)
    /// if the dataset status is in {CREATING, UPDATING}. Deletion is allowed from ACTIVE,
    /// CREATE_FAILED, UPDATE_FAILED, and DELETE_FAILED states.
    /// </para>
    ///  
    /// <para>
    /// <strong>State guard (version-specific delete):</strong> Returns ConflictException
    /// (DATASET_NOT_READY) if the dataset status is not in {ACTIVE, CREATE_FAILED, UPDATE_FAILED}.
    /// </para>
    ///  
    /// <para>
    /// Fails with ConflictException (REFERENCED_BY_EVAL_JOB) if referenced by an active evaluation
    /// job (full delete only).
    /// </para>
    ///  
    /// <para>
    /// If the delete workflow fails after retries, status is set to DELETE_FAILED (full delete)
    /// or UPDATE_FAILED (version-specific delete). Calling DeleteDataset on a DELETE_FAILED
    /// dataset re-triggers the delete workflow (idempotent retry path).
    /// </para>
    ///  
    /// <para>
    /// <strong>Version parameter:</strong>
    /// </para>
    ///  <ul> <li>If <c>datasetVersion</c> is absent: deletes ALL versions and the Dataset
    /// record itself.</li> <li>If <c>datasetVersion</c> is provided: deletes only that specific
    /// DatasetVersion. Returns ResourceNotFoundException if the specified version does not
    /// exist.</li> </ul>
    /// </summary>
    public partial class DeleteDatasetRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _datasetId;
        private string _datasetVersion;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        ///  The unique identifier of the dataset to delete. 
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
        /// Optional version to delete. Use &quot;DRAFT&quot; or omit to delete the draft. Returns
        /// ResourceNotFoundException if the specified version does not exist.
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