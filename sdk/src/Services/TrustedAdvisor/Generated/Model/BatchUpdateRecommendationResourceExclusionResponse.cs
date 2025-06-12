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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
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
namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateRecommendationResourceExclusion operation.
    /// </summary>
    public partial class BatchUpdateRecommendationResourceExclusionResponse : AmazonWebServiceResponse
    {
        private List<UpdateRecommendationResourceExclusionError> _batchUpdateRecommendationResourceExclusionErrors = AWSConfigs.InitializeCollections ? new List<UpdateRecommendationResourceExclusionError>() : null;

        /// <summary>
        /// Gets and sets the property BatchUpdateRecommendationResourceExclusionErrors. 
        /// <para>
        /// A list of recommendation resource ARNs whose exclusion status failed to update, if
        /// any
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<UpdateRecommendationResourceExclusionError> BatchUpdateRecommendationResourceExclusionErrors
        {
            get { return this._batchUpdateRecommendationResourceExclusionErrors; }
            set { this._batchUpdateRecommendationResourceExclusionErrors = value; }
        }

        // Check to see if BatchUpdateRecommendationResourceExclusionErrors property is set
        internal bool IsSetBatchUpdateRecommendationResourceExclusionErrors()
        {
            return this._batchUpdateRecommendationResourceExclusionErrors != null && (this._batchUpdateRecommendationResourceExclusionErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}