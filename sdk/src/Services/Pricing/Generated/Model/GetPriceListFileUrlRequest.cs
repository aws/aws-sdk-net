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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pricing.Model
{
    /// <summary>
    /// Container for the parameters to the GetPriceListFileUrl operation.
    /// <i> <b>This feature is in preview release and is subject to change. Your use of Amazon
    /// Web Services Price List API is subject to the Beta Service Participation terms of
    /// the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service Terms</a>
    /// (Section 1.10).</b> </i> 
    /// 
    ///  
    /// <para>
    /// This returns the URL that you can retrieve your Price List file from. This URL is
    /// based on the <code>PriceListArn</code> and <code>FileFormat</code> that you retrieve
    /// from the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_ListPriceLists.html">
    /// <code>ListPriceLists</code> </a> response. 
    /// </para>
    /// </summary>
    public partial class GetPriceListFileUrlRequest : AmazonPricingRequest
    {
        private string _fileFormat;
        private string _priceListArn;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The format that you want to retrieve your Price List files in. The <code>FileFormat</code>
        /// can be obtained from the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_ListPriceLists.html">
        /// <code>ListPriceLists</code> </a> response. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string FileFormat
        {
            get { return this._fileFormat; }
            set { this._fileFormat = value; }
        }

        // Check to see if FileFormat property is set
        internal bool IsSetFileFormat()
        {
            return this._fileFormat != null;
        }

        /// <summary>
        /// Gets and sets the property PriceListArn. 
        /// <para>
        /// The unique identifier that maps to where your Price List files are located. <code>PriceListArn</code>
        /// can be obtained from the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_ListPriceLists.html">
        /// <code>ListPriceLists</code> </a> response. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=18, Max=2048)]
        public string PriceListArn
        {
            get { return this._priceListArn; }
            set { this._priceListArn = value; }
        }

        // Check to see if PriceListArn property is set
        internal bool IsSetPriceListArn()
        {
            return this._priceListArn != null;
        }

    }
}