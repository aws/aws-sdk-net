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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration that specifies where evaluation results should be written for monitoring
    /// and analysis.
    /// </summary>
    public partial class OutputConfig
    {
        private CloudWatchOutputConfig _cloudWatchConfig;

        /// <summary>
        /// Gets and sets the property CloudWatchConfig. 
        /// <para>
        ///  The CloudWatch configuration for writing evaluation results to CloudWatch logs with
        /// embedded metric format. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CloudWatchOutputConfig CloudWatchConfig
        {
            get { return this._cloudWatchConfig; }
            set { this._cloudWatchConfig = value; }
        }

        // Check to see if CloudWatchConfig property is set
        internal bool IsSetCloudWatchConfig()
        {
            return this._cloudWatchConfig != null;
        }

    }
}