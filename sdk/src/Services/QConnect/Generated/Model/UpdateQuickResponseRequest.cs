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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
    /// Container for the parameters to the UpdateQuickResponse operation.
    /// Updates an existing Amazon Q in Connect quick response.
    /// </summary>
    public partial class UpdateQuickResponseRequest : AmazonQConnectRequest
    {
        private List<string> _channels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private QuickResponseDataProvider _content;
        private string _contentType;
        private string _description;
        private GroupingConfiguration _groupingConfiguration;
        private bool? _isActive;
        private string _knowledgeBaseId;
        private string _language;
        private string _name;
        private string _quickResponseId;
        private bool? _removeDescription;
        private bool? _removeGroupingConfiguration;
        private bool? _removeShortcutKey;
        private string _shortcutKey;

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The Amazon Connect contact channels this quick response applies to. The supported
        /// contact channel types include <c>Chat</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels != null && (this._channels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The updated content of the quick response.
        /// </para>
        /// </summary>
        public QuickResponseDataProvider Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

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
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GroupingConfiguration. 
        /// <para>
        /// The updated grouping configuration of the quick response.
        /// </para>
        /// </summary>
        public GroupingConfiguration GroupingConfiguration
        {
            get { return this._groupingConfiguration; }
            set { this._groupingConfiguration = value; }
        }

        // Check to see if GroupingConfiguration property is set
        internal bool IsSetGroupingConfiguration()
        {
            return this._groupingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// Whether the quick response is active. 
        /// </para>
        /// </summary>
        public bool? IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }

        // Check to see if IsActive property is set
        internal bool IsSetIsActive()
        {
            return this._isActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language code value for the language in which the quick response is written. The
        /// supported language codes include <c>de_DE</c>, <c>en_US</c>, <c>es_ES</c>, <c>fr_FR</c>,
        /// <c>id_ID</c>, <c>it_IT</c>, <c>ja_JP</c>, <c>ko_KR</c>, <c>pt_BR</c>, <c>zh_CN</c>,
        /// <c>zh_TW</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property QuickResponseId. 
        /// <para>
        /// The identifier of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QuickResponseId
        {
            get { return this._quickResponseId; }
            set { this._quickResponseId = value; }
        }

        // Check to see if QuickResponseId property is set
        internal bool IsSetQuickResponseId()
        {
            return this._quickResponseId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveDescription. 
        /// <para>
        /// Whether to remove the description from the quick response.
        /// </para>
        /// </summary>
        public bool? RemoveDescription
        {
            get { return this._removeDescription; }
            set { this._removeDescription = value; }
        }

        // Check to see if RemoveDescription property is set
        internal bool IsSetRemoveDescription()
        {
            return this._removeDescription.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveGroupingConfiguration. 
        /// <para>
        /// Whether to remove the grouping configuration of the quick response.
        /// </para>
        /// </summary>
        public bool? RemoveGroupingConfiguration
        {
            get { return this._removeGroupingConfiguration; }
            set { this._removeGroupingConfiguration = value; }
        }

        // Check to see if RemoveGroupingConfiguration property is set
        internal bool IsSetRemoveGroupingConfiguration()
        {
            return this._removeGroupingConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveShortcutKey. 
        /// <para>
        /// Whether to remove the shortcut key of the quick response.
        /// </para>
        /// </summary>
        public bool? RemoveShortcutKey
        {
            get { return this._removeShortcutKey; }
            set { this._removeShortcutKey = value; }
        }

        // Check to see if RemoveShortcutKey property is set
        internal bool IsSetRemoveShortcutKey()
        {
            return this._removeShortcutKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShortcutKey. 
        /// <para>
        /// The shortcut key of the quick response. The value should be unique across the knowledge
        /// base.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string ShortcutKey
        {
            get { return this._shortcutKey; }
            set { this._shortcutKey = value; }
        }

        // Check to see if ShortcutKey property is set
        internal bool IsSetShortcutKey()
        {
            return this._shortcutKey != null;
        }

    }
}