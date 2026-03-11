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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePortal operation.
    /// Creates a portal.
    /// </summary>
    public partial class CreatePortalRequest : AmazonApiGatewayV2Request
    {
        private Authorization _authorization;
        private EndpointConfigurationRequest _endpointConfiguration;
        private List<string> _includedPortalProductArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _logoUri;
        private PortalContent _portalContent;
        private string _rumAppMonitorName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Authorization. 
        /// <para>
        /// The authentication configuration for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Authorization Authorization
        {
            get { return this._authorization; }
            set { this._authorization = value; }
        }

        // Check to see if Authorization property is set
        internal bool IsSetAuthorization()
        {
            return this._authorization != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The domain configuration for the portal. Use a default domain provided by API Gateway
        /// or provide a fully-qualified domain name that you own.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointConfigurationRequest EndpointConfiguration
        {
            get { return this._endpointConfiguration; }
            set { this._endpointConfiguration = value; }
        }

        // Check to see if EndpointConfiguration property is set
        internal bool IsSetEndpointConfiguration()
        {
            return this._endpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedPortalProductArns. 
        /// <para>
        /// The ARNs of the portal products included in the portal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IncludedPortalProductArns
        {
            get { return this._includedPortalProductArns; }
            set { this._includedPortalProductArns = value; }
        }

        // Check to see if IncludedPortalProductArns property is set
        internal bool IsSetIncludedPortalProductArns()
        {
            return this._includedPortalProductArns != null && (this._includedPortalProductArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogoUri. 
        /// <para>
        /// The URI for the portal logo image that is displayed in the portal header.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1092)]
        public string LogoUri
        {
            get { return this._logoUri; }
            set { this._logoUri = value; }
        }

        // Check to see if LogoUri property is set
        internal bool IsSetLogoUri()
        {
            return this._logoUri != null;
        }

        /// <summary>
        /// Gets and sets the property PortalContent. 
        /// <para>
        /// The content of the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PortalContent PortalContent
        {
            get { return this._portalContent; }
            set { this._portalContent = value; }
        }

        // Check to see if PortalContent property is set
        internal bool IsSetPortalContent()
        {
            return this._portalContent != null;
        }

        /// <summary>
        /// Gets and sets the property RumAppMonitorName. 
        /// <para>
        /// The name of the Amazon CloudWatch RUM app monitor for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string RumAppMonitorName
        {
            get { return this._rumAppMonitorName; }
            set { this._rumAppMonitorName = value; }
        }

        // Check to see if RumAppMonitorName property is set
        internal bool IsSetRumAppMonitorName()
        {
            return this._rumAppMonitorName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags. Each tag element is associated with a given resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}