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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePortal operation. Creates a portal.
    /// </summary>
    public partial class CreatePortalRequest : AmazonApiGatewayV2Request
    {
        /// <summary>
        /// Gets and sets the property Authorization. 
        /// <para>
        /// The authentication configuration for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Authorization Authorization { get; set; }

        /// <summary>
        /// Checks to see if the Authorization property is set.
        /// </summary>
        internal bool IsSetAuthorization() => this.Authorization != null;

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The domain configuration for the portal. Use a default domain provided by API Gateway
        /// or provide a fully-qualified domain name that you own.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointConfigurationRequest EndpointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfiguration property is set.
        /// </summary>
        internal bool IsSetEndpointConfiguration() => this.EndpointConfiguration != null;

        /// <summary>
        /// Gets and sets the property IncludedPortalProductArns. 
        /// <para>
        /// The ARNs of the portal products included in the portal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IncludedPortalProductArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludedPortalProductArns property is set.
        /// </summary>
        internal bool IsSetIncludedPortalProductArns() => this.IncludedPortalProductArns != null && (this.IncludedPortalProductArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogoUri. 
        /// <para>
        /// The URI for the portal logo image that is displayed in the portal header.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1092)]
        public string LogoUri { get; set; }

        /// <summary>
        /// Checks to see if the LogoUri property is set.
        /// </summary>
        internal bool IsSetLogoUri() => this.LogoUri != null;

        /// <summary>
        /// Gets and sets the property PortalContent. 
        /// <para>
        /// The content of the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PortalContent PortalContent { get; set; }

        /// <summary>
        /// Checks to see if the PortalContent property is set.
        /// </summary>
        internal bool IsSetPortalContent() => this.PortalContent != null;

        /// <summary>
        /// Gets and sets the property RumAppMonitorName. 
        /// <para>
        /// The name of the Amazon CloudWatch RUM app monitor for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string RumAppMonitorName { get; set; }

        /// <summary>
        /// Checks to see if the RumAppMonitorName property is set.
        /// </summary>
        internal bool IsSetRumAppMonitorName() => this.RumAppMonitorName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags. Each tag element is associated with a given resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
