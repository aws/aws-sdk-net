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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// The display order.
    /// </summary>
    public partial class DisplayOrder
    {
        private List<Section> _contents = AWSConfigs.InitializeCollections ? new List<Section>() : null;
        private string _overviewPageArn;
        private List<string> _productPageArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Contents. 
        /// <para>
        /// Represents a list of sections which include section name and list of product REST
        /// endpoints for a product.
        /// </para>
        /// </summary>
        public List<Section> Contents
        {
            get { return this._contents; }
            set { this._contents = value; }
        }

        // Check to see if Contents property is set
        internal bool IsSetContents()
        {
            return this._contents != null && (this._contents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OverviewPageArn. 
        /// <para>
        /// The ARN of the overview page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string OverviewPageArn
        {
            get { return this._overviewPageArn; }
            set { this._overviewPageArn = value; }
        }

        // Check to see if OverviewPageArn property is set
        internal bool IsSetOverviewPageArn()
        {
            return this._overviewPageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProductPageArns. 
        /// <para>
        /// The product page ARNs.
        /// </para>
        /// </summary>
        public List<string> ProductPageArns
        {
            get { return this._productPageArns; }
            set { this._productPageArns = value; }
        }

        // Check to see if ProductPageArns property is set
        internal bool IsSetProductPageArns()
        {
            return this._productPageArns != null && (this._productPageArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}