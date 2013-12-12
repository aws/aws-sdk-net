/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes how many instances a stack has for each status.</para>
    /// </summary>
    public class InstancesCount
    {
        
        private int? booting;
        private int? connectionLost;
        private int? pending;
        private int? rebooting;
        private int? requested;
        private int? runningSetup;
        private int? setupFailed;
        private int? shuttingDown;
        private int? startFailed;
        private int? stopped;
        private int? terminated;
        private int? terminating;


        /// <summary>
        /// The number of instances with <c>booting</c> status.
        ///  
        /// </summary>
        public int Booting
        {
            get { return this.booting ?? default(int); }
            set { this.booting = value; }
        }

        // Check to see if Booting property is set
        internal bool IsSetBooting()
        {
            return this.booting.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>connection_lost</c> status.
        ///  
        /// </summary>
        public int ConnectionLost
        {
            get { return this.connectionLost ?? default(int); }
            set { this.connectionLost = value; }
        }

        // Check to see if ConnectionLost property is set
        internal bool IsSetConnectionLost()
        {
            return this.connectionLost.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>pending</c> status.
        ///  
        /// </summary>
        public int Pending
        {
            get { return this.pending ?? default(int); }
            set { this.pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this.pending.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>rebooting</c> status.
        ///  
        /// </summary>
        public int Rebooting
        {
            get { return this.rebooting ?? default(int); }
            set { this.rebooting = value; }
        }

        // Check to see if Rebooting property is set
        internal bool IsSetRebooting()
        {
            return this.rebooting.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>requested</c> status.
        ///  
        /// </summary>
        public int Requested
        {
            get { return this.requested ?? default(int); }
            set { this.requested = value; }
        }

        // Check to see if Requested property is set
        internal bool IsSetRequested()
        {
            return this.requested.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>running_setup</c> status.
        ///  
        /// </summary>
        public int RunningSetup
        {
            get { return this.runningSetup ?? default(int); }
            set { this.runningSetup = value; }
        }

        // Check to see if RunningSetup property is set
        internal bool IsSetRunningSetup()
        {
            return this.runningSetup.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>setup_failed</c> status.
        ///  
        /// </summary>
        public int SetupFailed
        {
            get { return this.setupFailed ?? default(int); }
            set { this.setupFailed = value; }
        }

        // Check to see if SetupFailed property is set
        internal bool IsSetSetupFailed()
        {
            return this.setupFailed.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>shutting_down</c> status.
        ///  
        /// </summary>
        public int ShuttingDown
        {
            get { return this.shuttingDown ?? default(int); }
            set { this.shuttingDown = value; }
        }

        // Check to see if ShuttingDown property is set
        internal bool IsSetShuttingDown()
        {
            return this.shuttingDown.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>start_failed</c> status.
        ///  
        /// </summary>
        public int StartFailed
        {
            get { return this.startFailed ?? default(int); }
            set { this.startFailed = value; }
        }

        // Check to see if StartFailed property is set
        internal bool IsSetStartFailed()
        {
            return this.startFailed.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>stopped</c> status.
        ///  
        /// </summary>
        public int Stopped
        {
            get { return this.stopped ?? default(int); }
            set { this.stopped = value; }
        }

        // Check to see if Stopped property is set
        internal bool IsSetStopped()
        {
            return this.stopped.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>terminated</c> status.
        ///  
        /// </summary>
        public int Terminated
        {
            get { return this.terminated ?? default(int); }
            set { this.terminated = value; }
        }

        // Check to see if Terminated property is set
        internal bool IsSetTerminated()
        {
            return this.terminated.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>terminating</c> status.
        ///  
        /// </summary>
        public int Terminating
        {
            get { return this.terminating ?? default(int); }
            set { this.terminating = value; }
        }

        // Check to see if Terminating property is set
        internal bool IsSetTerminating()
        {
            return this.terminating.HasValue;
        }
    }
}
