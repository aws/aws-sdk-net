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
    /// Container for the parameters to the CreateProductRestEndpointPage operation.
    /// Creates a product REST endpoint page for a portal product.
    /// </summary>
    public partial class CreateProductRestEndpointPageRequest : AmazonApiGatewayV2Request
    {
        private EndpointDisplayContent _displayContent;
        private string _portalProductId;
        private RestEndpointIdentifier _restEndpointIdentifier;
        private TryItState _tryItState;

        /// <summary>
        /// Gets and sets the property DisplayContent. 
        /// <para>
        /// The content of the product REST endpoint page.
        /// </para>
        /// </summary>
        public EndpointDisplayContent DisplayContent
        {
            get { return this._displayContent; }
            set { this._displayContent = value; }
        }

        // Check to see if DisplayContent property is set
        internal bool IsSetDisplayContent()
        {
            return this._displayContent != null;
        }

        /// <summary>
        /// Gets and sets the property PortalProductId. 
        /// <para>
        /// The portal product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PortalProductId
        {
            get { return this._portalProductId; }
            set { this._portalProductId = value; }
        }

        // Check to see if PortalProductId property is set
        internal bool IsSetPortalProductId()
        {
            return this._portalProductId != null;
        }

        /// <summary>
        /// Gets and sets the property RestEndpointIdentifier. 
        /// <para>
        /// The REST endpoint identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RestEndpointIdentifier RestEndpointIdentifier
        {
            get { return this._restEndpointIdentifier; }
            set { this._restEndpointIdentifier = value; }
        }

        // Check to see if RestEndpointIdentifier property is set
        internal bool IsSetRestEndpointIdentifier()
        {
            return this._restEndpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TryItState. 
        /// <para>
        /// The try it state of the product REST endpoint page.
        /// </para>
        /// </summary>
        public TryItState TryItState
        {
            get { return this._tryItState; }
            set { this._tryItState = value; }
        }

        // Check to see if TryItState property is set
        internal bool IsSetTryItState()
        {
            return this._tryItState != null;
        }

    }
}