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
    /// Container for the parameters to the DescribePipelines operation.
    /// Retrieves metadata about one or more pipelines. The information retrieved includes
    /// the name of the pipeline, the pipeline identifier, its current state, and the user
    /// account that owns the pipeline. Using account credentials, you can retrieve metadata
    /// about pipelines that you or your IAM users have created. If you are using an IAM user
    /// account, you can retrieve metadata about only those pipelines for which you have read
    /// permissions.
    /// 
    ///  
    /// <para>
    /// To retrieve the full pipeline definition instead of metadata about the pipeline, call
    /// <a>GetPipelineDefinition</a>.
    /// </para>
    /// </summary>
    public partial class DescribePipelinesRequest : AmazonDataPipelineRequest
    {
        private List<string> _pipelineIds = new List<string>();

        /// <summary>
        /// Gets and sets the property PipelineIds. 
        /// <para>
        /// The IDs of the pipelines to describe. You can pass as many as 25 identifiers in a
        /// single call. To obtain pipeline IDs, call <a>ListPipelines</a>.
        /// </para>
        /// </summary>
        public List<string> PipelineIds
        {
            get { return this._pipelineIds; }
            set { this._pipelineIds = value; }
        }

        // Check to see if PipelineIds property is set
        internal bool IsSetPipelineIds()
        {
            return this._pipelineIds != null && this._pipelineIds.Count > 0; 
        }

    }
}