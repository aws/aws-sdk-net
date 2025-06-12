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
    /// The result of quick response search.
    /// </summary>
    public partial class QuickResponseSearchResultData
    {
        private List<string> _attributesInterpolated = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _attributesNotInterpolated = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _channels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private QuickResponseContents _contents;
        private string _contentType;
        private DateTime? _createdTime;
        private string _description;
        private GroupingConfiguration _groupingConfiguration;
        private bool? _isActive;
        private string _knowledgeBaseArn;
        private string _knowledgeBaseId;
        private string _language;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private string _name;
        private string _quickResponseArn;
        private string _quickResponseId;
        private string _shortcutKey;
        private QuickResponseStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AttributesInterpolated. 
        /// <para>
        /// The user defined contact attributes that are resolved when the search result is returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> AttributesInterpolated
        {
            get { return this._attributesInterpolated; }
            set { this._attributesInterpolated = value; }
        }

        // Check to see if AttributesInterpolated property is set
        internal bool IsSetAttributesInterpolated()
        {
            return this._attributesInterpolated != null && (this._attributesInterpolated.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttributesNotInterpolated. 
        /// <para>
        /// The user defined contact attributes that are not resolved when the search result is
        /// returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> AttributesNotInterpolated
        {
            get { return this._attributesNotInterpolated; }
            set { this._attributesNotInterpolated = value; }
        }

        // Check to see if AttributesNotInterpolated property is set
        internal bool IsSetAttributesNotInterpolated()
        {
            return this._attributesNotInterpolated != null && (this._attributesNotInterpolated.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Gets and sets the property Contents. 
        /// <para>
        /// The contents of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuickResponseContents Contents
        {
            get { return this._contents; }
            set { this._contents = value; }
        }

        // Check to see if Contents property is set
        internal bool IsSetContents()
        {
            return this._contents != null;
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the quick response was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the quick response.
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
        /// The configuration information of the user groups that the quick response is accessible
        /// to.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseArn
        {
            get { return this._knowledgeBaseArn; }
            set { this._knowledgeBaseArn = value; }
        }

        // Check to see if KnowledgeBaseArn property is set
        internal bool IsSetKnowledgeBaseArn()
        {
            return this._knowledgeBaseArn != null;
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
        /// The language code value for the language in which the quick response is written.
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
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the quick response search
        /// result data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the quick response search result data was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property QuickResponseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QuickResponseArn
        {
            get { return this._quickResponseArn; }
            set { this._quickResponseArn = value; }
        }

        // Check to see if QuickResponseArn property is set
        internal bool IsSetQuickResponseArn()
        {
            return this._quickResponseArn != null;
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The resource status of the quick response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuickResponseStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
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