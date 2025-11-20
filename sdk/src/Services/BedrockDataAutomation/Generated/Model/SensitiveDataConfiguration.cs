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
    /// Configuration for sensitive data detection and redaction
    /// </summary>
    public partial class SensitiveDataConfiguration
    {
        private SensitiveDataDetectionMode _detectionMode;
        private List<string> _detectionScope = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PIIEntitiesConfiguration _piiEntitiesConfiguration;

        /// <summary>
        /// Gets and sets the property DetectionMode. 
        /// <para>
        /// Mode for sensitive data detection
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SensitiveDataDetectionMode DetectionMode
        {
            get { return this._detectionMode; }
            set { this._detectionMode = value; }
        }

        // Check to see if DetectionMode property is set
        internal bool IsSetDetectionMode()
        {
            return this._detectionMode != null;
        }

        /// <summary>
        /// Gets and sets the property DetectionScope. 
        /// <para>
        /// Scope of detection - what types of sensitive data to detect
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> DetectionScope
        {
            get { return this._detectionScope; }
            set { this._detectionScope = value; }
        }

        // Check to see if DetectionScope property is set
        internal bool IsSetDetectionScope()
        {
            return this._detectionScope != null && (this._detectionScope.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PiiEntitiesConfiguration. 
        /// <para>
        /// Configuration for PII entities detection and redaction
        /// </para>
        /// </summary>
        public PIIEntitiesConfiguration PiiEntitiesConfiguration
        {
            get { return this._piiEntitiesConfiguration; }
            set { this._piiEntitiesConfiguration = value; }
        }

        // Check to see if PiiEntitiesConfiguration property is set
        internal bool IsSetPiiEntitiesConfiguration()
        {
            return this._piiEntitiesConfiguration != null;
        }

    }
}