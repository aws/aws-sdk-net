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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
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
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAppAuthorization operation.
    /// Updates an app authorization within an app bundle, which allows AppFabric to connect
    /// to an application.
    /// 
    ///  
    /// <para>
    /// If the app authorization was in a <c>connected</c> state, updating the app authorization
    /// will set it back to a <c>PendingConnect</c> state.
    /// </para>
    /// </summary>
    public partial class UpdateAppAuthorizationRequest : AmazonAppFabricRequest
    {
        private string _appAuthorizationIdentifier;
        private string _appBundleIdentifier;
        private Credential _credential;
        private Tenant _tenant;

        /// <summary>
        /// Gets and sets the property AppAuthorizationIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or Universal Unique Identifier (UUID) of the app authorization
        /// to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string AppAuthorizationIdentifier
        {
            get { return this._appAuthorizationIdentifier; }
            set { this._appAuthorizationIdentifier = value; }
        }

        // Check to see if AppAuthorizationIdentifier property is set
        internal bool IsSetAppAuthorizationIdentifier()
        {
            return this._appAuthorizationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property AppBundleIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or Universal Unique Identifier (UUID) of the app bundle
        /// to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string AppBundleIdentifier
        {
            get { return this._appBundleIdentifier; }
            set { this._appBundleIdentifier = value; }
        }

        // Check to see if AppBundleIdentifier property is set
        internal bool IsSetAppBundleIdentifier()
        {
            return this._appBundleIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Credential. 
        /// <para>
        /// Contains credentials for the application, such as an API key or OAuth2 client ID and
        /// secret.
        /// </para>
        ///  
        /// <para>
        /// Specify credentials that match the authorization type of the app authorization to
        /// update. For example, if the authorization type of the app authorization is OAuth2
        /// (<c>oauth2</c>), then you should provide only the OAuth2 credentials.
        /// </para>
        /// </summary>
        public Credential Credential
        {
            get { return this._credential; }
            set { this._credential = value; }
        }

        // Check to see if Credential property is set
        internal bool IsSetCredential()
        {
            return this._credential != null;
        }

        /// <summary>
        /// Gets and sets the property Tenant. 
        /// <para>
        /// Contains information about an application tenant, such as the application display
        /// name and identifier.
        /// </para>
        /// </summary>
        public Tenant Tenant
        {
            get { return this._tenant; }
            set { this._tenant = value; }
        }

        // Check to see if Tenant property is set
        internal bool IsSetTenant()
        {
            return this._tenant != null;
        }

    }
}