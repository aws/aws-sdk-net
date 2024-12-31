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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Settings for using invocation logs to customize a model.
    /// </summary>
    public partial class InvocationLogsConfig
    {
        private InvocationLogSource _invocationLogSource;
        private RequestMetadataFilters _requestMetadataFilters;
        private bool? _usePromptResponse;

        /// <summary>
        /// Gets and sets the property InvocationLogSource. 
        /// <para>
        /// The source of the invocation logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InvocationLogSource InvocationLogSource
        {
            get { return this._invocationLogSource; }
            set { this._invocationLogSource = value; }
        }

        // Check to see if InvocationLogSource property is set
        internal bool IsSetInvocationLogSource()
        {
            return this._invocationLogSource != null;
        }

        /// <summary>
        /// Gets and sets the property RequestMetadataFilters. 
        /// <para>
        /// Rules for filtering invocation logs based on request metadata.
        /// </para>
        /// </summary>
        public RequestMetadataFilters RequestMetadataFilters
        {
            get { return this._requestMetadataFilters; }
            set { this._requestMetadataFilters = value; }
        }

        // Check to see if RequestMetadataFilters property is set
        internal bool IsSetRequestMetadataFilters()
        {
            return this._requestMetadataFilters != null;
        }

        /// <summary>
        /// Gets and sets the property UsePromptResponse. 
        /// <para>
        /// Whether to use the model's response for training, or just the prompt. The default
        /// value is <c>False</c>.
        /// </para>
        /// </summary>
        public bool? UsePromptResponse
        {
            get { return this._usePromptResponse; }
            set { this._usePromptResponse = value; }
        }

        // Check to see if UsePromptResponse property is set
        internal bool IsSetUsePromptResponse()
        {
            return this._usePromptResponse.HasValue; 
        }

    }
}