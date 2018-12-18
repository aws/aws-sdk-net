/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the UpdateRouteResponse operation.
    /// </summary>
    public partial class UpdateRouteResponseResponse : AmazonWebServiceResponse
    {
        private string _modelSelectionExpression;
        private Dictionary<string, string> _responseModels = new Dictionary<string, string>();
        private Dictionary<string, ParameterConstraints> _responseParameters = new Dictionary<string, ParameterConstraints>();
        private string _routeResponseId;
        private string _routeResponseKey;

        /// <summary>
        /// Gets and sets the property ModelSelectionExpression. 
        /// <para>
        /// Represents the model selection expression of a route response.
        /// </para>
        /// </summary>
        public string ModelSelectionExpression
        {
            get { return this._modelSelectionExpression; }
            set { this._modelSelectionExpression = value; }
        }

        // Check to see if ModelSelectionExpression property is set
        internal bool IsSetModelSelectionExpression()
        {
            return this._modelSelectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseModels. 
        /// <para>
        /// Represents the response models of a route response.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseModels
        {
            get { return this._responseModels; }
            set { this._responseModels = value; }
        }

        // Check to see if ResponseModels property is set
        internal bool IsSetResponseModels()
        {
            return this._responseModels != null && this._responseModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// Represents the response parameters of a route response.
        /// </para>
        /// </summary>
        public Dictionary<string, ParameterConstraints> ResponseParameters
        {
            get { return this._responseParameters; }
            set { this._responseParameters = value; }
        }

        // Check to see if ResponseParameters property is set
        internal bool IsSetResponseParameters()
        {
            return this._responseParameters != null && this._responseParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RouteResponseId. 
        /// <para>
        /// Represents the identifier of a route response.
        /// </para>
        /// </summary>
        public string RouteResponseId
        {
            get { return this._routeResponseId; }
            set { this._routeResponseId = value; }
        }

        // Check to see if RouteResponseId property is set
        internal bool IsSetRouteResponseId()
        {
            return this._routeResponseId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteResponseKey. 
        /// <para>
        /// Represents the route response key of a route response.
        /// </para>
        /// </summary>
        public string RouteResponseKey
        {
            get { return this._routeResponseKey; }
            set { this._routeResponseKey = value; }
        }

        // Check to see if RouteResponseKey property is set
        internal bool IsSetRouteResponseKey()
        {
            return this._routeResponseKey != null;
        }

    }
}