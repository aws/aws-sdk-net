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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile credentials required when using SAPOData.
    /// </summary>
    public partial class SAPODataConnectorProfileCredentials
    {
        private BasicAuthCredentials _basicAuthCredentials;
        private OAuthCredentials _oAuthCredentials;

        /// <summary>
        /// Gets and sets the property BasicAuthCredentials. 
        /// <para>
        ///  The SAPOData basic authentication credentials. 
        /// </para>
        /// </summary>
        public BasicAuthCredentials BasicAuthCredentials
        {
            get { return this._basicAuthCredentials; }
            set { this._basicAuthCredentials = value; }
        }

        // Check to see if BasicAuthCredentials property is set
        internal bool IsSetBasicAuthCredentials()
        {
            return this._basicAuthCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthCredentials. 
        /// <para>
        ///  The SAPOData OAuth type authentication credentials. 
        /// </para>
        /// </summary>
        public OAuthCredentials OAuthCredentials
        {
            get { return this._oAuthCredentials; }
            set { this._oAuthCredentials = value; }
        }

        // Check to see if OAuthCredentials property is set
        internal bool IsSetOAuthCredentials()
        {
            return this._oAuthCredentials != null;
        }

    }
}