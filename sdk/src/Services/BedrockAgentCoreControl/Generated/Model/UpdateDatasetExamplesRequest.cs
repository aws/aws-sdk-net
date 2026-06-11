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
    /// Container for the parameters to the UpdateDatasetExamples operation.
    /// Updates multiple existing examples in-place on DRAFT.
    /// 
    ///  
    /// <para>
    /// <strong>Validation:</strong> All examples are validated against the dataset's schemaType
    /// before any writes occur. If any example fails validation, the entire batch is rejected
    /// with ValidationException — no examples are updated (all-or-nothing semantics).
    /// </para>
    ///  
    /// <para>
    /// <strong>Asynchronous:</strong> Operates in-place on DRAFT. No version bump occurs.
    /// Use CreateDatasetVersion to publish DRAFT as a new numbered version.
    /// </para>
    ///  
    /// <para>
    /// Fails with ResourceNotFoundException if any exampleId does not exist in DRAFT. To
    /// add new examples, use AddDatasetExamples instead.
    /// </para>
    ///  
    /// <para>
    /// <strong>State guard:</strong> Returns ConflictException (DATASET_NOT_READY) if the
    /// dataset status is not in {DRAFT, ACTIVE}.
    /// </para>
    ///  
    /// <para>
    /// <strong>Request size limit:</strong> Max 5 MB total request body. Max 1000 examples
    /// per call.
    /// </para>
    /// </summary>
    public partial class UpdateDatasetExamplesRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private string _datasetId;
        private List<Amazon.Runtime.Documents.Document> _examples = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;

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
        ///  The unique identifier of the dataset. 
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
        /// Gets and sets the property Examples. 
        /// <para>
        /// Examples to update. Each element is a JSON object containing a required <c>exampleId</c>
        /// string field identifying the existing example, plus the replacement fields. The <c>exampleId</c>
        /// is extracted and removed before persistence; the remaining document is validated against
        /// the dataset's schemaType. Max 1000 examples per call. Total request body must not
        /// exceed 5 MB.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<Amazon.Runtime.Documents.Document> Examples
        {
            get { return this._examples; }
            set { this._examples = value; }
        }

        // Check to see if Examples property is set
        internal bool IsSetExamples()
        {
            return this._examples != null && (this._examples.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}