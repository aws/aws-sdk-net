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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Identifies the user for a job.
    /// </summary>
    public partial class JobRunAsUser
    {
        /// <summary>
        /// Gets and sets the property Posix. 
        /// <para>
        /// The user and group that the jobs in the queue run as.
        /// </para>
        /// </summary>
        public PosixUser Posix { get; set; }

        /// <summary>
        /// Checks to see if the Posix property is set.
        /// </summary>
        internal bool IsSetPosix() => this.Posix != null;

        /// <summary>
        /// Gets and sets the property RunAs. 
        /// <para>
        /// Specifies whether the job should run using the queue's system user or if the job should
        /// run using the worker agent system user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RunAs RunAs { get; set; }

        /// <summary>
        /// Checks to see if the RunAs property is set.
        /// </summary>
        internal bool IsSetRunAs() => this.RunAs != null;

        /// <summary>
        /// Gets and sets the property Windows. 
        /// <para>
        /// Identifies a Microsoft Windows user.
        /// </para>
        /// </summary>
        public WindowsUser Windows { get; set; }

        /// <summary>
        /// Checks to see if the Windows property is set.
        /// </summary>
        internal bool IsSetWindows() => this.Windows != null;
    }
}
