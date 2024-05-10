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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// For a SQL-based Kinesis Data Analytics application, provides the configuration information
    /// about an input processor. Currently, the only input processor available is <a href="https://docs.aws.amazon.com/lambda/">Amazon
    /// Lambda</a>.
    /// </summary>
    public partial class InputProcessingConfigurationDescription
    {
        private InputLambdaProcessorDescription _inputLambdaProcessorDescription;

        /// <summary>
        /// Gets and sets the property InputLambdaProcessorDescription. 
        /// <para>
        /// Provides configuration information about the associated <a>InputLambdaProcessorDescription</a>
        /// 
        /// </para>
        /// </summary>
        public InputLambdaProcessorDescription InputLambdaProcessorDescription
        {
            get { return this._inputLambdaProcessorDescription; }
            set { this._inputLambdaProcessorDescription = value; }
        }

        // Check to see if InputLambdaProcessorDescription property is set
        internal bool IsSetInputLambdaProcessorDescription()
        {
            return this._inputLambdaProcessorDescription != null;
        }

    }
}