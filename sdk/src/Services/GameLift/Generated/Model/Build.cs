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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Properties describing a game build.
    /// </summary>
    public partial class Build
    {
        private string _buildId;
        private DateTime? _creationTime;
        private string _name;
        private OperatingSystem _operatingSystem;
        private long? _sizeOnDisk;
        private BuildStatus _status;
        private string _version;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// Unique identifier for a build.
        /// </para>
        /// </summary>
        public string BuildId
        {
            get { return this._buildId; }
            set { this._buildId = value; }
        }

        // Check to see if BuildId property is set
        internal bool IsSetBuildId()
        {
            return this._buildId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (ex: "1469498468.057".
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label associated with a build. Build names do not need to be unique. It
        /// can be set using <a>CreateBuild</a> or <a>UpdateBuild</a>.
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// Operating system that the game server binaries are built to run on. This value determines
        /// the type of fleet resources that you can use for this build.
        /// </para>
        /// </summary>
        public OperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property SizeOnDisk. 
        /// <para>
        /// File size of the uploaded game build, expressed in bytes. When the build status is
        /// <code>INITIALIZED</code>, this value is 0.
        /// </para>
        /// </summary>
        public long SizeOnDisk
        {
            get { return this._sizeOnDisk.GetValueOrDefault(); }
            set { this._sizeOnDisk = value; }
        }

        // Check to see if SizeOnDisk property is set
        internal bool IsSetSizeOnDisk()
        {
            return this._sizeOnDisk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the build.
        /// </para>
        ///  
        /// <para>
        /// Possible build statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>INITIALIZED</b> – A new build has been defined, but no files have been uploaded.
        /// You cannot create fleets for builds that are in this status. When a build is successfully
        /// created, the build status is set to this value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>READY</b> – The game build has been successfully uploaded. You can now create
        /// new fleets for this build.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b> – The game build upload failed. You cannot create new fleets for this
        /// build. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BuildStatus Status
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
        /// Gets and sets the property Version. 
        /// <para>
        /// Version associated with this build. Version strings do not need to be unique to a
        /// build. This value can be set using <a>CreateBuild</a> or <a>UpdateBuild</a>.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}