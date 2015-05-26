/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the efs-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// This object provides description of a file system.
    /// </summary>
    public partial class CreateFileSystemResult : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _creationToken;
        private string _fileSystemId;
        private LifeCycleState _lifeCycleState;
        private string _name;
        private int? _numberOfMountTargets;
        private string _ownerId;
        private FileSystemSize _sizeInBytes;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the file system was created, in seconds, since 1970-01-01T00:00:00Z.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationToken. 
        /// <para>
        /// Opaque string specified in the request. 
        /// </para>
        /// </summary>
        public string CreationToken
        {
            get { return this._creationToken; }
            set { this._creationToken = value; }
        }

        // Check to see if CreationToken property is set
        internal bool IsSetCreationToken()
        {
            return this._creationToken != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The file system ID assigned by Amazon EFS.
        /// </para>
        /// </summary>
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property LifeCycleState. 
        /// <para>
        /// A predefined string value that indicates the lifecycle phase of the file system. 
        /// </para>
        /// </summary>
        public LifeCycleState LifeCycleState
        {
            get { return this._lifeCycleState; }
            set { this._lifeCycleState = value; }
        }

        // Check to see if LifeCycleState property is set
        internal bool IsSetLifeCycleState()
        {
            return this._lifeCycleState != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// You can add tags to a file system (see <a>CreateTags</a>) including a "Name" tag.
        /// If the file system has a "Name" tag, Amazon EFS returns the value in this field. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NumberOfMountTargets. 
        /// <para>
        /// The current number of mount targets (see <a>CreateMountTarget</a>) the file system
        /// has.
        /// </para>
        /// </summary>
        public int NumberOfMountTargets
        {
            get { return this._numberOfMountTargets.GetValueOrDefault(); }
            set { this._numberOfMountTargets = value; }
        }

        // Check to see if NumberOfMountTargets property is set
        internal bool IsSetNumberOfMountTargets()
        {
            return this._numberOfMountTargets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The AWS account that created the file system. If the file system was created by an
        /// IAM user, the parent account to which the user belongs is the owner.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        ///  This object provides the latest known metered size of data stored in the file system,
        /// in bytes, in its <code>Value</code> field, and the time at which that size was determined
        /// in its <code>Timestamp</code> field. The <code>Timestamp</code> value is the integer
        /// number of seconds since 1970-01-01T00:00:00Z. Note that the value does not represent
        /// the size of a consistent snapshot of the file system, but it is eventually consistent
        /// when there are no writes to the file system. That is, the value will represent actual
        /// size only if the file system is not modified for a period longer than a couple of
        /// hours. Otherwise, the value is not the exact size the file system was at any instant
        /// in time. 
        /// </para>
        /// </summary>
        public FileSystemSize SizeInBytes
        {
            get { return this._sizeInBytes; }
            set { this._sizeInBytes = value; }
        }

        // Check to see if SizeInBytes property is set
        internal bool IsSetSizeInBytes()
        {
            return this._sizeInBytes != null;
        }

    }
}