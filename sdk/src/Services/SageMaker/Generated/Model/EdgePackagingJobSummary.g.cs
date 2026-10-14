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
    /// Summary of edge packaging job.
    /// </summary>
    public partial class EdgePackagingJobSummary
    {
        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the SageMaker Neo compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string CompilationJobName { get; set; }

        /// <summary>
        /// Checks to see if the CompilationJobName property is set.
        /// </summary>
        internal bool IsSetCompilationJobName() => this.CompilationJobName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of when the job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EdgePackagingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the edge packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EdgePackagingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the EdgePackagingJobArn property is set.
        /// </summary>
        internal bool IsSetEdgePackagingJobArn() => this.EdgePackagingJobArn != null;

        /// <summary>
        /// Gets and sets the property EdgePackagingJobName. 
        /// <para>
        /// The name of the edge packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string EdgePackagingJobName { get; set; }

        /// <summary>
        /// Checks to see if the EdgePackagingJobName property is set.
        /// </summary>
        internal bool IsSetEdgePackagingJobName() => this.EdgePackagingJobName != null;

        /// <summary>
        /// Gets and sets the property EdgePackagingJobStatus. 
        /// <para>
        /// The status of the edge packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EdgePackagingJobStatus EdgePackagingJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the EdgePackagingJobStatus property is set.
        /// </summary>
        internal bool IsSetEdgePackagingJobStatus() => this.EdgePackagingJobStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp of when the edge packaging job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersion property is set.
        /// </summary>
        internal bool IsSetModelVersion() => this.ModelVersion != null;
    }
}
