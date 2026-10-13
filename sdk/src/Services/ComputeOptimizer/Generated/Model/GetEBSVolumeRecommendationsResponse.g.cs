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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// This is the response object from the GetEBSVolumeRecommendations operation.
    /// </summary>
    public partial class GetEBSVolumeRecommendationsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of objects that describe errors of the request.
        /// </para>
        ///  
        /// <para>
        /// For example, an error is returned if you request recommendations for an unsupported
        /// volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GetRecommendationError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<GetRecommendationError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to advance to the next page of volume recommendations.
        /// </para>
        ///  
        /// <para>
        /// This value is null when there are no more pages of volume recommendations to return.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property VolumeRecommendations. 
        /// <para>
        /// An array of objects that describe volume recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeRecommendation> VolumeRecommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<VolumeRecommendation>() : null;

        /// <summary>
        /// Checks to see if the VolumeRecommendations property is set.
        /// </summary>
        internal bool IsSetVolumeRecommendations() => this.VolumeRecommendations != null && (this.VolumeRecommendations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
