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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateQuickResponse operation. Updates an existing
    /// Amazon Q in Connect quick response.
    /// </summary>
    public partial class UpdateQuickResponseRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The Connect Customer contact channels this quick response applies to. The supported
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
        /// Gets and sets the property Content. 
        /// <para>
        /// The updated content of the quick response.
        /// </para>
        /// </summary>
        public QuickResponseDataProvider Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

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
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the quick response.
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
        /// The updated grouping configuration of the quick response.
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
        public bool? IsActive { get; set; }

        /// <summary>
        /// Checks to see if the IsActive property is set.
        /// </summary>
        internal bool IsSetIsActive() => this.IsActive.HasValue;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
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
        /// The language code value for the language in which the quick response is written. The
        /// supported language codes include <c>de_DE</c>, <c>en_US</c>, <c>es_ES</c>, <c>fr_FR</c>,
        /// <c>id_ID</c>, <c>it_IT</c>, <c>ja_JP</c>, <c>ko_KR</c>, <c>pt_BR</c>, <c>zh_CN</c>,
        /// <c>zh_TW</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        /// Gets and sets the property RemoveDescription. 
        /// <para>
        /// Whether to remove the description from the quick response.
        /// </para>
        /// </summary>
        public bool? RemoveDescription { get; set; }

        /// <summary>
        /// Checks to see if the RemoveDescription property is set.
        /// </summary>
        internal bool IsSetRemoveDescription() => this.RemoveDescription.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveGroupingConfiguration. 
        /// <para>
        /// Whether to remove the grouping configuration of the quick response.
        /// </para>
        /// </summary>
        public bool? RemoveGroupingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RemoveGroupingConfiguration property is set.
        /// </summary>
        internal bool IsSetRemoveGroupingConfiguration() => this.RemoveGroupingConfiguration.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveShortcutKey. 
        /// <para>
        /// Whether to remove the shortcut key of the quick response.
        /// </para>
        /// </summary>
        public bool? RemoveShortcutKey { get; set; }

        /// <summary>
        /// Checks to see if the RemoveShortcutKey property is set.
        /// </summary>
        internal bool IsSetRemoveShortcutKey() => this.RemoveShortcutKey.HasValue;

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
    }
}
