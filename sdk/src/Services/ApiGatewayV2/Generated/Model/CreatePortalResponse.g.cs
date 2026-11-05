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
    /// This is the response object from the CreatePortal operation.
    /// </summary>
    public partial class CreatePortalResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Authorization. 
        /// <para>
        /// The authorization for the portal. Supports Cognito-based user authentication or no
        /// authentication.
        /// </para>
        /// </summary>
        public Authorization Authorization { get; set; }

        /// <summary>
        /// Checks to see if the Authorization property is set.
        /// </summary>
        internal bool IsSetAuthorization() => this.Authorization != null;

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The endpoint configuration.
        /// </para>
        /// </summary>
        public EndpointConfigurationResponse EndpointConfiguration { get; set; }

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
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The timestamp when the portal configuration was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property LastPublished. 
        /// <para>
        /// The timestamp when the portal was last published.
        /// </para>
        /// </summary>
        public DateTime? LastPublished { get; set; }

        /// <summary>
        /// Checks to see if the LastPublished property is set.
        /// </summary>
        internal bool IsSetLastPublished() => this.LastPublished.HasValue;

        /// <summary>
        /// Gets and sets the property LastPublishedDescription. 
        /// <para>
        /// A user-written description of the changes made in the last published version of the
        /// portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LastPublishedDescription { get; set; }

        /// <summary>
        /// Checks to see if the LastPublishedDescription property is set.
        /// </summary>
        internal bool IsSetLastPublishedDescription() => this.LastPublishedDescription != null;

        /// <summary>
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The ARN of the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PortalArn { get; set; }

        /// <summary>
        /// Checks to see if the PortalArn property is set.
        /// </summary>
        internal bool IsSetPortalArn() => this.PortalArn != null;

        /// <summary>
        /// Gets and sets the property PortalContent. 
        /// <para>
        /// The name, description, and theme for the portal.
        /// </para>
        /// </summary>
        public PortalContent PortalContent { get; set; }

        /// <summary>
        /// Checks to see if the PortalContent property is set.
        /// </summary>
        internal bool IsSetPortalContent() => this.PortalContent != null;

        /// <summary>
        /// Gets and sets the property PortalId. 
        /// <para>
        /// The portal identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 30)]
        public string PortalId { get; set; }

        /// <summary>
        /// Checks to see if the PortalId property is set.
        /// </summary>
        internal bool IsSetPortalId() => this.PortalId != null;

        /// <summary>
        /// Gets and sets the property PublishStatus. 
        /// <para>
        /// The current publishing status of the portal.
        /// </para>
        /// </summary>
        public PublishStatus PublishStatus { get; set; }

        /// <summary>
        /// Checks to see if the PublishStatus property is set.
        /// </summary>
        internal bool IsSetPublishStatus() => this.PublishStatus != null;

        /// <summary>
        /// Gets and sets the property RumAppMonitorName. 
        /// <para>
        /// The name of the Amazon CloudWatch RUM app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string RumAppMonitorName { get; set; }

        /// <summary>
        /// Checks to see if the RumAppMonitorName property is set.
        /// </summary>
        internal bool IsSetRumAppMonitorName() => this.RumAppMonitorName != null;

        /// <summary>
        /// Gets and sets the property StatusException. 
        /// <para>
        /// Error information for failed portal operations. Contains details about any issues
        /// encountered during portal creation or publishing.
        /// </para>
        /// </summary>
        public StatusException StatusException { get; set; }

        /// <summary>
        /// Checks to see if the StatusException property is set.
        /// </summary>
        internal bool IsSetStatusException() => this.StatusException != null;

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
