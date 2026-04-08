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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// This is the response object from the GetRenewalPricing operation.
    /// </summary>
    public partial class GetRenewalPricingResponse : AmazonWebServiceResponse
    {
        private List<PricingOption> _pricingOptions = AWSConfigs.InitializeCollections ? new List<PricingOption>() : null;
        private PricingResult _pricingResult;

        /// <summary>
        /// Gets and sets the property PricingOptions. 
        /// <para>
        /// The pricing options for the specified Outpost.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PricingOption> PricingOptions
        {
            get { return this._pricingOptions; }
            set { this._pricingOptions = value; }
        }

        // Check to see if PricingOptions property is set
        internal bool IsSetPricingOptions()
        {
            return this._pricingOptions != null && (this._pricingOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PricingResult. 
        /// <para>
        /// The result of the pricing request.
        /// </para>
        /// </summary>
        public PricingResult PricingResult
        {
            get { return this._pricingResult; }
            set { this._pricingResult = value; }
        }

        // Check to see if PricingResult property is set
        internal bool IsSetPricingResult()
        {
            return this._pricingResult != null;
        }

    }
}