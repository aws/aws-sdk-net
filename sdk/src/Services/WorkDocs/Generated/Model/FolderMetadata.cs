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
    /// Describes a folder.
    /// </summary>
    public partial class FolderMetadata
    {
        private DateTime? _createdTimestamp;
        private string _creatorId;
        private string _id;
        private List<string> _labels = new List<string>();
        private long? _latestVersionSize;
        private DateTime? _modifiedTimestamp;
        private string _name;
        private string _parentFolderId;
        private ResourceStateType _resourceState;
        private string _signature;
        private long? _size;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the folder was created.
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
        /// The ID of the folder.
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
        /// Gets and sets the property Labels. 
        /// <para>
        /// List of labels on the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && this._labels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LatestVersionSize. 
        /// <para>
        /// The size of the latest version of the folder metadata.
        /// </para>
        /// </summary>
        public long LatestVersionSize
        {
            get { return this._latestVersionSize.GetValueOrDefault(); }
            set { this._latestVersionSize = value; }
        }

        // Check to see if LatestVersionSize property is set
        internal bool IsSetLatestVersionSize()
        {
            return this._latestVersionSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The time when the folder was updated.
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
        /// The name of the folder.
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
        /// Gets and sets the property ParentFolderId. 
        /// <para>
        /// The ID of the parent folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ParentFolderId
        {
            get { return this._parentFolderId; }
            set { this._parentFolderId = value; }
        }

        // Check to see if ParentFolderId property is set
        internal bool IsSetParentFolderId()
        {
            return this._parentFolderId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceState. 
        /// <para>
        /// The resource state of the folder.
        /// </para>
        /// </summary>
        public ResourceStateType ResourceState
        {
            get { return this._resourceState; }
            set { this._resourceState = value; }
        }

        // Check to see if ResourceState property is set
        internal bool IsSetResourceState()
        {
            return this._resourceState != null;
        }

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// The unique identifier created from the subfolders and documents of the folder.
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
        /// The size of the folder metadata.
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

    }
}