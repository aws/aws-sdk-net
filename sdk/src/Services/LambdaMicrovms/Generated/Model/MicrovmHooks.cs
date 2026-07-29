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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Configuration for lifecycle hooks invoked during MicroVM events such as run, resume,
    /// suspend, and terminate.
    /// </summary>
    public partial class MicrovmHooks
    {
        private HookState _resume;
        private int? _resumeTimeoutInSeconds;
        private HookState _run;
        private int? _runTimeoutInSeconds;
        private HookState _suspend;
        private int? _suspendTimeoutInSeconds;
        private HookState _terminate;
        private int? _terminateTimeoutInSeconds;

        /// <summary>
        /// Gets and sets the property Resume. 
        /// <para>
        /// The path of the hook invoked when the MicroVM resumes from a suspended state.
        /// </para>
        /// </summary>
        public HookState Resume
        {
            get { return this._resume; }
            set { this._resume = value; }
        }

        // Check to see if Resume property is set
        internal bool IsSetResume()
        {
            return this._resume != null;
        }

        /// <summary>
        /// Gets and sets the property ResumeTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the resume hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public int? ResumeTimeoutInSeconds
        {
            get { return this._resumeTimeoutInSeconds; }
            set { this._resumeTimeoutInSeconds = value; }
        }

        // Check to see if ResumeTimeoutInSeconds property is set
        internal bool IsSetResumeTimeoutInSeconds()
        {
            return this._resumeTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Run. 
        /// <para>
        /// The path of the hook invoked when the MicroVM starts running.
        /// </para>
        /// </summary>
        public HookState Run
        {
            get { return this._run; }
            set { this._run = value; }
        }

        // Check to see if Run property is set
        internal bool IsSetRun()
        {
            return this._run != null;
        }

        /// <summary>
        /// Gets and sets the property RunTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the run hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public int? RunTimeoutInSeconds
        {
            get { return this._runTimeoutInSeconds; }
            set { this._runTimeoutInSeconds = value; }
        }

        // Check to see if RunTimeoutInSeconds property is set
        internal bool IsSetRunTimeoutInSeconds()
        {
            return this._runTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Suspend. 
        /// <para>
        /// The path of the hook invoked when the MicroVM is suspended.
        /// </para>
        /// </summary>
        public HookState Suspend
        {
            get { return this._suspend; }
            set { this._suspend = value; }
        }

        // Check to see if Suspend property is set
        internal bool IsSetSuspend()
        {
            return this._suspend != null;
        }

        /// <summary>
        /// Gets and sets the property SuspendTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the suspend hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public int? SuspendTimeoutInSeconds
        {
            get { return this._suspendTimeoutInSeconds; }
            set { this._suspendTimeoutInSeconds = value; }
        }

        // Check to see if SuspendTimeoutInSeconds property is set
        internal bool IsSetSuspendTimeoutInSeconds()
        {
            return this._suspendTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Terminate. 
        /// <para>
        /// The path of the hook invoked when the MicroVM is terminated.
        /// </para>
        /// </summary>
        public HookState Terminate
        {
            get { return this._terminate; }
            set { this._terminate = value; }
        }

        // Check to see if Terminate property is set
        internal bool IsSetTerminate()
        {
            return this._terminate != null;
        }

        /// <summary>
        /// Gets and sets the property TerminateTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the terminate hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public int? TerminateTimeoutInSeconds
        {
            get { return this._terminateTimeoutInSeconds; }
            set { this._terminateTimeoutInSeconds = value; }
        }

        // Check to see if TerminateTimeoutInSeconds property is set
        internal bool IsSetTerminateTimeoutInSeconds()
        {
            return this._terminateTimeoutInSeconds.HasValue; 
        }

    }
}