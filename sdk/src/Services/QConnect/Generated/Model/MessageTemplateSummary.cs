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
    /// The summary of the message template.
    /// </summary>
    public partial class MessageTemplateSummary
    {
        private long? _activeVersionNumber;
        private ChannelSubtype _channelSubtype;
        private DateTime? _createdTime;
        private string _description;
        private string _knowledgeBaseArn;
        private string _knowledgeBaseId;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private string _messageTemplateArn;
        private string _messageTemplateId;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ActiveVersionNumber. 
        /// <para>
        /// The version number of the message template version that is activated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ActiveVersionNumber
        {
            get { return this._activeVersionNumber; }
            set { this._activeVersionNumber = value; }
        }

        // Check to see if ActiveVersionNumber property is set
        internal bool IsSetActiveVersionNumber()
        {
            return this._activeVersionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChannelSubtype. 
        /// <para>
        /// The channel subtype this message template applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelSubtype ChannelSubtype
        {
            get { return this._channelSubtype; }
            set { this._channelSubtype = value; }
        }

        // Check to see if ChannelSubtype property is set
        internal bool IsSetChannelSubtype()
        {
            return this._channelSubtype != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the message template was created.
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
        /// The description of the message template.
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
        /// The identifier of the knowledge base.
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
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the message template data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// The timestamp when the message template data was last modified.
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
        /// Gets and sets the property MessageTemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MessageTemplateArn
        {
            get { return this._messageTemplateArn; }
            set { this._messageTemplateArn = value; }
        }

        // Check to see if MessageTemplateArn property is set
        internal bool IsSetMessageTemplateArn()
        {
            return this._messageTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property MessageTemplateId. 
        /// <para>
        /// The identifier of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MessageTemplateId
        {
            get { return this._messageTemplateId; }
            set { this._messageTemplateId = value; }
        }

        // Check to see if MessageTemplateId property is set
        internal bool IsSetMessageTemplateId()
        {
            return this._messageTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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