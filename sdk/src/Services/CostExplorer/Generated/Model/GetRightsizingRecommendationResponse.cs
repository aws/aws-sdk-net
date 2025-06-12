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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetRightsizingRecommendation operation.
    /// </summary>
    public partial class GetRightsizingRecommendationResponse : AmazonWebServiceResponse
    {
        private RightsizingRecommendationConfiguration _configuration;
        private RightsizingRecommendationMetadata _metadata;
        private string _nextPageToken;
        private List<RightsizingRecommendation> _rightsizingRecommendations = AWSConfigs.InitializeCollections ? new List<RightsizingRecommendation>() : null;
        private RightsizingRecommendationSummary _summary;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// You can use Configuration to customize recommendations across two attributes. You
        /// can choose to view recommendations for instances within the same instance families
        /// or across different instance families. You can also choose to view your estimated
        /// savings that are associated with recommendations with consideration of existing Savings
        /// Plans or RI benefits, or neither. 
        /// </para>
        /// </summary>
        public RightsizingRecommendationConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Information regarding this specific recommendation set.
        /// </para>
        /// </summary>
        public RightsizingRecommendationMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property RightsizingRecommendations. 
        /// <para>
        /// Recommendations to rightsize resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RightsizingRecommendation> RightsizingRecommendations
        {
            get { return this._rightsizingRecommendations; }
            set { this._rightsizingRecommendations = value; }
        }

        // Check to see if RightsizingRecommendations property is set
        internal bool IsSetRightsizingRecommendations()
        {
            return this._rightsizingRecommendations != null && (this._rightsizingRecommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Summary of this recommendation set.
        /// </para>
        /// </summary>
        public RightsizingRecommendationSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}