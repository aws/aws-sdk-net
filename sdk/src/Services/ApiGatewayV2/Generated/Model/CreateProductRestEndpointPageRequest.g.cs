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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateProductRestEndpointPage operation. Creates
    /// a product REST endpoint page for a portal product.
    /// </summary>
    public partial class CreateProductRestEndpointPageRequest : AmazonApiGatewayV2Request
    {
        /// <summary>
        /// Gets and sets the property DisplayContent. 
        /// <para>
        /// The content of the product REST endpoint page.
        /// </para>
        /// </summary>
        public EndpointDisplayContent DisplayContent { get; set; }

        /// <summary>
        /// Checks to see if the DisplayContent property is set.
        /// </summary>
        internal bool IsSetDisplayContent() => this.DisplayContent != null;

        /// <summary>
        /// Gets and sets the property PortalProductId. 
        /// <para>
        /// The portal product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PortalProductId { get; set; }

        /// <summary>
        /// Checks to see if the PortalProductId property is set.
        /// </summary>
        internal bool IsSetPortalProductId() => this.PortalProductId != null;

        /// <summary>
        /// Gets and sets the property RestEndpointIdentifier. 
        /// <para>
        /// The REST endpoint identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RestEndpointIdentifier RestEndpointIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RestEndpointIdentifier property is set.
        /// </summary>
        internal bool IsSetRestEndpointIdentifier() => this.RestEndpointIdentifier != null;

        /// <summary>
        /// Gets and sets the property TryItState. 
        /// <para>
        /// The try it state of the product REST endpoint page.
        /// </para>
        /// </summary>
        public TryItState TryItState { get; set; }

        /// <summary>
        /// Checks to see if the TryItState property is set.
        /// </summary>
        internal bool IsSetTryItState() => this.TryItState != null;
    }
}
