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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Configuration for streaming workstations created using this launch profile.
    /// </summary>
    public partial class StreamConfigurationCreate
    {
        private AutomaticTerminationMode _automaticTerminationMode;
        private StreamingClipboardMode _clipboardMode;
        private List<string> _ec2InstanceTypes = new List<string>();
        private int? _maxSessionLengthInMinutes;
        private int? _maxStoppedSessionLengthInMinutes;
        private StreamConfigurationSessionBackup _sessionBackup;
        private SessionPersistenceMode _sessionPersistenceMode;
        private StreamConfigurationSessionStorage _sessionStorage;
        private List<string> _streamingImageIds = new List<string>();
        private VolumeConfiguration _volumeConfiguration;

        /// <summary>
        /// Gets and sets the property AutomaticTerminationMode. 
        /// <para>
        /// Indicates if a streaming session created from this launch profile should be terminated
        /// automatically or retained without termination after being in a <code>STOPPED</code>
        /// state.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When <code>ACTIVATED</code>, the streaming session is scheduled for termination after
        /// being in the <code>STOPPED</code> state for the time specified in <code>maxStoppedSessionLengthInMinutes</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <code>DEACTIVATED</code>, the streaming session can remain in the <code>STOPPED</code>
        /// state indefinitely.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This parameter is only allowed when <code>sessionPersistenceMode</code> is <code>ACTIVATED</code>.
        /// When allowed, the default value for this parameter is <code>DEACTIVATED</code>.
        /// </para>
        /// </summary>
        public AutomaticTerminationMode AutomaticTerminationMode
        {
            get { return this._automaticTerminationMode; }
            set { this._automaticTerminationMode = value; }
        }

        // Check to see if AutomaticTerminationMode property is set
        internal bool IsSetAutomaticTerminationMode()
        {
            return this._automaticTerminationMode != null;
        }

        /// <summary>
        /// Gets and sets the property ClipboardMode. 
        /// <para>
        /// Allows or deactivates the use of the system clipboard to copy and paste between the
        /// streaming session and streaming client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamingClipboardMode ClipboardMode
        {
            get { return this._clipboardMode; }
            set { this._clipboardMode = value; }
        }

        // Check to see if ClipboardMode property is set
        internal bool IsSetClipboardMode()
        {
            return this._clipboardMode != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceTypes. 
        /// <para>
        /// The EC2 instance types that users can select from when launching a streaming session
        /// with this launch profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<string> Ec2InstanceTypes
        {
            get { return this._ec2InstanceTypes; }
            set { this._ec2InstanceTypes = value; }
        }

        // Check to see if Ec2InstanceTypes property is set
        internal bool IsSetEc2InstanceTypes()
        {
            return this._ec2InstanceTypes != null && this._ec2InstanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxSessionLengthInMinutes. 
        /// <para>
        /// The length of time, in minutes, that a streaming session can be active before it is
        /// stopped or terminated. After this point, Nimble Studio automatically terminates or
        /// stops the session. The default length of time is 690 minutes, and the maximum length
        /// of time is 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=43200)]
        public int MaxSessionLengthInMinutes
        {
            get { return this._maxSessionLengthInMinutes.GetValueOrDefault(); }
            set { this._maxSessionLengthInMinutes = value; }
        }

        // Check to see if MaxSessionLengthInMinutes property is set
        internal bool IsSetMaxSessionLengthInMinutes()
        {
            return this._maxSessionLengthInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStoppedSessionLengthInMinutes. 
        /// <para>
        /// Integer that determines if you can start and stop your sessions and how long a session
        /// can stay in the <code>STOPPED</code> state. The default value is 0. The maximum value
        /// is 5760.
        /// </para>
        ///  
        /// <para>
        /// This field is allowed only when <code>sessionPersistenceMode</code> is <code>ACTIVATED</code>
        /// and <code>automaticTerminationMode</code> is <code>ACTIVATED</code>.
        /// </para>
        ///  
        /// <para>
        /// If the value is set to 0, your sessions can’t be <code>STOPPED</code>. If you then
        /// call <code>StopStreamingSession</code>, the session fails. If the time that a session
        /// stays in the <code>READY</code> state exceeds the <code>maxSessionLengthInMinutes</code>
        /// value, the session will automatically be terminated (instead of <code>STOPPED</code>).
        /// </para>
        ///  
        /// <para>
        /// If the value is set to a positive number, the session can be stopped. You can call
        /// <code>StopStreamingSession</code> to stop sessions in the <code>READY</code> state.
        /// If the time that a session stays in the <code>READY</code> state exceeds the <code>maxSessionLengthInMinutes</code>
        /// value, the session will automatically be stopped (instead of terminated).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5760)]
        public int MaxStoppedSessionLengthInMinutes
        {
            get { return this._maxStoppedSessionLengthInMinutes.GetValueOrDefault(); }
            set { this._maxStoppedSessionLengthInMinutes = value; }
        }

        // Check to see if MaxStoppedSessionLengthInMinutes property is set
        internal bool IsSetMaxStoppedSessionLengthInMinutes()
        {
            return this._maxStoppedSessionLengthInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionBackup. 
        /// <para>
        /// Configures how streaming sessions are backed up when launched from this launch profile.
        /// </para>
        /// </summary>
        public StreamConfigurationSessionBackup SessionBackup
        {
            get { return this._sessionBackup; }
            set { this._sessionBackup = value; }
        }

        // Check to see if SessionBackup property is set
        internal bool IsSetSessionBackup()
        {
            return this._sessionBackup != null;
        }

        /// <summary>
        /// Gets and sets the property SessionPersistenceMode. 
        /// <para>
        /// Determine if a streaming session created from this launch profile can configure persistent
        /// storage. This means that <code>volumeConfiguration</code> and <code>automaticTerminationMode</code>
        /// are configured.
        /// </para>
        /// </summary>
        public SessionPersistenceMode SessionPersistenceMode
        {
            get { return this._sessionPersistenceMode; }
            set { this._sessionPersistenceMode = value; }
        }

        // Check to see if SessionPersistenceMode property is set
        internal bool IsSetSessionPersistenceMode()
        {
            return this._sessionPersistenceMode != null;
        }

        /// <summary>
        /// Gets and sets the property SessionStorage. 
        /// <para>
        /// The upload storage for a streaming workstation that is created using this launch profile.
        /// </para>
        /// </summary>
        public StreamConfigurationSessionStorage SessionStorage
        {
            get { return this._sessionStorage; }
            set { this._sessionStorage = value; }
        }

        // Check to see if SessionStorage property is set
        internal bool IsSetSessionStorage()
        {
            return this._sessionStorage != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingImageIds. 
        /// <para>
        /// The streaming images that users can select from when launching a streaming session
        /// with this launch profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> StreamingImageIds
        {
            get { return this._streamingImageIds; }
            set { this._streamingImageIds = value; }
        }

        // Check to see if StreamingImageIds property is set
        internal bool IsSetStreamingImageIds()
        {
            return this._streamingImageIds != null && this._streamingImageIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VolumeConfiguration. 
        /// <para>
        /// Custom volume configuration for the root volumes that are attached to streaming sessions.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only allowed when <code>sessionPersistenceMode</code> is <code>ACTIVATED</code>.
        /// </para>
        /// </summary>
        public VolumeConfiguration VolumeConfiguration
        {
            get { return this._volumeConfiguration; }
            set { this._volumeConfiguration = value; }
        }

        // Check to see if VolumeConfiguration property is set
        internal bool IsSetVolumeConfiguration()
        {
            return this._volumeConfiguration != null;
        }

    }
}