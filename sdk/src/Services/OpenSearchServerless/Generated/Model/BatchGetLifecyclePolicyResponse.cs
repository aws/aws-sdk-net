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
    /// This is the response object from the BatchGetLifecyclePolicy operation.
    /// </summary>
    public partial class BatchGetLifecyclePolicyResponse : AmazonWebServiceResponse
    {
        private List<LifecyclePolicyDetail> _lifecyclePolicyDetails = AWSConfigs.InitializeCollections ? new List<LifecyclePolicyDetail>() : null;
        private List<LifecyclePolicyErrorDetail> _lifecyclePolicyErrorDetails = AWSConfigs.InitializeCollections ? new List<LifecyclePolicyErrorDetail>() : null;

        /// <summary>
        /// Gets and sets the property LifecyclePolicyDetails. 
        /// <para>
        /// A list of lifecycle policies matched to the input policy name and policy type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecyclePolicyDetail> LifecyclePolicyDetails
        {
            get { return this._lifecyclePolicyDetails; }
            set { this._lifecyclePolicyDetails = value; }
        }

        // Check to see if LifecyclePolicyDetails property is set
        internal bool IsSetLifecyclePolicyDetails()
        {
            return this._lifecyclePolicyDetails != null && (this._lifecyclePolicyDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LifecyclePolicyErrorDetails. 
        /// <para>
        /// A list of lifecycle policy names and policy types for which retrieval failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecyclePolicyErrorDetail> LifecyclePolicyErrorDetails
        {
            get { return this._lifecyclePolicyErrorDetails; }
            set { this._lifecyclePolicyErrorDetails = value; }
        }

        // Check to see if LifecyclePolicyErrorDetails property is set
        internal bool IsSetLifecyclePolicyErrorDetails()
        {
            return this._lifecyclePolicyErrorDetails != null && (this._lifecyclePolicyErrorDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}