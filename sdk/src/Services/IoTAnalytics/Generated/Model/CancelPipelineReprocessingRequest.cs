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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the CancelPipelineReprocessing operation.
    /// Cancels the reprocessing of data through the pipeline.
    /// </summary>
    public partial class CancelPipelineReprocessingRequest : AmazonIoTAnalyticsRequest
    {
        private string _pipelineName;
        private string _reprocessingId;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of pipeline for which data reprocessing is canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property ReprocessingId. 
        /// <para>
        /// The ID of the reprocessing task (returned by <c>StartPipelineReprocessing</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReprocessingId
        {
            get { return this._reprocessingId; }
            set { this._reprocessingId = value; }
        }

        // Check to see if ReprocessingId property is set
        internal bool IsSetReprocessingId()
        {
            return this._reprocessingId != null;
        }

    }
}