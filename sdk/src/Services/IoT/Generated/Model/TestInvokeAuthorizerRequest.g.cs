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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the TestInvokeAuthorizer operation. Tests a custom
    /// authorization behavior by invoking a specified custom authorizer. Use this to test
    /// and debug the custom authorization behavior of devices that connect to the IoT device
    /// gateway. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TestInvokeAuthorizer</a>
    /// action. </para>
    /// </summary>
    public partial class TestInvokeAuthorizerRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AuthorizerName. 
        /// <para>
        /// The custom authorizer name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AuthorizerName { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerName property is set.
        /// </summary>
        internal bool IsSetAuthorizerName() => this.AuthorizerName != null;

        /// <summary>
        /// Gets and sets the property HttpContext. 
        /// <para>
        /// Specifies a test HTTP authorization request.
        /// </para>
        /// </summary>
        public HttpContext HttpContext { get; set; }

        /// <summary>
        /// Checks to see if the HttpContext property is set.
        /// </summary>
        internal bool IsSetHttpContext() => this.HttpContext != null;

        /// <summary>
        /// Gets and sets the property MqttContext. 
        /// <para>
        /// Specifies a test MQTT authorization request.
        /// </para>
        /// </summary>
        public MqttContext MqttContext { get; set; }

        /// <summary>
        /// Checks to see if the MqttContext property is set.
        /// </summary>
        internal bool IsSetMqttContext() => this.MqttContext != null;

        /// <summary>
        /// Gets and sets the property TlsContext. 
        /// <para>
        /// Specifies a test TLS authorization request.
        /// </para>
        /// </summary>
        public TlsContext TlsContext { get; set; }

        /// <summary>
        /// Checks to see if the TlsContext property is set.
        /// </summary>
        internal bool IsSetTlsContext() => this.TlsContext != null;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The token returned by your custom authentication service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6144)]
        public string Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;

        /// <summary>
        /// Gets and sets the property TokenSignature. 
        /// <para>
        /// The signature made with the token and your custom authentication service's private
        /// key. This value must be Base-64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2560)]
        public string TokenSignature { get; set; }

        /// <summary>
        /// Checks to see if the TokenSignature property is set.
        /// </summary>
        internal bool IsSetTokenSignature() => this.TokenSignature != null;
    }
}
