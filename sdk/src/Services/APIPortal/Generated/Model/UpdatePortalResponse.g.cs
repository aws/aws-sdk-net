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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// This is the response object from the UpdatePortal operation.
    /// </summary>
    public partial class UpdatePortalResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Authorization. How readers sign in to the portal, and whether
        /// fine-grained access control is on.
        /// </summary>
        [AWSProperty(Required = true)]
        public Authorization Authorization { get; set; }

        /// <summary>
        /// Checks to see if the Authorization property is set.
        /// </summary>
        internal bool IsSetAuthorization() => this.Authorization != null;

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. The domain configuration of the
        /// portal.
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointConfigurationResponse EndpointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfiguration property is set.
        /// </summary>
        internal bool IsSetEndpointConfiguration() => this.EndpointConfiguration != null;

        /// <summary>
        /// Gets and sets the property IncludedProductArns. The ARNs of the products the portal
        /// includes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public List<string> IncludedProductArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludedProductArns property is set.
        /// </summary>
        internal bool IsSetIncludedProductArns() => this.IncludedProductArns != null && (this.IncludedProductArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PortalArn. The ARN of the portal.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string PortalArn { get; set; }

        /// <summary>
        /// Checks to see if the PortalArn property is set.
        /// </summary>
        internal bool IsSetPortalArn() => this.PortalArn != null;

        /// <summary>
        /// Gets and sets the property PortalContent. The portal's display name, description,
        /// and theme.
        /// </summary>
        [AWSProperty(Required = true)]
        public PortalContent PortalContent { get; set; }

        /// <summary>
        /// Checks to see if the PortalContent property is set.
        /// </summary>
        internal bool IsSetPortalContent() => this.PortalContent != null;

        /// <summary>
        /// Gets and sets the property PortalId. The identifier of the portal.
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string PortalId { get; set; }

        /// <summary>
        /// Checks to see if the PortalId property is set.
        /// </summary>
        internal bool IsSetPortalId() => this.PortalId != null;

        /// <summary>
        /// Gets and sets the property Preview. The most recent preview of the portal. Absent
        /// if no preview has been created.
        /// </summary>
        public Preview Preview { get; set; }

        /// <summary>
        /// Checks to see if the Preview property is set.
        /// </summary>
        internal bool IsSetPreview() => this.Preview != null;

        /// <summary>
        /// Gets and sets the property PublishDescription. The description supplied with the most
        /// recent publish request.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PublishDescription { get; set; }

        /// <summary>
        /// Checks to see if the PublishDescription property is set.
        /// </summary>
        internal bool IsSetPublishDescription() => this.PublishDescription != null;

        /// <summary>
        /// Gets and sets the property PublishStatus. The publish status of the portal. Absent
        /// if the portal has never been published.
        /// </summary>
        public PublishStatus PublishStatus { get; set; }

        /// <summary>
        /// Checks to see if the PublishStatus property is set.
        /// </summary>
        internal bool IsSetPublishStatus() => this.PublishStatus != null;

        /// <summary>
        /// Gets and sets the property PublishedAt. When the portal was last published.
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// Checks to see if the PublishedAt property is set.
        /// </summary>
        internal bool IsSetPublishedAt() => this.PublishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RumAppMonitorName. The name of the CloudWatch RUM app monitor
        /// that collects reader telemetry for the portal.
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string RumAppMonitorName { get; set; }

        /// <summary>
        /// Checks to see if the RumAppMonitorName property is set.
        /// </summary>
        internal bool IsSetRumAppMonitorName() => this.RumAppMonitorName != null;

        /// <summary>
        /// Gets and sets the property StatusException.
        /// </summary>
        public PortalStatusException StatusException { get; set; }

        /// <summary>
        /// Checks to see if the StatusException property is set.
        /// </summary>
        internal bool IsSetStatusException() => this.StatusException != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. When the resource was last updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
