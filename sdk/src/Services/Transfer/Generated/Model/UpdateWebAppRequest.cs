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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWebApp operation.
    /// Assigns new properties to a web app. You can modify the access point, identity provider
    /// details, and the web app units.
    /// </summary>
    public partial class UpdateWebAppRequest : AmazonTransferRequest
    {
        private string _accessEndpoint;
        private UpdateWebAppIdentityProviderDetails _identityProviderDetails;
        private string _webAppId;
        private WebAppUnits _webAppUnits;

        /// <summary>
        /// Gets and sets the property AccessEndpoint. 
        /// <para>
        /// The <c>AccessEndpoint</c> is the URL that you provide to your users for them to interact
        /// with the Transfer Family web app. You can specify a custom URL or use the default
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string AccessEndpoint
        {
            get { return this._accessEndpoint; }
            set { this._accessEndpoint = value; }
        }

        // Check to see if AccessEndpoint property is set
        internal bool IsSetAccessEndpoint()
        {
            return this._accessEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderDetails. 
        /// <para>
        /// Provide updated identity provider values in a <c>WebAppIdentityProviderDetails</c>
        /// object.
        /// </para>
        /// </summary>
        public UpdateWebAppIdentityProviderDetails IdentityProviderDetails
        {
            get { return this._identityProviderDetails; }
            set { this._identityProviderDetails = value; }
        }

        // Check to see if IdentityProviderDetails property is set
        internal bool IsSetIdentityProviderDetails()
        {
            return this._identityProviderDetails != null;
        }

        /// <summary>
        /// Gets and sets the property WebAppId. 
        /// <para>
        /// Provide the identifier of the web app that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=24)]
        public string WebAppId
        {
            get { return this._webAppId; }
            set { this._webAppId = value; }
        }

        // Check to see if WebAppId property is set
        internal bool IsSetWebAppId()
        {
            return this._webAppId != null;
        }

        /// <summary>
        /// Gets and sets the property WebAppUnits. 
        /// <para>
        /// A union that contains the value for number of concurrent connections or the user sessions
        /// on your web app.
        /// </para>
        /// </summary>
        public WebAppUnits WebAppUnits
        {
            get { return this._webAppUnits; }
            set { this._webAppUnits = value; }
        }

        // Check to see if WebAppUnits property is set
        internal bool IsSetWebAppUnits()
        {
            return this._webAppUnits != null;
        }

    }
}