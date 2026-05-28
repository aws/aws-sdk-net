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
    /// Container for the parameters to the CreateDatasetVersion operation.
    /// Publishes the current DRAFT as a new numbered version.
    /// 
    ///  
    /// <para>
    /// Snapshots the DRAFT examples as the next version (1, 2, 3, ...). The DRAFT is preserved
    /// and remains editable after publishing. Returns immediately with status UPDATING. Poll
    /// GetDataset until status transitions to ACTIVE (draftStatus=UNMODIFIED) or UPDATE_FAILED.
    /// </para>
    ///  
    /// <para>
    /// <strong>State guard:</strong> Returns ConflictException (DATASET_NOT_READY) if status
    /// is in {CREATING, UPDATING, DELETING}, or DATASET_IN_FAILED_STATE if status is in {CREATE_FAILED,
    /// DELETE_FAILED}.
    /// </para>
    ///  
    /// <para>
    /// <strong>Quota:</strong> MAX_VERSIONS_PER_DATASET applies to published versions only
    /// (not DRAFT).
    /// </para>
    /// </summary>
    public partial class CreateDatasetVersionRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private string _datasetId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        ///  The unique identifier of the dataset to publish a version for. 
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

    }
}