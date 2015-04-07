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
    /// Container for the parameters to the DeactivatePipeline operation.
    /// Deactivates the specified running pipeline. The pipeline is set to the <code>DEACTIVATING</code>
    /// state until the deactivation process completes.
    /// 
    ///  
    /// <para>
    /// To resume a deactivated pipeline, use <a>ActivatePipeline</a>. By default, the pipeline
    /// resumes from the last completed execution. Optionally, you can specify the date and
    /// time to resume the pipeline.
    /// </para>
    /// </summary>
    public partial class DeactivatePipelineRequest : AmazonDataPipelineRequest
    {
        private bool? _cancelActive;
        private string _pipelineId;

        /// <summary>
        /// Gets and sets the property CancelActive. 
        /// <para>
        /// Indicates whether to cancel any running objects. The default is true, which sets the
        /// state of any running objects to <code>CANCELED</code>. If this value is false, the
        /// pipeline is deactivated after all running objects finish.
        /// </para>
        /// </summary>
        public bool CancelActive
        {
            get { return this._cancelActive.GetValueOrDefault(); }
            set { this._cancelActive = value; }
        }

        // Check to see if CancelActive property is set
        internal bool IsSetCancelActive()
        {
            return this._cancelActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The ID of the pipeline.
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

    }
}