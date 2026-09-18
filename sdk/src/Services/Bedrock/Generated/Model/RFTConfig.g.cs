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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Configuration settings for reinforcement fine-tuning (RFT), including grader configuration
    /// and training hyperparameters.
    /// </summary>
    public partial class RFTConfig
    {
        /// <summary>
        /// Gets and sets the property GraderConfig. 
        /// <para>
        ///  Configuration for the grader that evaluates model responses and provides reward signals
        /// during RFT training. 
        /// </para>
        /// </summary>
        public GraderConfig GraderConfig { get; set; }

        /// <summary>
        /// Checks to see if the GraderConfig property is set.
        /// </summary>
        internal bool IsSetGraderConfig() => this.GraderConfig != null;

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        ///  Hyperparameters that control the reinforcement fine-tuning training process, including
        /// learning rate, batch size, and epoch count. 
        /// </para>
        /// </summary>
        public RFTHyperParameters HyperParameters { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameters property is set.
        /// </summary>
        internal bool IsSetHyperParameters() => this.HyperParameters != null;
    }
}
