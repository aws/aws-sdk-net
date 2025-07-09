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
    /// Container for the parameters to the ListFoundationModelAgreementOffers operation.
    /// Get the offers associated with the specified model.
    /// </summary>
    public partial class ListFoundationModelAgreementOffersRequest : AmazonBedrockRequest
    {
        private string _modelId;
        private OfferType _offerType;

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
        /// Gets and sets the property OfferType. 
        /// <para>
        /// Type of offer associated with the model.
        /// </para>
        /// </summary>
        public OfferType OfferType
        {
            get { return this._offerType; }
            set { this._offerType = value; }
        }

        // Check to see if OfferType property is set
        internal bool IsSetOfferType()
        {
            return this._offerType != null;
        }

    }
}