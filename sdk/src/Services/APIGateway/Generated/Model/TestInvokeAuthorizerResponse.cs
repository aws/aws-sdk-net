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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents the response of the test invoke request for a custom <a>Authorizer</a>
    /// </summary>
    public partial class TestInvokeAuthorizerResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, List<string>> _authorization = new Dictionary<string, List<string>>();
        private Dictionary<string, string> _claims = new Dictionary<string, string>();
        private int? _clientStatus;
        private long? _latency;
        private string _log;
        private string _policy;
        private string _principalId;

        /// <summary>
        /// Gets and sets the property Authorization.
        /// </summary>
        public Dictionary<string, List<string>> Authorization
        {
            get { return this._authorization; }
            set { this._authorization = value; }
        }

        // Check to see if Authorization property is set
        internal bool IsSetAuthorization()
        {
            return this._authorization != null && this._authorization.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Claims. 
        /// <para>
        /// The <a href="https://openid.net/specs/openid-connect-core-1_0.html#StandardClaims">open
        /// identity claims</a>, with any supported custom attributes, returned from the Cognito
        /// Your User Pool configured for the API.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Claims
        {
            get { return this._claims; }
            set { this._claims = value; }
        }

        // Check to see if Claims property is set
        internal bool IsSetClaims()
        {
            return this._claims != null && this._claims.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientStatus. 
        /// <para>
        /// The HTTP status code that the client would have received. Value is 0 if the authorizer
        /// succeeded.
        /// </para>
        /// </summary>
        public int ClientStatus
        {
            get { return this._clientStatus.GetValueOrDefault(); }
            set { this._clientStatus = value; }
        }

        // Check to see if ClientStatus property is set
        internal bool IsSetClientStatus()
        {
            return this._clientStatus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Latency. 
        /// <para>
        /// The execution latency of the test authorizer request.
        /// </para>
        /// </summary>
        public long Latency
        {
            get { return this._latency.GetValueOrDefault(); }
            set { this._latency = value; }
        }

        // Check to see if Latency property is set
        internal bool IsSetLatency()
        {
            return this._latency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Log. 
        /// <para>
        /// The API Gateway execution log for the test authorizer request.
        /// </para>
        /// </summary>
        public string Log
        {
            get { return this._log; }
            set { this._log = value; }
        }

        // Check to see if Log property is set
        internal bool IsSetLog()
        {
            return this._log != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The JSON policy document returned by the <a>Authorizer</a>
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The principal identity returned by the <a>Authorizer</a>
        /// </para>
        /// </summary>
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }

        // Check to see if PrincipalId property is set
        internal bool IsSetPrincipalId()
        {
            return this._principalId != null;
        }

    }
}