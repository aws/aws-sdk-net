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
    /// Contains information about a hub content resource, including its name, version, type,
    /// associated documents, dependencies, and status, as returned by a search result.
    /// </summary>
    public partial class HubContent
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that hub content was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DocumentSchemaVersion. 
        /// <para>
        /// The document schema version for the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 14)]
        public string DocumentSchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentSchemaVersion property is set.
        /// </summary>
        internal bool IsSetDocumentSchemaVersion() => this.DocumentSchemaVersion != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason if importing hub content failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HubArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hub that contains the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string HubArn { get; set; }

        /// <summary>
        /// Checks to see if the HubArn property is set.
        /// </summary>
        internal bool IsSetHubArn() => this.HubArn != null;

        /// <summary>
        /// Gets and sets the property HubContentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string HubContentArn { get; set; }

        /// <summary>
        /// Checks to see if the HubContentArn property is set.
        /// </summary>
        internal bool IsSetHubContentArn() => this.HubContentArn != null;

        /// <summary>
        /// Gets and sets the property HubContentDependencies. 
        /// <para>
        /// The location of any dependencies that the hub content has, such as scripts, model
        /// artifacts, datasets, or notebooks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<HubContentDependency> HubContentDependencies { get; set; } = AWSConfigs.InitializeCollections ? new List<HubContentDependency>() : null;

        /// <summary>
        /// Checks to see if the HubContentDependencies property is set.
        /// </summary>
        internal bool IsSetHubContentDependencies() => this.HubContentDependencies != null && (this.HubContentDependencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HubContentDescription. 
        /// <para>
        /// A description of the hub content.
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
        /// Gets and sets the property HubContentDocument. 
        /// <para>
        /// The hub content document that describes information about the hub content such as
        /// type, associated containers, scripts, and more.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 327680)]
        public string HubContentDocument { get; set; }

        /// <summary>
        /// Checks to see if the HubContentDocument property is set.
        /// </summary>
        internal bool IsSetHubContentDocument() => this.HubContentDocument != null;

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
        /// The name of the hub content.
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
        /// The searchable keywords for the hub content.
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
        /// Gets and sets the property HubContentStatus. 
        /// <para>
        /// The status of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HubContentStatus HubContentStatus { get; set; }

        /// <summary>
        /// Checks to see if the HubContentStatus property is set.
        /// </summary>
        internal bool IsSetHubContentStatus() => this.HubContentStatus != null;

        /// <summary>
        /// Gets and sets the property HubContentType. 
        /// <para>
        /// The type of hub content.
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
        /// The version of the hub content.
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
        /// The name of the hub that contains the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string HubName { get; set; }

        /// <summary>
        /// Checks to see if the HubName property is set.
        /// </summary>
        internal bool IsSetHubName() => this.HubName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time of the hub content.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReferenceMinVersion. 
        /// <para>
        /// The minimum version of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 14)]
        public string ReferenceMinVersion { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceMinVersion property is set.
        /// </summary>
        internal bool IsSetReferenceMinVersion() => this.ReferenceMinVersion != null;

        /// <summary>
        /// Gets and sets the property SageMakerPublicHubContentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the public hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string SageMakerPublicHubContentArn { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerPublicHubContentArn property is set.
        /// </summary>
        internal bool IsSetSageMakerPublicHubContentArn() => this.SageMakerPublicHubContentArn != null;

        /// <summary>
        /// Gets and sets the property SupportStatus. 
        /// <para>
        /// The support status of the hub content.
        /// </para>
        /// </summary>
        public HubContentSupportStatus SupportStatus { get; set; }

        /// <summary>
        /// Checks to see if the SupportStatus property is set.
        /// </summary>
        internal bool IsSetSupportStatus() => this.SupportStatus != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags associated with the hub content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
