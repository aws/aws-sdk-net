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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
        private string _imageLogGroupName;
        private string _pipelineLogGroupName;

        /// <summary>
        /// Gets and sets the property ImageLogGroupName. 
        /// <para>
        /// The log group name that Image Builder uses for image creation. If not specified, the
        /// log group name defaults to <c>/aws/imagebuilder/image-name</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ImageLogGroupName
        {
            get { return this._imageLogGroupName; }
            set { this._imageLogGroupName = value; }
        }

        // Check to see if ImageLogGroupName property is set
        internal bool IsSetImageLogGroupName()
        {
            return this._imageLogGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineLogGroupName. 
        /// <para>
        /// The log group name that Image Builder uses for the log output during creation of a
        /// new pipeline. If not specified, the pipeline log group name defaults to <c>/aws/imagebuilder/pipeline/pipeline-name</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string PipelineLogGroupName
        {
            get { return this._pipelineLogGroupName; }
            set { this._pipelineLogGroupName = value; }
        }

        // Check to see if PipelineLogGroupName property is set
        internal bool IsSetPipelineLogGroupName()
        {
            return this._pipelineLogGroupName != null;
        }

    }
}