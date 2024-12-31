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
    /// The summary of the message template version.
    /// </summary>
    public partial class MessageTemplateVersionSummary
    {
        private ChannelSubtype _channelSubtype;
        private bool? _isActive;
        private string _knowledgeBaseArn;
        private string _knowledgeBaseId;
        private string _messageTemplateArn;
        private string _messageTemplateId;
        private string _name;
        private long? _versionNumber;

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
        /// Gets and sets the property IsActive. 
        /// <para>
        /// Whether the version of the message template is activated.
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
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the message template version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}