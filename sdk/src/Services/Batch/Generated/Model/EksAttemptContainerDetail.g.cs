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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the details for an attempt for a job attempt that an Amazon
    /// EKS container runs.
    /// </summary>
    public partial class EksAttemptContainerDetail
    {
        /// <summary>
        /// Gets and sets the property ContainerID. 
        /// <para>
        /// The ID for the container.
        /// </para>
        /// </summary>
        public string ContainerID { get; set; }

        /// <summary>
        /// Checks to see if the ContainerID property is set.
        /// </summary>
        internal bool IsSetContainerID() => this.ContainerID != null;

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code returned for the job attempt. A non-zero exit code is considered failed.
        /// </para>
        /// </summary>
        public int? ExitCode { get; set; }

        /// <summary>
        /// Checks to see if the ExitCode property is set.
        /// </summary>
        internal bool IsSetExitCode() => this.ExitCode.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a container.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A short (255 max characters) human-readable string to provide additional details for
        /// a running or stopped container.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
