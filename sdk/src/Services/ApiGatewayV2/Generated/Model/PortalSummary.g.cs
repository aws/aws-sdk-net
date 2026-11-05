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
    /// Represents a portal summary.
    /// </summary>
    public partial class PortalSummary
    {
        /// <summary>
        /// Gets and sets the property Authorization. 
        /// <para>
        /// The authorization of the portal.
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
        /// The endpoint configuration of the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
        public List<string> IncludedPortalProductArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludedPortalProductArns property is set.
        /// </summary>
        internal bool IsSetIncludedPortalProductArns() => this.IncludedPortalProductArns != null && (this.IncludedPortalProductArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The timestamp when the portal was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// The description of the portal the last time it was published.
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
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string PortalArn { get; set; }

        /// <summary>
        /// Checks to see if the PortalArn property is set.
        /// </summary>
        internal bool IsSetPortalArn() => this.PortalArn != null;

        /// <summary>
        /// Gets and sets the property PortalContent. 
        /// <para>
        /// Contains the content that is visible to portal consumers including the themes, display
        /// names, and description.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string PortalId { get; set; }

        /// <summary>
        /// Checks to see if the PortalId property is set.
        /// </summary>
        internal bool IsSetPortalId() => this.PortalId != null;

        /// <summary>
        /// Gets and sets the property Preview. 
        /// <para>
        /// Represents the preview endpoint and the any possible error messages during preview
        /// generation.
        /// </para>
        /// </summary>
        public Preview Preview { get; set; }

        /// <summary>
        /// Checks to see if the Preview property is set.
        /// </summary>
        internal bool IsSetPreview() => this.Preview != null;

        /// <summary>
        /// Gets and sets the property PublishStatus. 
        /// <para>
        /// The publish status.
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
        /// The CloudWatch RUM app monitor name.
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
        /// The status exception information.
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
