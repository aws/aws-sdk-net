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
    /// Container for the parameters to the BatchGetEffectiveLifecyclePolicy operation.
    /// Returns a list of successful and failed retrievals for the OpenSearch Serverless indexes.
    /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-lifecycle.html#serverless-lifecycle-list">Viewing
    /// data lifecycle policies</a>.
    /// </summary>
    public partial class BatchGetEffectiveLifecyclePolicyRequest : AmazonOpenSearchServerlessRequest
    {
        private List<LifecyclePolicyResourceIdentifier> _resourceIdentifiers = AWSConfigs.InitializeCollections ? new List<LifecyclePolicyResourceIdentifier>() : null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifiers. 
        /// <para>
        /// The unique identifiers of policy types and resource names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<LifecyclePolicyResourceIdentifier> ResourceIdentifiers
        {
            get { return this._resourceIdentifiers; }
            set { this._resourceIdentifiers = value; }
        }

        // Check to see if ResourceIdentifiers property is set
        internal bool IsSetResourceIdentifiers()
        {
            return this._resourceIdentifiers != null && (this._resourceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}