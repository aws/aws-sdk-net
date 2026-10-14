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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The number of files or objects that DataSync fails to prepare, transfer, verify, and
    /// delete during your task execution.
    /// 
    ///  <note> 
    /// <para>
    /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
    /// mode tasks</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TaskExecutionFilesFailedDetail
    {
        /// <summary>
        /// Gets and sets the property Delete. 
        /// <para>
        /// The number of files or objects that DataSync fails to delete during your task execution.
        /// </para>
        /// </summary>
        public long? Delete { get; set; }

        /// <summary>
        /// Checks to see if the Delete property is set.
        /// </summary>
        internal bool IsSetDelete() => this.Delete.HasValue;

        /// <summary>
        /// Gets and sets the property Prepare. 
        /// <para>
        /// The number of files or objects that DataSync fails to prepare during your task execution.
        /// </para>
        /// </summary>
        public long? Prepare { get; set; }

        /// <summary>
        /// Checks to see if the Prepare property is set.
        /// </summary>
        internal bool IsSetPrepare() => this.Prepare.HasValue;

        /// <summary>
        /// Gets and sets the property Transfer. 
        /// <para>
        /// The number of files or objects that DataSync fails to transfer during your task execution.
        /// </para>
        /// </summary>
        public long? Transfer { get; set; }

        /// <summary>
        /// Checks to see if the Transfer property is set.
        /// </summary>
        internal bool IsSetTransfer() => this.Transfer.HasValue;

        /// <summary>
        /// Gets and sets the property Verify. 
        /// <para>
        /// The number of files or objects that DataSync fails to verify during your task execution.
        /// </para>
        /// </summary>
        public long? Verify { get; set; }

        /// <summary>
        /// Checks to see if the Verify property is set.
        /// </summary>
        internal bool IsSetVerify() => this.Verify.HasValue;
    }
}
