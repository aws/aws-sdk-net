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

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Identifies a specific batch job.
    /// </summary>
    public partial class BatchJobIdentifier
    {
        /// <summary>
        /// Gets and sets the property FileBatchJobIdentifier. 
        /// <para>
        /// Specifies a file associated with a specific batch job.
        /// </para>
        /// </summary>
        public FileBatchJobIdentifier FileBatchJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FileBatchJobIdentifier property is set.
        /// </summary>
        internal bool IsSetFileBatchJobIdentifier() => this.FileBatchJobIdentifier != null;

        /// <summary>
        /// Gets and sets the property RestartBatchJobIdentifier. 
        /// <para>
        /// Specifies the required information for restart, including <c>executionId</c> and <c>JobStepRestartMarker</c>.
        /// </para>
        /// </summary>
        public RestartBatchJobIdentifier RestartBatchJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RestartBatchJobIdentifier property is set.
        /// </summary>
        internal bool IsSetRestartBatchJobIdentifier() => this.RestartBatchJobIdentifier != null;

        /// <summary>
        /// Gets and sets the property S3BatchJobIdentifier. 
        /// <para>
        /// Specifies an Amazon S3 location that identifies the batch jobs that you want to run.
        /// Use this identifier to run ad hoc batch jobs.
        /// </para>
        /// </summary>
        public S3BatchJobIdentifier S3BatchJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the S3BatchJobIdentifier property is set.
        /// </summary>
        internal bool IsSetS3BatchJobIdentifier() => this.S3BatchJobIdentifier != null;

        /// <summary>
        /// Gets and sets the property ScriptBatchJobIdentifier. 
        /// <para>
        /// A batch job identifier in which the batch job to run is identified by the script name.
        /// </para>
        /// </summary>
        public ScriptBatchJobIdentifier ScriptBatchJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ScriptBatchJobIdentifier property is set.
        /// </summary>
        internal bool IsSetScriptBatchJobIdentifier() => this.ScriptBatchJobIdentifier != null;
    }
}
