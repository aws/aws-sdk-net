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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
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
namespace Amazon.BedrockDataAutomationRuntime.Model
{
    /// <summary>
    /// Invoke Data Automation Response
    /// </summary>
    public partial class InvokeDataAutomationResponse : AmazonWebServiceResponse
    {
        private List<OutputSegment> _outputSegments = AWSConfigs.InitializeCollections ? new List<OutputSegment>() : null;
        private SemanticModality _semanticModality;

        /// <summary>
        /// Gets and sets the property OutputSegments. 
        /// <para>
        /// List of outputs for each logical sub-doc
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<OutputSegment> OutputSegments
        {
            get { return this._outputSegments; }
            set { this._outputSegments = value; }
        }

        // Check to see if OutputSegments property is set
        internal bool IsSetOutputSegments()
        {
            return this._outputSegments != null && (this._outputSegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SemanticModality. 
        /// <para>
        /// Detected semantic modality
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SemanticModality SemanticModality
        {
            get { return this._semanticModality; }
            set { this._semanticModality = value; }
        }

        // Check to see if SemanticModality property is set
        internal bool IsSetSemanticModality()
        {
            return this._semanticModality != null;
        }

    }
}