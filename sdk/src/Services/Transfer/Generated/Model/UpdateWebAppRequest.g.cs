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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWebApp operation. Assigns new properties
    /// to a web app. You can modify the access point, identity provider details, endpoint
    /// configuration, and the web app units. <para> For more information about using VPC
    /// endpoints with Transfer Family, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/create-webapp-in-vpc.html">Create
    /// a Transfer Family web app in a VPC</a>. </para>
    /// </summary>
    public partial class UpdateWebAppRequest : AmazonTransferRequest
    {
        /// <summary>
        /// Gets and sets the property AccessEndpoint. 
        /// <para>
        /// The <c>AccessEndpoint</c> is the URL that you provide to your users for them to interact
        /// with the Transfer Family web app. You can specify a custom URL or use the default
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AccessEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AccessEndpoint property is set.
        /// </summary>
        internal bool IsSetAccessEndpoint() => this.AccessEndpoint != null;

        /// <summary>
        /// Gets and sets the property EndpointDetails. 
        /// <para>
        /// The updated endpoint configuration for the web app. You can modify the endpoint type
        /// and VPC configuration settings.
        /// </para>
        /// </summary>
        public UpdateWebAppEndpointDetails EndpointDetails { get; set; }

        /// <summary>
        /// Checks to see if the EndpointDetails property is set.
        /// </summary>
        internal bool IsSetEndpointDetails() => this.EndpointDetails != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderDetails. 
        /// <para>
        /// Provide updated identity provider values in a <c>WebAppIdentityProviderDetails</c>
        /// object.
        /// </para>
        /// </summary>
        public UpdateWebAppIdentityProviderDetails IdentityProviderDetails { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderDetails property is set.
        /// </summary>
        internal bool IsSetIdentityProviderDetails() => this.IdentityProviderDetails != null;

        /// <summary>
        /// Gets and sets the property WebAppId. 
        /// <para>
        /// Provide the identifier of the web app that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 24, Max = 24)]
        public string WebAppId { get; set; }

        /// <summary>
        /// Checks to see if the WebAppId property is set.
        /// </summary>
        internal bool IsSetWebAppId() => this.WebAppId != null;

        /// <summary>
        /// Gets and sets the property WebAppUnits. 
        /// <para>
        /// A union that contains the value for number of concurrent connections or the user sessions
        /// on your web app.
        /// </para>
        /// </summary>
        public WebAppUnits WebAppUnits { get; set; }

        /// <summary>
        /// Checks to see if the WebAppUnits property is set.
        /// </summary>
        internal bool IsSetWebAppUnits() => this.WebAppUnits != null;
    }
}
