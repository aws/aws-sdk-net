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
    /// Override Configuration of Audio
    /// </summary>
    public partial class AudioOverrideConfiguration
    {
        private AudioLanguageConfiguration _languageConfiguration;
        private ModalityProcessingConfiguration _modalityProcessing;
        private SensitiveDataConfiguration _sensitiveDataConfiguration;

        /// <summary>
        /// Gets and sets the property LanguageConfiguration.
        /// </summary>
        public AudioLanguageConfiguration LanguageConfiguration
        {
            get { return this._languageConfiguration; }
            set { this._languageConfiguration = value; }
        }

        // Check to see if LanguageConfiguration property is set
        internal bool IsSetLanguageConfiguration()
        {
            return this._languageConfiguration != null;
        }

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

        /// <summary>
        /// Gets and sets the property SensitiveDataConfiguration.
        /// </summary>
        public SensitiveDataConfiguration SensitiveDataConfiguration
        {
            get { return this._sensitiveDataConfiguration; }
            set { this._sensitiveDataConfiguration = value; }
        }

        // Check to see if SensitiveDataConfiguration property is set
        internal bool IsSetSensitiveDataConfiguration()
        {
            return this._sensitiveDataConfiguration != null;
        }

    }
}