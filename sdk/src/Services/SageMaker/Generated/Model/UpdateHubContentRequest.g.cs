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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHubContent operation. Updates SageMaker
    /// hub content (either a <c>Model</c> or <c>Notebook</c> resource). <para> You can update
    /// the metadata that describes the resource. In addition to the required request fields,
    /// specify at least one of the following fields to update: </para> <ul> <li> <para> <c>HubContentDescription</c>
    /// </para> </li> <li> <para> <c>HubContentDisplayName</c> </para> </li> <li> <para> <c>HubContentMarkdown</c>
    /// </para> </li> <li> <para> <c>HubContentSearchKeywords</c> </para> </li> <li> <para>
    /// <c>SupportStatus</c> </para> </li> </ul> <para> For more information about hubs, see
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-curated-hubs.html">Private
    /// curated hubs for foundation model access control in JumpStart</a>. </para> <note>
    /// <para> If you want to update a <c>ModelReference</c> resource in your hub, use the
    /// <c>UpdateHubContentResource</c> API instead. </para> </note>
    /// </summary>
    public partial class UpdateHubContentRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property HubContentDescription. 
        /// <para>
        /// The description of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1023)]
        public string HubContentDescription { get; set; }

        /// <summary>
        /// Checks to see if the HubContentDescription property is set.
        /// </summary>
        internal bool IsSetHubContentDescription() => this.HubContentDescription != null;

        /// <summary>
        /// Gets and sets the property HubContentDisplayName. 
        /// <para>
        /// The display name of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string HubContentDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the HubContentDisplayName property is set.
        /// </summary>
        internal bool IsSetHubContentDisplayName() => this.HubContentDisplayName != null;

        /// <summary>
        /// Gets and sets the property HubContentMarkdown. 
        /// <para>
        /// A string that provides a description of the hub content. This string can include links,
        /// tables, and standard markdown formatting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 170391)]
        public string HubContentMarkdown { get; set; }

        /// <summary>
        /// Checks to see if the HubContentMarkdown property is set.
        /// </summary>
        internal bool IsSetHubContentMarkdown() => this.HubContentMarkdown != null;

        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        /// The name of the hub content resource that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string HubContentName { get; set; }

        /// <summary>
        /// Checks to see if the HubContentName property is set.
        /// </summary>
        internal bool IsSetHubContentName() => this.HubContentName != null;

        /// <summary>
        /// Gets and sets the property HubContentSearchKeywords. 
        /// <para>
        /// The searchable keywords of the hub content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> HubContentSearchKeywords { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HubContentSearchKeywords property is set.
        /// </summary>
        internal bool IsSetHubContentSearchKeywords() => this.HubContentSearchKeywords != null && (this.HubContentSearchKeywords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HubContentType. 
        /// <para>
        /// The content type of the resource that you want to update. Only specify a <c>Model</c>
        /// or <c>Notebook</c> resource for this API. To update a <c>ModelReference</c>, use the
        /// <c>UpdateHubContentReference</c> API instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HubContentType HubContentType { get; set; }

        /// <summary>
        /// Checks to see if the HubContentType property is set.
        /// </summary>
        internal bool IsSetHubContentType() => this.HubContentType != null;

        /// <summary>
        /// Gets and sets the property HubContentVersion. 
        /// <para>
        /// The hub content version that you want to update. For example, if you have two versions
        /// of a resource in your hub, you can update the second version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 14)]
        public string HubContentVersion { get; set; }

        /// <summary>
        /// Checks to see if the HubContentVersion property is set.
        /// </summary>
        internal bool IsSetHubContentVersion() => this.HubContentVersion != null;

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the SageMaker hub that contains the hub content you want to update. You
        /// can optionally use the hub ARN instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HubName { get; set; }

        /// <summary>
        /// Checks to see if the HubName property is set.
        /// </summary>
        internal bool IsSetHubName() => this.HubName != null;

        /// <summary>
        /// Gets and sets the property SupportStatus. 
        /// <para>
        /// Indicates the current status of the hub content resource.
        /// </para>
        /// </summary>
        public HubContentSupportStatus SupportStatus { get; set; }

        /// <summary>
        /// Checks to see if the SupportStatus property is set.
        /// </summary>
        internal bool IsSetSupportStatus() => this.SupportStatus != null;
    }
}
