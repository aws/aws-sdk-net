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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the TestInvokeAuthorizer operation.
    /// Tests a custom authorization behavior by invoking a specified custom authorizer. Use
    /// this to test and debug the custom authorization behavior of devices that connect to
    /// the AWS IoT device gateway.
    /// </summary>
    public partial class TestInvokeAuthorizerRequest : AmazonIoTRequest
    {
        private string _authorizerName;
        private string _token;
        private string _tokenSignature;

        /// <summary>
        /// Gets and sets the property AuthorizerName. 
        /// <para>
        /// The custom authorizer name.
        /// </para>
        /// </summary>
        public string AuthorizerName
        {
            get { return this._authorizerName; }
            set { this._authorizerName = value; }
        }

        // Check to see if AuthorizerName property is set
        internal bool IsSetAuthorizerName()
        {
            return this._authorizerName != null;
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The token returned by your custom authentication service.
        /// </para>
        /// </summary>
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property TokenSignature. 
        /// <para>
        /// The signature made with the token and your custom authentication service's private
        /// key.
        /// </para>
        /// </summary>
        public string TokenSignature
        {
            get { return this._tokenSignature; }
            set { this._tokenSignature = value; }
        }

        // Check to see if TokenSignature property is set
        internal bool IsSetTokenSignature()
        {
            return this._tokenSignature != null;
        }

    }
}