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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the processor parameter.
    /// </summary>
    public partial class ProcessorParameter
    {
        private ProcessorParameterName _parameterName;
        private string _parameterValue;

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter. Currently the following default values are supported: 3
        /// for <code>NumberOfRetries</code> and 60 for the <code>BufferIntervalInSeconds</code>.
        /// The <code>BufferSizeInMBs</code> ranges between 0.2 MB and up to 3MB. The default
        /// buffering hint is 1MB for all destinations, except Splunk. For Splunk, the default
        /// buffering hint is 256 KB. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessorParameterName ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// The parameter value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5120)]
        public string ParameterValue
        {
            get { return this._parameterValue; }
            set { this._parameterValue = value; }
        }

        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this._parameterValue != null;
        }

    }
}