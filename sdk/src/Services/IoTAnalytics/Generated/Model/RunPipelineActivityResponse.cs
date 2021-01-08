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

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// This is the response object from the RunPipelineActivity operation.
    /// </summary>
    public partial class RunPipelineActivityResponse : AmazonWebServiceResponse
    {
        private string _logResult;
        private List<MemoryStream> _payloads = new List<MemoryStream>();

        /// <summary>
        /// Gets and sets the property LogResult. 
        /// <para>
        /// In case the pipeline activity fails, the log message that is generated.
        /// </para>
        /// </summary>
        public string LogResult
        {
            get { return this._logResult; }
            set { this._logResult = value; }
        }

        // Check to see if LogResult property is set
        internal bool IsSetLogResult()
        {
            return this._logResult != null;
        }

        /// <summary>
        /// Gets and sets the property Payloads. 
        /// <para>
        /// The enriched or transformed sample message payloads as base64-encoded strings. (The
        /// results of running the pipeline activity on each input sample message payload, encoded
        /// in base64.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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

    }
}