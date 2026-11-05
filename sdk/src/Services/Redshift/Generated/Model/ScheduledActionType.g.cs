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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// The action type that specifies an Amazon Redshift API operation that is supported
    /// by the Amazon Redshift scheduler.
    /// </summary>
    public partial class ScheduledActionType
    {
        /// <summary>
        /// Gets and sets the property PauseCluster. 
        /// <para>
        /// An action that runs a <c>PauseCluster</c> API operation. 
        /// </para>
        /// </summary>
        public PauseClusterMessage PauseCluster { get; set; }

        /// <summary>
        /// Checks to see if the PauseCluster property is set.
        /// </summary>
        internal bool IsSetPauseCluster() => this.PauseCluster != null;

        /// <summary>
        /// Gets and sets the property ResizeCluster. 
        /// <para>
        /// An action that runs a <c>ResizeCluster</c> API operation. 
        /// </para>
        /// </summary>
        public ResizeClusterMessage ResizeCluster { get; set; }

        /// <summary>
        /// Checks to see if the ResizeCluster property is set.
        /// </summary>
        internal bool IsSetResizeCluster() => this.ResizeCluster != null;

        /// <summary>
        /// Gets and sets the property ResumeCluster. 
        /// <para>
        /// An action that runs a <c>ResumeCluster</c> API operation. 
        /// </para>
        /// </summary>
        public ResumeClusterMessage ResumeCluster { get; set; }

        /// <summary>
        /// Checks to see if the ResumeCluster property is set.
        /// </summary>
        internal bool IsSetResumeCluster() => this.ResumeCluster != null;
    }
}
