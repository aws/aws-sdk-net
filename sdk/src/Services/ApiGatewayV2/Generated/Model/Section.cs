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
    /// Contains the section name and list of product REST endpoints for a product.
    /// </summary>
    public partial class Section
    {
        private List<string> _productRestEndpointPageArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sectionName;

        /// <summary>
        /// Gets and sets the property ProductRestEndpointPageArns. 
        /// <para>
        /// The ARNs of the product REST endpoint pages in a portal product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ProductRestEndpointPageArns
        {
            get { return this._productRestEndpointPageArns; }
            set { this._productRestEndpointPageArns = value; }
        }

        // Check to see if ProductRestEndpointPageArns property is set
        internal bool IsSetProductRestEndpointPageArns()
        {
            return this._productRestEndpointPageArns != null && (this._productRestEndpointPageArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SectionName. 
        /// <para>
        /// The section name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SectionName
        {
            get { return this._sectionName; }
            set { this._sectionName = value; }
        }

        // Check to see if SectionName property is set
        internal bool IsSetSectionName()
        {
            return this._sectionName != null;
        }

    }
}