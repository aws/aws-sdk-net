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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes how many instances a stack has for each status.
    /// </summary>
    public partial class InstancesCount
    {
        private int? _booting;
        private int? _connectionLost;
        private int? _online;
        private int? _pending;
        private int? _rebooting;
        private int? _requested;
        private int? _runningSetup;
        private int? _setupFailed;
        private int? _shuttingDown;
        private int? _startFailed;
        private int? _stopped;
        private int? _stopping;
        private int? _terminated;
        private int? _terminating;


        /// <summary>
        /// Gets and sets the property Booting. 
        /// <para>
        /// The number of instances with <code>booting</code> status.
        /// </para>
        /// </summary>
        public int Booting
        {
            get { return this._booting.GetValueOrDefault(); }
            set { this._booting = value; }
        }

        // Check to see if Booting property is set
        internal bool IsSetBooting()
        {
            return this._booting.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ConnectionLost. 
        /// <para>
        /// The number of instances with <code>connection_lost</code> status.
        /// </para>
        /// </summary>
        public int ConnectionLost
        {
            get { return this._connectionLost.GetValueOrDefault(); }
            set { this._connectionLost = value; }
        }

        // Check to see if ConnectionLost property is set
        internal bool IsSetConnectionLost()
        {
            return this._connectionLost.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Online. 
        /// <para>
        /// The number of instances with <code>online</code> status.
        /// </para>
        /// </summary>
        public int Online
        {
            get { return this._online.GetValueOrDefault(); }
            set { this._online = value; }
        }

        // Check to see if Online property is set
        internal bool IsSetOnline()
        {
            return this._online.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// The number of instances with <code>pending</code> status.
        /// </para>
        /// </summary>
        public int Pending
        {
            get { return this._pending.GetValueOrDefault(); }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Rebooting. 
        /// <para>
        /// The number of instances with <code>rebooting</code> status.
        /// </para>
        /// </summary>
        public int Rebooting
        {
            get { return this._rebooting.GetValueOrDefault(); }
            set { this._rebooting = value; }
        }

        // Check to see if Rebooting property is set
        internal bool IsSetRebooting()
        {
            return this._rebooting.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Requested. 
        /// <para>
        /// The number of instances with <code>requested</code> status.
        /// </para>
        /// </summary>
        public int Requested
        {
            get { return this._requested.GetValueOrDefault(); }
            set { this._requested = value; }
        }

        // Check to see if Requested property is set
        internal bool IsSetRequested()
        {
            return this._requested.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RunningSetup. 
        /// <para>
        /// The number of instances with <code>running_setup</code> status.
        /// </para>
        /// </summary>
        public int RunningSetup
        {
            get { return this._runningSetup.GetValueOrDefault(); }
            set { this._runningSetup = value; }
        }

        // Check to see if RunningSetup property is set
        internal bool IsSetRunningSetup()
        {
            return this._runningSetup.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property SetupFailed. 
        /// <para>
        /// The number of instances with <code>setup_failed</code> status.
        /// </para>
        /// </summary>
        public int SetupFailed
        {
            get { return this._setupFailed.GetValueOrDefault(); }
            set { this._setupFailed = value; }
        }

        // Check to see if SetupFailed property is set
        internal bool IsSetSetupFailed()
        {
            return this._setupFailed.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ShuttingDown. 
        /// <para>
        /// The number of instances with <code>shutting_down</code> status.
        /// </para>
        /// </summary>
        public int ShuttingDown
        {
            get { return this._shuttingDown.GetValueOrDefault(); }
            set { this._shuttingDown = value; }
        }

        // Check to see if ShuttingDown property is set
        internal bool IsSetShuttingDown()
        {
            return this._shuttingDown.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property StartFailed. 
        /// <para>
        /// The number of instances with <code>start_failed</code> status.
        /// </para>
        /// </summary>
        public int StartFailed
        {
            get { return this._startFailed.GetValueOrDefault(); }
            set { this._startFailed = value; }
        }

        // Check to see if StartFailed property is set
        internal bool IsSetStartFailed()
        {
            return this._startFailed.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The number of instances with <code>stopped</code> status.
        /// </para>
        /// </summary>
        public int Stopped
        {
            get { return this._stopped.GetValueOrDefault(); }
            set { this._stopped = value; }
        }

        // Check to see if Stopped property is set
        internal bool IsSetStopped()
        {
            return this._stopped.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Stopping. 
        /// <para>
        /// The number of instances with <code>stopping</code> status.
        /// </para>
        /// </summary>
        public int Stopping
        {
            get { return this._stopping.GetValueOrDefault(); }
            set { this._stopping = value; }
        }

        // Check to see if Stopping property is set
        internal bool IsSetStopping()
        {
            return this._stopping.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Terminated. 
        /// <para>
        /// The number of instances with <code>terminated</code> status.
        /// </para>
        /// </summary>
        public int Terminated
        {
            get { return this._terminated.GetValueOrDefault(); }
            set { this._terminated = value; }
        }

        // Check to see if Terminated property is set
        internal bool IsSetTerminated()
        {
            return this._terminated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Terminating. 
        /// <para>
        /// The number of instances with <code>terminating</code> status.
        /// </para>
        /// </summary>
        public int Terminating
        {
            get { return this._terminating.GetValueOrDefault(); }
            set { this._terminating = value; }
        }

        // Check to see if Terminating property is set
        internal bool IsSetTerminating()
        {
            return this._terminating.HasValue; 
        }

    }
}