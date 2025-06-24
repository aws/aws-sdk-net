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
    /// An offer dictates usage terms for the model.
    /// </summary>
    public partial class Offer
    {
        private string _offerId;
        private string _offerToken;
        private TermDetails _termDetails;

        /// <summary>
        /// Gets and sets the property OfferId. 
        /// <para>
        /// Offer Id for a model offer.
        /// </para>
        /// </summary>
        public string OfferId
        {
            get { return this._offerId; }
            set { this._offerId = value; }
        }

        // Check to see if OfferId property is set
        internal bool IsSetOfferId()
        {
            return this._offerId != null;
        }

        /// <summary>
        /// Gets and sets the property OfferToken. 
        /// <para>
        /// Offer token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OfferToken
        {
            get { return this._offerToken; }
            set { this._offerToken = value; }
        }

        // Check to see if OfferToken property is set
        internal bool IsSetOfferToken()
        {
            return this._offerToken != null;
        }

        /// <summary>
        /// Gets and sets the property TermDetails. 
        /// <para>
        /// Details about the terms of the offer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TermDetails TermDetails
        {
            get { return this._termDetails; }
            set { this._termDetails = value; }
        }

        // Check to see if TermDetails property is set
        internal bool IsSetTermDetails()
        {
            return this._termDetails != null;
        }

    }
}