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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// Send data to an HTTPS endpoint.
    /// </summary>
    public partial class HttpAction
    {
        private HttpAuthorization _auth;
        private string _confirmationUrl;
        private List<HttpActionHeader> _headers = AWSConfigs.InitializeCollections ? new List<HttpActionHeader>() : null;
        private string _url;

        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// The authentication method to use when sending data to an HTTPS endpoint.
        /// </para>
        /// </summary>
        public HttpAuthorization Auth
        {
            get { return this._auth; }
            set { this._auth = value; }
        }

        // Check to see if Auth property is set
        internal bool IsSetAuth()
        {
            return this._auth != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationUrl. 
        /// <para>
        /// The URL to which IoT sends a confirmation message. The value of the confirmation URL
        /// must be a prefix of the endpoint URL. If you do not specify a confirmation URL IoT
        /// uses the endpoint URL as the confirmation URL. If you use substitution templates in
        /// the confirmationUrl, you must create and enable topic rule destinations that match
        /// each possible value of the substitution template before traffic is allowed to your
        /// endpoint URL.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
        public string ConfirmationUrl
        {
            get { return this._confirmationUrl; }
            set { this._confirmationUrl = value; }
        }

        // Check to see if ConfirmationUrl property is set
        internal bool IsSetConfirmationUrl()
        {
            return this._confirmationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// The HTTP headers to send with the message data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<HttpActionHeader> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && (this._headers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The endpoint URL. If substitution templates are used in the URL, you must also specify
        /// a <c>confirmationUrl</c>. If this is a new destination, a new <c>TopicRuleDestination</c>
        /// is created if possible.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2000)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}