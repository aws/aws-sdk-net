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

namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// The result of quick response search.
    /// </summary>
    public partial class QuickResponseSearchResultData
    {
        /// <summary>
        /// Gets and sets the property AttributesInterpolated. 
        /// <para>
        /// The user defined contact attributes that are resolved when the search result is returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<string> AttributesInterpolated { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributesInterpolated property is set.
        /// </summary>
        internal bool IsSetAttributesInterpolated() => this.AttributesInterpolated != null && (this.AttributesInterpolated.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributesNotInterpolated. 
        /// <para>
        /// The user defined contact attributes that are not resolved when the search result is
        /// returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<string> AttributesNotInterpolated { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributesNotInterpolated property is set.
        /// </summary>
        internal bool IsSetAttributesNotInterpolated() => this.AttributesNotInterpolated != null && (this.AttributesNotInterpolated.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The Amazon Connect contact channels this quick response applies to. The supported
        /// contact channel types include <c>Chat</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Channels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Channels property is set.
        /// </summary>
        internal bool IsSetChannels() => this.Channels != null && (this.Channels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The media type of the quick response content.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>application/x.quickresponse;format=plain</c> for quick response written in
        /// plain text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>application/x.quickresponse;format=markdown</c> for quick response written
        /// in richtext.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property Contents. 
        /// <para>
        /// The contents of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QuickResponseContents Contents { get; set; }

        /// <summary>
        /// Checks to see if the Contents property is set.
        /// </summary>
        internal bool IsSetContents() => this.Contents != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the quick response was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GroupingConfiguration. 
        /// <para>
        /// The configuration information of the user groups that the quick response is accessible
        /// to.
        /// </para>
        /// </summary>
        public GroupingConfiguration GroupingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GroupingConfiguration property is set.
        /// </summary>
        internal bool IsSetGroupingConfiguration() => this.GroupingConfiguration != null;

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// Whether the quick response is active.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Checks to see if the IsActive property is set.
        /// </summary>
        internal bool IsSetIsActive() => this.IsActive.HasValue;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseArn { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseArn property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseArn() => this.KnowledgeBaseArn != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. This should not be a QUICK_RESPONSES type knowledge
        /// base if you're storing Wisdom Content resource to it. Can be either the ID or the
        /// ARN. URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language code value for the language in which the quick response is written.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the quick response search
        /// result data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the quick response search result data was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 40)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property QuickResponseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QuickResponseArn { get; set; }

        /// <summary>
        /// Checks to see if the QuickResponseArn property is set.
        /// </summary>
        internal bool IsSetQuickResponseArn() => this.QuickResponseArn != null;

        /// <summary>
        /// Gets and sets the property QuickResponseId. 
        /// <para>
        /// The identifier of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QuickResponseId { get; set; }

        /// <summary>
        /// Checks to see if the QuickResponseId property is set.
        /// </summary>
        internal bool IsSetQuickResponseId() => this.QuickResponseId != null;

        /// <summary>
        /// Gets and sets the property ShortcutKey. 
        /// <para>
        /// The shortcut key of the quick response. The value should be unique across the knowledge
        /// base.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string ShortcutKey { get; set; }

        /// <summary>
        /// Checks to see if the ShortcutKey property is set.
        /// </summary>
        internal bool IsSetShortcutKey() => this.ShortcutKey != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The resource status of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QuickResponseStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
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
