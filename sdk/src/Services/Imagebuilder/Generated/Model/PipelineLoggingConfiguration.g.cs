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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// The logging configuration that's defined for pipeline execution.
    /// </summary>
    public partial class PipelineLoggingConfiguration
    {
        /// <summary>
        /// Gets and sets the property ImageLogGroupName. 
        /// <para>
        /// Specifies the CloudWatch Logs log group name for image build logs. The log group name
        /// can contain alphanumeric characters, hyphens, underscores, forward slashes, and periods,
        /// up to 512 characters. Log group names not starting with <c>/aws/imagebuilder/</c>
        /// require an <c>executionRole</c> with CloudWatch Logs write permissions. If not specified,
        /// defaults to <c>/aws/imagebuilder/image-name</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ImageLogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ImageLogGroupName property is set.
        /// </summary>
        internal bool IsSetImageLogGroupName() => this.ImageLogGroupName != null;

        /// <summary>
        /// Gets and sets the property PipelineLogGroupName. 
        /// <para>
        /// Specifies the CloudWatch Logs log group name for pipeline execution logs. The log
        /// group name can contain alphanumeric characters, hyphens, underscores, forward slashes,
        /// and periods, up to 512 characters. Log group names not starting with <c>/aws/imagebuilder/</c>
        /// require an <c>executionRole</c> with CloudWatch Logs write permissions. If not specified,
        /// defaults to <c>/aws/imagebuilder/pipeline/pipeline-name</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string PipelineLogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineLogGroupName property is set.
        /// </summary>
        internal bool IsSetPipelineLogGroupName() => this.PipelineLogGroupName != null;
    }
}
