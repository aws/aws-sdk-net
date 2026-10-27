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
    /// A structure that describes the parameters for the web app, as identified by the <c>WebAppId</c>.
    /// </summary>
    public partial class DescribedWebApp
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web app.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DescribedEndpointDetails. 
        /// <para>
        /// The endpoint configuration details for the web app, including VPC settings if the
        /// endpoint is hosted within a VPC.
        /// </para>
        /// </summary>
        public DescribedWebAppEndpointDetails DescribedEndpointDetails { get; set; }

        /// <summary>
        /// Checks to see if the DescribedEndpointDetails property is set.
        /// </summary>
        internal bool IsSetDescribedEndpointDetails() => this.DescribedEndpointDetails != null;

        /// <summary>
        /// Gets and sets the property DescribedIdentityProviderDetails. 
        /// <para>
        /// A structure that contains the details for the identity provider used by the web app.
        /// </para>
        /// </summary>
        public DescribedWebAppIdentityProviderDetails DescribedIdentityProviderDetails { get; set; }

        /// <summary>
        /// Checks to see if the DescribedIdentityProviderDetails property is set.
        /// </summary>
        internal bool IsSetDescribedIdentityProviderDetails() => this.DescribedIdentityProviderDetails != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint hosting the web app. Valid values are <c>PUBLIC</c> for publicly
        /// accessible endpoints and <c>VPC</c> for VPC-hosted endpoints that provide network
        /// isolation.
        /// </para>
        /// </summary>
        public WebAppEndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for web apps. Tags are metadata
        /// attached to web apps for any purpose.
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
        /// Gets and sets the property WebAppEndpoint. 
        /// <para>
        /// The <c>WebAppEndpoint</c> is the unique URL for your Transfer Family web app. This
        /// is the value that you use when you configure <b>Origins</b> on CloudFront.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string WebAppEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the WebAppEndpoint property is set.
        /// </summary>
        internal bool IsSetWebAppEndpoint() => this.WebAppEndpoint != null;

        /// <summary>
        /// Gets and sets the property WebAppEndpointPolicy. 
        /// <para>
        ///  Setting for the type of endpoint policy for the web app. The default value is <c>STANDARD</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If your web app was created in an Amazon Web Services GovCloud (US) Region, the value
        /// of this parameter can be <c>FIPS</c>, which indicates the web app endpoint is FIPS-compliant.
        /// </para>
        /// </summary>
        public WebAppEndpointPolicy WebAppEndpointPolicy { get; set; }

        /// <summary>
        /// Checks to see if the WebAppEndpointPolicy property is set.
        /// </summary>
        internal bool IsSetWebAppEndpointPolicy() => this.WebAppEndpointPolicy != null;

        /// <summary>
        /// Gets and sets the property WebAppId. 
        /// <para>
        /// The unique identifier for the web app.
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
