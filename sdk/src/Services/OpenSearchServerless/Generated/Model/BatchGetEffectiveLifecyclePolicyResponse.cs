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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// This is the response object from the BatchGetEffectiveLifecyclePolicy operation.
    /// </summary>
    public partial class BatchGetEffectiveLifecyclePolicyResponse : AmazonWebServiceResponse
    {
        private List<EffectiveLifecyclePolicyDetail> _effectiveLifecyclePolicyDetails = AWSConfigs.InitializeCollections ? new List<EffectiveLifecyclePolicyDetail>() : null;
        private List<EffectiveLifecyclePolicyErrorDetail> _effectiveLifecyclePolicyErrorDetails = AWSConfigs.InitializeCollections ? new List<EffectiveLifecyclePolicyErrorDetail>() : null;

        /// <summary>
        /// Gets and sets the property EffectiveLifecyclePolicyDetails. 
        /// <para>
        /// A list of lifecycle policies applied to the OpenSearch Serverless indexes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EffectiveLifecyclePolicyDetail> EffectiveLifecyclePolicyDetails
        {
            get { return this._effectiveLifecyclePolicyDetails; }
            set { this._effectiveLifecyclePolicyDetails = value; }
        }

        // Check to see if EffectiveLifecyclePolicyDetails property is set
        internal bool IsSetEffectiveLifecyclePolicyDetails()
        {
            return this._effectiveLifecyclePolicyDetails != null && (this._effectiveLifecyclePolicyDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EffectiveLifecyclePolicyErrorDetails. 
        /// <para>
        /// A list of resources for which retrieval failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EffectiveLifecyclePolicyErrorDetail> EffectiveLifecyclePolicyErrorDetails
        {
            get { return this._effectiveLifecyclePolicyErrorDetails; }
            set { this._effectiveLifecyclePolicyErrorDetails = value; }
        }

        // Check to see if EffectiveLifecyclePolicyErrorDetails property is set
        internal bool IsSetEffectiveLifecyclePolicyErrorDetails()
        {
            return this._effectiveLifecyclePolicyErrorDetails != null && (this._effectiveLifecyclePolicyErrorDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}