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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a listener attribute.
    /// </summary>
    public partial class ListenerAttribute
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the attribute.
        /// </para>
        ///  
        /// <para>
        /// The following attribute is supported by Network Load Balancers, and Gateway Load Balancers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tcp.idle_timeout.seconds</c> - The tcp idle timeout value, in seconds. The valid
        /// range is 60-6000 seconds. The default is 350 seconds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are only supported by Application Load Balancers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>routing.http.request.x_amzn_mtls_clientcert_serial_number.header_name</c> - Enables
        /// you to modify the header name of the <b>X-Amzn-Mtls-Clientcert-Serial-Number</b> HTTP
        /// request header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.request.x_amzn_mtls_clientcert_issuer.header_name</c> - Enables you
        /// to modify the header name of the <b>X-Amzn-Mtls-Clientcert-Issuer</b> HTTP request
        /// header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.request.x_amzn_mtls_clientcert_subject.header_name</c> - Enables
        /// you to modify the header name of the <b>X-Amzn-Mtls-Clientcert-Subject</b> HTTP request
        /// header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.request.x_amzn_mtls_clientcert_validity.header_name</c> - Enables
        /// you to modify the header name of the <b>X-Amzn-Mtls-Clientcert-Validity</b> HTTP request
        /// header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.request.x_amzn_mtls_clientcert_leaf.header_name</c> - Enables you
        /// to modify the header name of the <b>X-Amzn-Mtls-Clientcert-Leaf</b> HTTP request header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.request.x_amzn_mtls_clientcert.header_name</c> - Enables you to modify
        /// the header name of the <b>X-Amzn-Mtls-Clientcert</b> HTTP request header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.request.x_amzn_tls_version.header_name</c> - Enables you to modify
        /// the header name of the <b>X-Amzn-Tls-Version</b> HTTP request header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.request.x_amzn_tls_cipher_suite.header_name</c> - Enables you to
        /// modify the header name of the <b>X-Amzn-Tls-Cipher-Suite</b> HTTP request header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.server.enabled</c> - Enables you to allow or remove the
        /// HTTP response server header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.strict_transport_security.header_value</c> - Informs browsers
        /// that the site should only be accessed using HTTPS, and that any future attempts to
        /// access it using HTTP should automatically be converted to HTTPS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.access_control_allow_origin.header_value</c> - Specifies
        /// which origins are allowed to access the server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.access_control_allow_methods.header_value</c> - Returns
        /// which HTTP methods are allowed when accessing the server from a different origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.access_control_allow_headers.header_value</c> - Specifies
        /// which headers can be used during the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.access_control_allow_credentials.header_value</c> - Indicates
        /// whether the browser should include credentials such as cookies or authentication when
        /// making requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.access_control_expose_headers.header_value</c> - Returns
        /// which headers the browser can expose to the requesting client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.access_control_max_age.header_value</c> - Specifies how
        /// long the results of a preflight request can be cached, in seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.content_security_policy.header_value</c> - Specifies restrictions
        /// enforced by the browser to help minimize the risk of certain types of security threats.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.x_content_type_options.header_value</c> - Indicates whether
        /// the MIME types advertised in the <b>Content-Type</b> headers should be followed and
        /// not be changed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>routing.http.response.x_frame_options.header_value</c> - Indicates whether the
        /// browser is allowed to render a page in a <b>frame</b>, <b>iframe</b>, <b>embed</b>
        /// or <b>object</b>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the attribute.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}