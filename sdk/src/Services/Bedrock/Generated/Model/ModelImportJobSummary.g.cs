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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Information about the import job.
    /// </summary>
    public partial class ModelImportJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time import job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when import job ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImportedModelArn. 
        /// <para>
        /// The Amazon resource Name (ARN) of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1011)]
        public string ImportedModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ImportedModelArn property is set.
        /// </summary>
        internal bool IsSetImportedModelArn() => this.ImportedModelArn != null;

        /// <summary>
        /// Gets and sets the property ImportedModelName. 
        /// <para>
        /// The name of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ImportedModelName { get; set; }

        /// <summary>
        /// Checks to see if the ImportedModelName property is set.
        /// </summary>
        internal bool IsSetImportedModelName() => this.ImportedModelName != null;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the import job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the imported job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelImportJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
