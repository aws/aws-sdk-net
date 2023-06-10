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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the runtime process details.
    /// </summary>
    public partial class LineageObject
    {
        private int? _euid;
        private string _executablePath;
        private string _name;
        private int? _namespacePid;
        private string _parentUuid;
        private int? _pid;
        private DateTime? _startTime;
        private int? _userId;
        private string _uuid;

        /// <summary>
        /// Gets and sets the property Euid. 
        /// <para>
        /// The effective user ID that was used to execute the process.
        /// </para>
        /// </summary>
        public int Euid
        {
            get { return this._euid.GetValueOrDefault(); }
            set { this._euid = value; }
        }

        // Check to see if Euid property is set
        internal bool IsSetEuid()
        {
            return this._euid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutablePath. 
        /// <para>
        /// The absolute path of the process executable file.
        /// </para>
        /// </summary>
        public string ExecutablePath
        {
            get { return this._executablePath; }
            set { this._executablePath = value; }
        }

        // Check to see if ExecutablePath property is set
        internal bool IsSetExecutablePath()
        {
            return this._executablePath != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the process.
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
        /// Gets and sets the property NamespacePid. 
        /// <para>
        /// The process ID of the child process.
        /// </para>
        /// </summary>
        public int NamespacePid
        {
            get { return this._namespacePid.GetValueOrDefault(); }
            set { this._namespacePid = value; }
        }

        // Check to see if NamespacePid property is set
        internal bool IsSetNamespacePid()
        {
            return this._namespacePid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentUuid. 
        /// <para>
        /// The unique ID of the parent process. This ID is assigned to the parent process by
        /// GuardDuty.
        /// </para>
        /// </summary>
        public string ParentUuid
        {
            get { return this._parentUuid; }
            set { this._parentUuid = value; }
        }

        // Check to see if ParentUuid property is set
        internal bool IsSetParentUuid()
        {
            return this._parentUuid != null;
        }

        /// <summary>
        /// Gets and sets the property Pid. 
        /// <para>
        /// The ID of the process.
        /// </para>
        /// </summary>
        public int Pid
        {
            get { return this._pid.GetValueOrDefault(); }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the process started. This is in UTC format.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID of the user that executed the process.
        /// </para>
        /// </summary>
        public int UserId
        {
            get { return this._userId.GetValueOrDefault(); }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// The unique ID assigned to the process by GuardDuty.
        /// </para>
        /// </summary>
        public string Uuid
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if Uuid property is set
        internal bool IsSetUuid()
        {
            return this._uuid != null;
        }

    }
}