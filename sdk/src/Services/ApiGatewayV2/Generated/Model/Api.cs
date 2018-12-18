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
    /// Represents an API.
    /// </summary>
    public partial class Api
    {
        private string _apiEndpoint;
        private string _apiId;
        private string _apiKeySelectionExpression;
        private DateTime? _createdDate;
        private string _description;
        private bool? _disableSchemaValidation;
        private string _name;
        private ProtocolType _protocolType;
        private string _routeSelectionExpression;
        private string _version;
        private List<string> _warnings = new List<string>();

        /// <summary>
        /// Gets and sets the property ApiEndpoint. 
        /// <para>
        /// The URI of the API, of the form {api-id}.execute-api.{region}.amazonaws.com. The stage
        /// name is typically appended to this URI to form a complete path to a deployed API stage.
        /// </para>
        /// </summary>
        public string ApiEndpoint
        {
            get { return this._apiEndpoint; }
            set { this._apiEndpoint = value; }
        }

        // Check to see if ApiEndpoint property is set
        internal bool IsSetApiEndpoint()
        {
            return this._apiEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API ID.
        /// </para>
        /// </summary>
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKeySelectionExpression. 
        /// <para>
        /// An API key selection expression. See <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-apikey-selection-expressions">API
        /// Key Selection Expressions</a>.
        /// </para>
        /// </summary>
        public string ApiKeySelectionExpression
        {
            get { return this._apiKeySelectionExpression; }
            set { this._apiKeySelectionExpression = value; }
        }

        // Check to see if ApiKeySelectionExpression property is set
        internal bool IsSetApiKeySelectionExpression()
        {
            return this._apiKeySelectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when the API was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the API.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisableSchemaValidation. 
        /// <para>
        /// Avoid validating models when creating a deployment.
        /// </para>
        /// </summary>
        public bool DisableSchemaValidation
        {
            get { return this._disableSchemaValidation.GetValueOrDefault(); }
            set { this._disableSchemaValidation = value; }
        }

        // Check to see if DisableSchemaValidation property is set
        internal bool IsSetDisableSchemaValidation()
        {
            return this._disableSchemaValidation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the API.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The API protocol: HTTP or WEBSOCKET.
        /// </para>
        /// </summary>
        public ProtocolType ProtocolType
        {
            get { return this._protocolType; }
            set { this._protocolType = value; }
        }

        // Check to see if ProtocolType property is set
        internal bool IsSetProtocolType()
        {
            return this._protocolType != null;
        }

        /// <summary>
        /// Gets and sets the property RouteSelectionExpression. 
        /// <para>
        /// The route selection expression for the API.
        /// </para>
        /// </summary>
        public string RouteSelectionExpression
        {
            get { return this._routeSelectionExpression; }
            set { this._routeSelectionExpression = value; }
        }

        // Check to see if RouteSelectionExpression property is set
        internal bool IsSetRouteSelectionExpression()
        {
            return this._routeSelectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A version identifier for the API.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// The warning messages reported when failonwarnings is turned on during API import.
        /// </para>
        /// </summary>
        public List<string> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && this._warnings.Count > 0; 
        }

    }
}