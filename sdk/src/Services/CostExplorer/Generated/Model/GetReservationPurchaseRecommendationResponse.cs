/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetReservationPurchaseRecommendation operation.
    /// </summary>
    public partial class GetReservationPurchaseRecommendationResponse : AmazonWebServiceResponse
    {
        private ReservationPurchaseRecommendationMetadata _metadata;
        private string _nextPageToken;
        private List<ReservationPurchaseRecommendation> _recommendations = new List<ReservationPurchaseRecommendation>();

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Information about this specific recommendation call, such as the time stamp for when
        /// Cost Explorer generated this recommendation.
        /// </para>
        /// </summary>
        public ReservationPurchaseRecommendationMetadata Metadata
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
        /// The pagination token for the next set of retrievable results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// Recommendations for reservations to purchase.
        /// </para>
        /// </summary>
        public List<ReservationPurchaseRecommendation> Recommendations
        {
            get { return this._recommendations; }
            set { this._recommendations = value; }
        }

        // Check to see if Recommendations property is set
        internal bool IsSetRecommendations()
        {
            return this._recommendations != null && this._recommendations.Count > 0; 
        }

    }
}