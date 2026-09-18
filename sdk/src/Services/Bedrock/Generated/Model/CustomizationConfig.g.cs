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
    /// A model customization configuration
    /// </summary>
    public partial class CustomizationConfig
    {
        /// <summary>
        /// Gets and sets the property DistillationConfig. 
        /// <para>
        /// The Distillation configuration for the custom model.
        /// </para>
        /// </summary>
        public DistillationConfig DistillationConfig { get; set; }

        /// <summary>
        /// Checks to see if the DistillationConfig property is set.
        /// </summary>
        internal bool IsSetDistillationConfig() => this.DistillationConfig != null;

        /// <summary>
        /// Gets and sets the property RftConfig. 
        /// <para>
        ///  Configuration settings for reinforcement fine-tuning (RFT) model customization, including
        /// grader configuration and hyperparameters. 
        /// </para>
        /// </summary>
        public RFTConfig RftConfig { get; set; }

        /// <summary>
        /// Checks to see if the RftConfig property is set.
        /// </summary>
        internal bool IsSetRftConfig() => this.RftConfig != null;
    }
}
