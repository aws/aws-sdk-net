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
    /// A structure that describes the parameters for the web app, as identified by the <c>WebAppId</c>.
    /// </summary>
    public partial class DescribedWebApp
    {
        private string _accessEndpoint;
        private string _arn;
        private DescribedWebAppIdentityProviderDetails _describedIdentityProviderDetails;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _webAppEndpoint;
        private WebAppEndpointPolicy _webAppEndpointPolicy;
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DescribedIdentityProviderDetails. 
        /// <para>
        /// A structure that contains the details for the identity provider used by the web app.
        /// </para>
        /// </summary>
        public DescribedWebAppIdentityProviderDetails DescribedIdentityProviderDetails
        {
            get { return this._describedIdentityProviderDetails; }
            set { this._describedIdentityProviderDetails = value; }
        }

        // Check to see if DescribedIdentityProviderDetails property is set
        internal bool IsSetDescribedIdentityProviderDetails()
        {
            return this._describedIdentityProviderDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for web apps. Tags are metadata
        /// attached to web apps for any purpose.
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
        /// Gets and sets the property WebAppEndpoint. 
        /// <para>
        /// The <c>WebAppEndpoint</c> is the unique URL for your Transfer Family web app. This
        /// is the value that you use when you configure <b>Origins</b> on CloudFront.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string WebAppEndpoint
        {
            get { return this._webAppEndpoint; }
            set { this._webAppEndpoint = value; }
        }

        // Check to see if WebAppEndpoint property is set
        internal bool IsSetWebAppEndpoint()
        {
            return this._webAppEndpoint != null;
        }

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
        /// Gets and sets the property WebAppId. 
        /// <para>
        /// The unique identifier for the web app.
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