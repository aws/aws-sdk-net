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

namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Override Configuration of Video
    /// </summary>
    public partial class VideoOverrideConfiguration
    {
        /// <summary>
        /// Gets and sets the property ModalityProcessing.
        /// </summary>
        public ModalityProcessingConfiguration ModalityProcessing { get; set; }

        /// <summary>
        /// Checks to see if the ModalityProcessing property is set.
        /// </summary>
        internal bool IsSetModalityProcessing() => this.ModalityProcessing != null;

        /// <summary>
        /// Gets and sets the property SensitiveDataConfiguration.
        /// </summary>
        public SensitiveDataConfiguration SensitiveDataConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveDataConfiguration property is set.
        /// </summary>
        internal bool IsSetSensitiveDataConfiguration() => this.SensitiveDataConfiguration != null;
    }
}
