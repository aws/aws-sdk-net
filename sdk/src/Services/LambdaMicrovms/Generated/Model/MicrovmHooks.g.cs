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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Resume. 
        /// <para>
        /// The path of the hook invoked when the MicroVM resumes from a suspended state.
        /// </para>
        /// </summary>
        public HookState Resume { get; set; }

        /// <summary>
        /// Checks to see if the Resume property is set.
        /// </summary>
        internal bool IsSetResume() => this.Resume != null;

        /// <summary>
        /// Gets and sets the property ResumeTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the resume hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public int? ResumeTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ResumeTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetResumeTimeoutInSeconds() => this.ResumeTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Run. 
        /// <para>
        /// The path of the hook invoked when the MicroVM starts running.
        /// </para>
        /// </summary>
        public HookState Run { get; set; }

        /// <summary>
        /// Checks to see if the Run property is set.
        /// </summary>
        internal bool IsSetRun() => this.Run != null;

        /// <summary>
        /// Gets and sets the property RunTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the run hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public int? RunTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RunTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetRunTimeoutInSeconds() => this.RunTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Suspend. 
        /// <para>
        /// The path of the hook invoked when the MicroVM is suspended.
        /// </para>
        /// </summary>
        public HookState Suspend { get; set; }

        /// <summary>
        /// Checks to see if the Suspend property is set.
        /// </summary>
        internal bool IsSetSuspend() => this.Suspend != null;

        /// <summary>
        /// Gets and sets the property SuspendTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the suspend hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public int? SuspendTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SuspendTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetSuspendTimeoutInSeconds() => this.SuspendTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Terminate. 
        /// <para>
        /// The path of the hook invoked when the MicroVM is terminated.
        /// </para>
        /// </summary>
        public HookState Terminate { get; set; }

        /// <summary>
        /// Checks to see if the Terminate property is set.
        /// </summary>
        internal bool IsSetTerminate() => this.Terminate != null;

        /// <summary>
        /// Gets and sets the property TerminateTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the terminate hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public int? TerminateTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TerminateTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetTerminateTimeoutInSeconds() => this.TerminateTimeoutInSeconds.HasValue;
    }
}
