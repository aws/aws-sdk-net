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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes updates to an <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_InputProcessingConfiguration.html">InputProcessingConfiguration</a>.
    /// </summary>
    public partial class InputProcessingConfigurationUpdate
    {
        private InputLambdaProcessorUpdate _inputLambdaProcessorUpdate;

        /// <summary>
        /// Gets and sets the property InputLambdaProcessorUpdate. 
        /// <para>
        /// Provides update information for an <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_InputLambdaProcessor.html">InputLambdaProcessor</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputLambdaProcessorUpdate InputLambdaProcessorUpdate
        {
            get { return this._inputLambdaProcessorUpdate; }
            set { this._inputLambdaProcessorUpdate = value; }
        }

        // Check to see if InputLambdaProcessorUpdate property is set
        internal bool IsSetInputLambdaProcessorUpdate()
        {
            return this._inputLambdaProcessorUpdate != null;
        }

    }
}