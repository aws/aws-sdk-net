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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Container for the parameters to the UpdatePipelineVersion operation.
    /// Updates a pipeline version.
    /// </summary>
    public partial class UpdatePipelineVersionRequest : AmazonSageMakerRequest
    {
        private string _pipelineArn;
        private string _pipelineVersionDescription;
        private string _pipelineVersionDisplayName;
        private long? _pipelineVersionId;

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string PipelineArn
        {
            get { return this._pipelineArn; }
            set { this._pipelineArn = value; }
        }

        // Check to see if PipelineArn property is set
        internal bool IsSetPipelineArn()
        {
            return this._pipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineVersionDescription. 
        /// <para>
        /// The description of the pipeline version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string PipelineVersionDescription
        {
            get { return this._pipelineVersionDescription; }
            set { this._pipelineVersionDescription = value; }
        }

        // Check to see if PipelineVersionDescription property is set
        internal bool IsSetPipelineVersionDescription()
        {
            return this._pipelineVersionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineVersionDisplayName. 
        /// <para>
        /// The display name of the pipeline version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=82)]
        public string PipelineVersionDisplayName
        {
            get { return this._pipelineVersionDisplayName; }
            set { this._pipelineVersionDisplayName = value; }
        }

        // Check to see if PipelineVersionDisplayName property is set
        internal bool IsSetPipelineVersionDisplayName()
        {
            return this._pipelineVersionDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineVersionId. 
        /// <para>
        /// The pipeline version ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long? PipelineVersionId
        {
            get { return this._pipelineVersionId; }
            set { this._pipelineVersionId = value; }
        }

        // Check to see if PipelineVersionId property is set
        internal bool IsSetPipelineVersionId()
        {
            return this._pipelineVersionId.HasValue; 
        }

    }
}