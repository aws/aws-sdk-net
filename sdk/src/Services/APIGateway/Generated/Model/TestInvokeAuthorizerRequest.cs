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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the TestInvokeAuthorizer operation.
    /// Simulate the execution of an <a>Authorizer</a> in your <a>RestApi</a> with headers,
    /// parameters, and an incoming request body.
    /// 
    ///  <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/use-custom-authorizer.html">Enable
    /// custom authorizers</a> </div>
    /// </summary>
    public partial class TestInvokeAuthorizerRequest : AmazonAPIGatewayRequest
    {
        private Dictionary<string, string> _additionalContext = new Dictionary<string, string>();
        private string _authorizerId;
        private string _body;
        private Dictionary<string, string> _headers = new Dictionary<string, string>();
        private string _pathWithQueryString;
        private string _restApiId;
        private Dictionary<string, string> _stageVariables = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AdditionalContext. 
        /// <para>
        /// [Optional] A key-value map of additional context variables.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalContext
        {
            get { return this._additionalContext; }
            set { this._additionalContext = value; }
        }

        // Check to see if AdditionalContext property is set
        internal bool IsSetAdditionalContext()
        {
            return this._additionalContext != null && this._additionalContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuthorizerId. 
        /// <para>
        /// [Required] Specifies a test invoke authorizer request's <a>Authorizer</a> ID.
        /// </para>
        /// </summary>
        public string AuthorizerId
        {
            get { return this._authorizerId; }
            set { this._authorizerId = value; }
        }

        // Check to see if AuthorizerId property is set
        internal bool IsSetAuthorizerId()
        {
            return this._authorizerId != null;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// [Optional] The simulated request body of an incoming invocation request.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// [Required] A key-value map of headers to simulate an incoming invocation request.
        /// This is where the incoming authorization token, or identity source, should be specified.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && this._headers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PathWithQueryString. 
        /// <para>
        /// [Optional] The URI path, including query string, of the simulated invocation request.
        /// Use this to specify path parameters and query string parameters.
        /// </para>
        /// </summary>
        public string PathWithQueryString
        {
            get { return this._pathWithQueryString; }
            set { this._pathWithQueryString = value; }
        }

        // Check to see if PathWithQueryString property is set
        internal bool IsSetPathWithQueryString()
        {
            return this._pathWithQueryString != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The string identifier of the associated <a>RestApi</a>.
        /// </para>
        /// </summary>
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

        /// <summary>
        /// Gets and sets the property StageVariables. 
        /// <para>
        /// A key-value map of stage variables to simulate an invocation on a deployed <a>Stage</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StageVariables
        {
            get { return this._stageVariables; }
            set { this._stageVariables = value; }
        }

        // Check to see if StageVariables property is set
        internal bool IsSetStageVariables()
        {
            return this._stageVariables != null && this._stageVariables.Count > 0; 
        }

    }
}