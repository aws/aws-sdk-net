/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the GetPipelineDefinition operation.
    /// Returns the definition of the specified pipeline. You can call <a>GetPipelineDefinition</a>
    /// to retrieve the pipeline definition you provided using <a>PutPipelineDefinition</a>.
    /// </summary>
    public partial class GetPipelineDefinitionRequest : AmazonDataPipelineRequest
    {
        private string _pipelineId;
        private string _version;

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The identifier of the pipeline.
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the pipeline definition to retrieve. This parameter accepts the values
        /// <code>latest</code> (default) and <code>active</code>. Where <code>latest</code> indicates
        /// the last definition saved to the pipeline and <code>active</code> indicates the last
        /// definition of the pipeline that was activated.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}