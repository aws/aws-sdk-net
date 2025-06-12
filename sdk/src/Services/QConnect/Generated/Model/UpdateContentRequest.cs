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
    /// Container for the parameters to the UpdateContent operation.
    /// Updates information about the content.
    /// </summary>
    public partial class UpdateContentRequest : AmazonQConnectRequest
    {
        private string _contentId;
        private string _knowledgeBaseId;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _overrideLinkOutUri;
        private bool? _removeOverrideLinkOutUri;
        private string _revisionId;
        private string _title;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property ContentId. 
        /// <para>
        /// The identifier of the content. Can be either the ID or the ARN. URLs cannot contain
        /// the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentId
        {
            get { return this._contentId; }
            set { this._contentId = value; }
        }

        // Check to see if ContentId property is set
        internal bool IsSetContentId()
        {
            return this._contentId != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. This should not be a QUICK_RESPONSES type knowledge
        /// base. Can be either the ID or the ARN
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
        /// Gets and sets the property Metadata. 
        /// <para>
        /// A key/value map to store attributes without affecting tagging or recommendations.
        /// For example, when synchronizing data between an external system and Amazon Q in Connect,
        /// you can store an external version identifier as metadata to utilize for determining
        /// drift.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OverrideLinkOutUri. 
        /// <para>
        /// The URI for the article. If the knowledge base has a templateUri, setting this argument
        /// overrides it for this piece of content. To remove an existing <c>overrideLinkOurUri</c>,
        /// exclude this argument and set <c>removeOverrideLinkOutUri</c> to true.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string OverrideLinkOutUri
        {
            get { return this._overrideLinkOutUri; }
            set { this._overrideLinkOutUri = value; }
        }

        // Check to see if OverrideLinkOutUri property is set
        internal bool IsSetOverrideLinkOutUri()
        {
            return this._overrideLinkOutUri != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveOverrideLinkOutUri. 
        /// <para>
        /// Unset the existing <c>overrideLinkOutUri</c> if it exists.
        /// </para>
        /// </summary>
        public bool? RemoveOverrideLinkOutUri
        {
            get { return this._removeOverrideLinkOutUri; }
            set { this._removeOverrideLinkOutUri = value; }
        }

        // Check to see if RemoveOverrideLinkOutUri property is set
        internal bool IsSetRemoveOverrideLinkOutUri()
        {
            return this._removeOverrideLinkOutUri.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The <c>revisionId</c> of the content resource to update, taken from an earlier call
        /// to <c>GetContent</c>, <c>GetContentSummary</c>, <c>SearchContent</c>, or <c>ListContents</c>.
        /// If included, this argument acts as an optimistic lock to ensure content was not modified
        /// since it was last read. If it has been modified, this API throws a <c>PreconditionFailedException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// A pointer to the uploaded asset. This value is returned by <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1200)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

    }
}