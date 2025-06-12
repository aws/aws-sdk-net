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
    /// Container for the parameters to the CreateWebApp operation.
    /// Creates a web app based on specified parameters, and returns the ID for the new web
    /// app.
    /// </summary>
    public partial class CreateWebAppRequest : AmazonTransferRequest
    {
        private string _accessEndpoint;
        private WebAppIdentityProviderDetails _identityProviderDetails;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private WebAppEndpointPolicy _webAppEndpointPolicy;
        private WebAppUnits _webAppUnits;

        /// <summary>
        /// Gets and sets the property AccessEndpoint. 
        /// <para>
        /// The <c>AccessEndpoint</c> is the URL that you provide to your users for them to interact
        /// with the Transfer Family web app. You can specify a custom URL or use the default
        /// value.
        /// </para>
        ///  
        /// <para>
        /// Before you enter a custom URL for this parameter, follow the steps described in <a
        /// href="https://docs.aws.amazon.com/transfer/latest/userguide/webapp-customize.html">Update
        /// your access endpoint with a custom URL</a>.
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
        /// You can provide a structure that contains the details for the identity provider to
        /// use with your web app.
        /// </para>
        ///  
        /// <para>
        /// For more details about this parameter, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/webapp-identity-center.html">Configure
        /// your identity provider for Transfer Family web apps</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WebAppIdentityProviderDetails IdentityProviderDetails
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for web apps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WebAppEndpointPolicy. 
        /// <para>
        ///  Setting for the type of endpoint policy for the web app. The default value is <c>STANDARD</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you are creating the web app in an Amazon Web Services GovCloud (US) Region, you
        /// can set this parameter to <c>FIPS</c>.
        /// </para>
        /// </summary>
        public WebAppEndpointPolicy WebAppEndpointPolicy
        {
            get { return this._webAppEndpointPolicy; }
            set { this._webAppEndpointPolicy = value; }
        }

        // Check to see if WebAppEndpointPolicy property is set
        internal bool IsSetWebAppEndpointPolicy()
        {
            return this._webAppEndpointPolicy != null;
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