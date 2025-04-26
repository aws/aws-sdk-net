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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
        private ModalityProcessingConfiguration _modalityProcessing;

        /// <summary>
        /// Gets and sets the property ModalityProcessing.
        /// </summary>
        public ModalityProcessingConfiguration ModalityProcessing
        {
            get { return this._modalityProcessing; }
            set { this._modalityProcessing = value; }
        }

        // Check to see if ModalityProcessing property is set
        internal bool IsSetModalityProcessing()
        {
            return this._modalityProcessing != null;
        }

    }
}