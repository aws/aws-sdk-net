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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// This is the response object from the Suggest operation.
    /// </summary>
    public partial class SuggestResponse : AmazonWebServiceResponse
    {
        private string _pricingBucket;
        private List<QueryRefinement> _queryRefinements = AWSConfigs.InitializeCollections ? new List<QueryRefinement>() : null;
        private List<SuggestResultItem> _resultItems = AWSConfigs.InitializeCollections ? new List<SuggestResultItem>() : null;

        /// <summary>
        /// Gets and sets the property PricingBucket. 
        /// <para>
        /// The pricing bucket for which the query is charged at.
        /// </para>
        ///  
        /// <para>
        /// For more inforamtion on pricing, please visit <a href="https://aws.amazon.com/location/pricing/">Amazon
        /// Location Service Pricing</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PricingBucket
        {
            get { return this._pricingBucket; }
            set { this._pricingBucket = value; }
        }

        // Check to see if PricingBucket property is set
        internal bool IsSetPricingBucket()
        {
            return !string.IsNullOrEmpty(this._pricingBucket);
        }

        /// <summary>
        /// Gets and sets the property QueryRefinements. 
        /// <para>
        /// Maximum number of query terms to be returned for use with a search text query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<QueryRefinement> QueryRefinements
        {
            get { return this._queryRefinements; }
            set { this._queryRefinements = value; }
        }

        // Check to see if QueryRefinements property is set
        internal bool IsSetQueryRefinements()
        {
            return this._queryRefinements != null && (this._queryRefinements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResultItems. 
        /// <para>
        /// List of places or results returned for a query. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<SuggestResultItem> ResultItems
        {
            get { return this._resultItems; }
            set { this._resultItems = value; }
        }

        // Check to see if ResultItems property is set
        internal bool IsSetResultItems()
        {
            return this._resultItems != null && (this._resultItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}