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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Contextual user data type used for evaluating the risk of an unexpected event by Amazon
    /// Cognito advanced security.
    /// </summary>
    public partial class ContextDataType
    {
        private string _encodedData;
        private List<HttpHeader> _httpHeaders = new List<HttpHeader>();
        private string _ipAddress;
        private string _serverName;
        private string _serverPath;

        /// <summary>
        /// Gets and sets the property EncodedData. 
        /// <para>
        /// Encoded data containing device fingerprinting details, collected using the Amazon
        /// Cognito context data collection library.
        /// </para>
        /// </summary>
        public string EncodedData
        {
            get { return this._encodedData; }
            set { this._encodedData = value; }
        }

        // Check to see if EncodedData property is set
        internal bool IsSetEncodedData()
        {
            return this._encodedData != null;
        }

        /// <summary>
        /// Gets and sets the property HttpHeaders. 
        /// <para>
        /// HttpHeaders received on your server in same order.
        /// </para>
        /// </summary>
        public List<HttpHeader> HttpHeaders
        {
            get { return this._httpHeaders; }
            set { this._httpHeaders = value; }
        }

        // Check to see if HttpHeaders property is set
        internal bool IsSetHttpHeaders()
        {
            return this._httpHeaders != null && this._httpHeaders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// Source IP address of your user.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// Your server endpoint where this API is invoked.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerPath. 
        /// <para>
        /// Your server path where this API is invoked. 
        /// </para>
        /// </summary>
        public string ServerPath
        {
            get { return this._serverPath; }
            set { this._serverPath = value; }
        }

        // Check to see if ServerPath property is set
        internal bool IsSetServerPath()
        {
            return this._serverPath != null;
        }

    }
}