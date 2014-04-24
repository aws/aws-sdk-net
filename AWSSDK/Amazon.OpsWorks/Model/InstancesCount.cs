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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes how many instances a stack has for each status.</para>
    /// </summary>
    public partial class InstancesCount
    {
        
        private int? booting;
        private int? connectionLost;
        private int? online;
        private int? pending;
        private int? rebooting;
        private int? requested;
        private int? runningSetup;
        private int? setupFailed;
        private int? shuttingDown;
        private int? startFailed;
        private int? stopped;
        private int? stopping;
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

        /// <summary>
        /// Sets the Booting property
        /// </summary>
        /// <param name="booting">The value to set for the Booting property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithBooting(int booting)
        {
            this.booting = booting;
            return this;
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

        /// <summary>
        /// Sets the ConnectionLost property
        /// </summary>
        /// <param name="connectionLost">The value to set for the ConnectionLost property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithConnectionLost(int connectionLost)
        {
            this.connectionLost = connectionLost;
            return this;
        }
            

        // Check to see if ConnectionLost property is set
        internal bool IsSetConnectionLost()
        {
            return this.connectionLost.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>online</c> status.
        ///  
        /// </summary>
        public int Online
        {
            get { return this.online ?? default(int); }
            set { this.online = value; }
        }

        /// <summary>
        /// Sets the Online property
        /// </summary>
        /// <param name="online">The value to set for the Online property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithOnline(int online)
        {
            this.online = online;
            return this;
        }
            

        // Check to see if Online property is set
        internal bool IsSetOnline()
        {
            return this.online.HasValue;
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

        /// <summary>
        /// Sets the Pending property
        /// </summary>
        /// <param name="pending">The value to set for the Pending property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithPending(int pending)
        {
            this.pending = pending;
            return this;
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

        /// <summary>
        /// Sets the Rebooting property
        /// </summary>
        /// <param name="rebooting">The value to set for the Rebooting property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithRebooting(int rebooting)
        {
            this.rebooting = rebooting;
            return this;
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

        /// <summary>
        /// Sets the Requested property
        /// </summary>
        /// <param name="requested">The value to set for the Requested property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithRequested(int requested)
        {
            this.requested = requested;
            return this;
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

        /// <summary>
        /// Sets the RunningSetup property
        /// </summary>
        /// <param name="runningSetup">The value to set for the RunningSetup property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithRunningSetup(int runningSetup)
        {
            this.runningSetup = runningSetup;
            return this;
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

        /// <summary>
        /// Sets the SetupFailed property
        /// </summary>
        /// <param name="setupFailed">The value to set for the SetupFailed property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithSetupFailed(int setupFailed)
        {
            this.setupFailed = setupFailed;
            return this;
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

        /// <summary>
        /// Sets the ShuttingDown property
        /// </summary>
        /// <param name="shuttingDown">The value to set for the ShuttingDown property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithShuttingDown(int shuttingDown)
        {
            this.shuttingDown = shuttingDown;
            return this;
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

        /// <summary>
        /// Sets the StartFailed property
        /// </summary>
        /// <param name="startFailed">The value to set for the StartFailed property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithStartFailed(int startFailed)
        {
            this.startFailed = startFailed;
            return this;
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

        /// <summary>
        /// Sets the Stopped property
        /// </summary>
        /// <param name="stopped">The value to set for the Stopped property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithStopped(int stopped)
        {
            this.stopped = stopped;
            return this;
        }
            

        // Check to see if Stopped property is set
        internal bool IsSetStopped()
        {
            return this.stopped.HasValue;
        }

        /// <summary>
        /// The number of instances with <c>stopping</c> status.
        ///  
        /// </summary>
        public int Stopping
        {
            get { return this.stopping ?? default(int); }
            set { this.stopping = value; }
        }

        /// <summary>
        /// Sets the Stopping property
        /// </summary>
        /// <param name="stopping">The value to set for the Stopping property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithStopping(int stopping)
        {
            this.stopping = stopping;
            return this;
        }
            

        // Check to see if Stopping property is set
        internal bool IsSetStopping()
        {
            return this.stopping.HasValue;
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

        /// <summary>
        /// Sets the Terminated property
        /// </summary>
        /// <param name="terminated">The value to set for the Terminated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithTerminated(int terminated)
        {
            this.terminated = terminated;
            return this;
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

        /// <summary>
        /// Sets the Terminating property
        /// </summary>
        /// <param name="terminating">The value to set for the Terminating property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancesCount WithTerminating(int terminating)
        {
            this.terminating = terminating;
            return this;
        }
            

        // Check to see if Terminating property is set
        internal bool IsSetTerminating()
        {
            return this.terminating.HasValue;
        }
    }
}
