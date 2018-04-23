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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the RunPipelineActivity operation.
    /// Simulates the results of running a pipeline activity on a message payload.
    /// </summary>
    public partial class RunPipelineActivityRequest : AmazonIoTAnalyticsRequest
    {
        private List<MemoryStream> _payloads = new List<MemoryStream>();
        private PipelineActivity _pipelineActivity;

        /// <summary>
        /// Gets and sets the property Payloads. 
        /// <para>
        /// The sample message payloads on which the pipeline activity is run.
        /// </para>
        /// </summary>
        public List<MemoryStream> Payloads
        {
            get { return this._payloads; }
            set { this._payloads = value; }
        }

        // Check to see if Payloads property is set
        internal bool IsSetPayloads()
        {
            return this._payloads != null && this._payloads.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PipelineActivity. 
        /// <para>
        /// The pipeline activity that is run. This must not be a 'channel' activity or a 'datastore'
        /// activity because these activities are used in a pipeline only to load the original
        /// message and to store the (possibly) transformed message. If a 'lambda' activity is
        /// specified, only short-running Lambda functions (those with a timeout of less than
        /// 30 seconds or less) can be used.
        /// </para>
        /// </summary>
        public PipelineActivity PipelineActivity
        {
            get { return this._pipelineActivity; }
            set { this._pipelineActivity = value; }
        }

        // Check to see if PipelineActivity property is set
        internal bool IsSetPipelineActivity()
        {
            return this._pipelineActivity != null;
        }

    }
}