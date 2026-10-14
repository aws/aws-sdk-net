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
    /// Container for the parameters to the CreateWebApp operation. Creates a web app based
    /// on specified parameters, and returns the ID for the new web app. You can configure
    /// the web app to be publicly accessible or hosted within a VPC. <para> For more information
    /// about using VPC endpoints with Transfer Family, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/create-webapp-in-vpc.html">Create
    /// a Transfer Family web app in a VPC</a>. </para>
    /// </summary>
    public partial class CreateWebAppRequest : AmazonTransferRequest
    {
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
        [AWSProperty(Min = 1, Max = 1024)]
        public string AccessEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AccessEndpoint property is set.
        /// </summary>
        internal bool IsSetAccessEndpoint() => this.AccessEndpoint != null;

        /// <summary>
        /// Gets and sets the property EndpointDetails. 
        /// <para>
        /// The endpoint configuration for the web app. You can specify whether the web app endpoint
        /// is publicly accessible or hosted within a VPC.
        /// </para>
        /// </summary>
        public WebAppEndpointDetails EndpointDetails { get; set; }

        /// <summary>
        /// Checks to see if the EndpointDetails property is set.
        /// </summary>
        internal bool IsSetEndpointDetails() => this.EndpointDetails != null;

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
        [AWSProperty(Required = true)]
        public WebAppIdentityProviderDetails IdentityProviderDetails { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderDetails property is set.
        /// </summary>
        internal bool IsSetIdentityProviderDetails() => this.IdentityProviderDetails != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for web apps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public WebAppEndpointPolicy WebAppEndpointPolicy { get; set; }

        /// <summary>
        /// Checks to see if the WebAppEndpointPolicy property is set.
        /// </summary>
        internal bool IsSetWebAppEndpointPolicy() => this.WebAppEndpointPolicy != null;

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
