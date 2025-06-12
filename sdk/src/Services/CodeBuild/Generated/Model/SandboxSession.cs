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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains information about the sandbox session.
    /// </summary>
    public partial class SandboxSession
    {
        private string _currentPhase;
        private DateTime? _endTime;
        private string _id;
        private LogsLocation _logs;
        private NetworkInterface _networkInterface;
        private List<SandboxSessionPhase> _phases = AWSConfigs.InitializeCollections ? new List<SandboxSessionPhase>() : null;
        private string _resolvedSourceVersion;
        private DateTime? _startTime;
        private string _status;

        /// <summary>
        /// Gets and sets the property CurrentPhase. 
        /// <para>
        /// The current phase for the sandbox.
        /// </para>
        /// </summary>
        public string CurrentPhase
        {
            get { return this._currentPhase; }
            set { this._currentPhase = value; }
        }

        // Check to see if CurrentPhase property is set
        internal bool IsSetCurrentPhase()
        {
            return this._currentPhase != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the sandbox session ended, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the sandbox session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property Logs.
        /// </summary>
        public LogsLocation Logs
        {
            get { return this._logs; }
            set { this._logs = value; }
        }

        // Check to see if Logs property is set
        internal bool IsSetLogs()
        {
            return this._logs != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterface.
        /// </summary>
        public NetworkInterface NetworkInterface
        {
            get { return this._networkInterface; }
            set { this._networkInterface = value; }
        }

        // Check to see if NetworkInterface property is set
        internal bool IsSetNetworkInterface()
        {
            return this._networkInterface != null;
        }

        /// <summary>
        /// Gets and sets the property Phases. 
        /// <para>
        ///  An array of <c>SandboxSessionPhase</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SandboxSessionPhase> Phases
        {
            get { return this._phases; }
            set { this._phases = value; }
        }

        // Check to see if Phases property is set
        internal bool IsSetPhases()
        {
            return this._phases != null && (this._phases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResolvedSourceVersion. 
        /// <para>
        /// An identifier for the version of this sandbox's source code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ResolvedSourceVersion
        {
            get { return this._resolvedSourceVersion; }
            set { this._resolvedSourceVersion = value; }
        }

        // Check to see if ResolvedSourceVersion property is set
        internal bool IsSetResolvedSourceVersion()
        {
            return this._resolvedSourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the sandbox session started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the sandbox session.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}