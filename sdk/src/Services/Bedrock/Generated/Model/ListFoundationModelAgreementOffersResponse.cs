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
    /// This is the response object from the ListFoundationModelAgreementOffers operation.
    /// </summary>
    public partial class ListFoundationModelAgreementOffersResponse : AmazonWebServiceResponse
    {
        private string _modelId;
        private List<Offer> _offers = AWSConfigs.InitializeCollections ? new List<Offer>() : null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// Model Id of the foundation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=140)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property Offers. 
        /// <para>
        /// List of the offers associated with the specified model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Offer> Offers
        {
            get { return this._offers; }
            set { this._offers = value; }
        }

        // Check to see if Offers property is set
        internal bool IsSetOffers()
        {
            return this._offers != null && (this._offers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}