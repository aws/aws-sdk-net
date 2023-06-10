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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// This is the response object from the CreateWebLoginToken operation.
    /// </summary>
    public partial class CreateWebLoginTokenResponse : AmazonWebServiceResponse
    {
        private string _webServerHostname;
        private string _webToken;

        /// <summary>
        /// Gets and sets the property WebServerHostname. 
        /// <para>
        /// The Airflow web server hostname for the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WebServerHostname
        {
            get { return this._webServerHostname; }
            set { this._webServerHostname = value; }
        }

        // Check to see if WebServerHostname property is set
        internal bool IsSetWebServerHostname()
        {
            return this._webServerHostname != null;
        }

        /// <summary>
        /// Gets and sets the property WebToken. 
        /// <para>
        /// An Airflow web server login token.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string WebToken
        {
            get { return this._webToken; }
            set { this._webToken = value; }
        }

        // Check to see if WebToken property is set
        internal bool IsSetWebToken()
        {
            return this._webToken != null;
        }

    }
}