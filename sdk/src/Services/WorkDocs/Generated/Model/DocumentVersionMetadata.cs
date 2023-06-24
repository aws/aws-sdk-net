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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes a version of a document.
    /// </summary>
    public partial class DocumentVersionMetadata
    {
        private DateTime? _contentCreatedTimestamp;
        private DateTime? _contentModifiedTimestamp;
        private string _contentType;
        private DateTime? _createdTimestamp;
        private string _creatorId;
        private string _id;
        private DateTime? _modifiedTimestamp;
        private string _name;
        private string _signature;
        private long? _size;
        private Dictionary<string, string> _source = new Dictionary<string, string>();
        private DocumentStatusType _status;
        private Dictionary<string, string> _thumbnail = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ContentCreatedTimestamp. 
        /// <para>
        /// The timestamp when the content of the document was originally created.
        /// </para>
        /// </summary>
        public DateTime ContentCreatedTimestamp
        {
            get { return this._contentCreatedTimestamp.GetValueOrDefault(); }
            set { this._contentCreatedTimestamp = value; }
        }

        // Check to see if ContentCreatedTimestamp property is set
        internal bool IsSetContentCreatedTimestamp()
        {
            return this._contentCreatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentModifiedTimestamp. 
        /// <para>
        /// The timestamp when the content of the document was modified.
        /// </para>
        /// </summary>
        public DateTime ContentModifiedTimestamp
        {
            get { return this._contentModifiedTimestamp.GetValueOrDefault(); }
            set { this._contentModifiedTimestamp = value; }
        }

        // Check to see if ContentModifiedTimestamp property is set
        internal bool IsSetContentModifiedTimestamp()
        {
            return this._contentModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp when the document was first uploaded.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatorId. 
        /// <para>
        /// The ID of the creator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CreatorId
        {
            get { return this._creatorId; }
            set { this._creatorId = value; }
        }

        // Check to see if CreatorId property is set
        internal bool IsSetCreatorId()
        {
            return this._creatorId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The timestamp when the document was last uploaded.
        /// </para>
        /// </summary>
        public DateTime ModifiedTimestamp
        {
            get { return this._modifiedTimestamp.GetValueOrDefault(); }
            set { this._modifiedTimestamp = value; }
        }

        // Check to see if ModifiedTimestamp property is set
        internal bool IsSetModifiedTimestamp()
        {
            return this._modifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
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
        /// Gets and sets the property Signature. 
        /// <para>
        /// The signature of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Signature
        {
            get { return this._signature; }
            set { this._signature = value; }
        }

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this._signature != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the document, in bytes.
        /// </para>
        /// </summary>
        public long Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the document.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null && this._source.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the document.
        /// </para>
        /// </summary>
        public DocumentStatusType Status
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
        /// Gets and sets the property Thumbnail. 
        /// <para>
        /// The thumbnail of the document.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Thumbnail
        {
            get { return this._thumbnail; }
            set { this._thumbnail = value; }
        }

        // Check to see if Thumbnail property is set
        internal bool IsSetThumbnail()
        {
            return this._thumbnail != null && this._thumbnail.Count > 0; 
        }

    }
}