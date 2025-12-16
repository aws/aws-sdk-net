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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Configures the command to treat the <c>payloadTemplate</c> as a JSON document for
    /// preprocessing. This preprocessor substitutes placeholders with parameter values to
    /// generate the command execution request payload.
    /// </summary>
    public partial class AwsJsonSubstitutionCommandPreprocessorConfig
    {
        private OutputFormat _outputFormat;

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// Converts the command preprocessor result to the format defined by this parameter,
        /// before sending it to the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

    }
}