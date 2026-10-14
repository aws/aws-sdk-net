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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of a model compilation job.
    /// </summary>
    public partial class CompilationJobSummary
    {
        /// <summary>
        /// Gets and sets the property CompilationEndTime. 
        /// <para>
        /// The time when the model compilation job completed.
        /// </para>
        /// </summary>
        public DateTime? CompilationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the CompilationEndTime property is set.
        /// </summary>
        internal bool IsSetCompilationEndTime() => this.CompilationEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property CompilationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string CompilationJobArn { get; set; }

        /// <summary>
        /// Checks to see if the CompilationJobArn property is set.
        /// </summary>
        internal bool IsSetCompilationJobArn() => this.CompilationJobArn != null;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the model compilation job that you want a summary for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string CompilationJobName { get; set; }

        /// <summary>
        /// Checks to see if the CompilationJobName property is set.
        /// </summary>
        internal bool IsSetCompilationJobName() => this.CompilationJobName != null;

        /// <summary>
        /// Gets and sets the property CompilationJobStatus. 
        /// <para>
        /// The status of the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CompilationJobStatus CompilationJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the CompilationJobStatus property is set.
        /// </summary>
        internal bool IsSetCompilationJobStatus() => this.CompilationJobStatus != null;

        /// <summary>
        /// Gets and sets the property CompilationStartTime. 
        /// <para>
        /// The time when the model compilation job started.
        /// </para>
        /// </summary>
        public DateTime? CompilationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the CompilationStartTime property is set.
        /// </summary>
        internal bool IsSetCompilationStartTime() => this.CompilationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property CompilationTargetDevice. 
        /// <para>
        /// The type of device that the model will run on after the compilation job has completed.
        /// </para>
        /// </summary>
        public TargetDevice CompilationTargetDevice { get; set; }

        /// <summary>
        /// Checks to see if the CompilationTargetDevice property is set.
        /// </summary>
        internal bool IsSetCompilationTargetDevice() => this.CompilationTargetDevice != null;

        /// <summary>
        /// Gets and sets the property CompilationTargetPlatformAccelerator. 
        /// <para>
        /// The type of accelerator that the model will run on after the compilation job has completed.
        /// </para>
        /// </summary>
        public TargetPlatformAccelerator CompilationTargetPlatformAccelerator { get; set; }

        /// <summary>
        /// Checks to see if the CompilationTargetPlatformAccelerator property is set.
        /// </summary>
        internal bool IsSetCompilationTargetPlatformAccelerator() => this.CompilationTargetPlatformAccelerator != null;

        /// <summary>
        /// Gets and sets the property CompilationTargetPlatformArch. 
        /// <para>
        /// The type of architecture that the model will run on after the compilation job has
        /// completed.
        /// </para>
        /// </summary>
        public TargetPlatformArch CompilationTargetPlatformArch { get; set; }

        /// <summary>
        /// Checks to see if the CompilationTargetPlatformArch property is set.
        /// </summary>
        internal bool IsSetCompilationTargetPlatformArch() => this.CompilationTargetPlatformArch != null;

        /// <summary>
        /// Gets and sets the property CompilationTargetPlatformOs. 
        /// <para>
        /// The type of OS that the model will run on after the compilation job has completed.
        /// </para>
        /// </summary>
        public TargetPlatformOs CompilationTargetPlatformOs { get; set; }

        /// <summary>
        /// Checks to see if the CompilationTargetPlatformOs property is set.
        /// </summary>
        internal bool IsSetCompilationTargetPlatformOs() => this.CompilationTargetPlatformOs != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the model compilation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the model compilation job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;
    }
}
