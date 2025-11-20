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
    /// Configuration for PII entities detection and redaction
    /// </summary>
    public partial class PIIEntitiesConfiguration
    {
        private List<string> _piiEntityTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PIIRedactionMaskMode _redactionMaskMode;

        /// <summary>
        /// Gets and sets the property PiiEntityTypes. 
        /// <para>
        /// Types of PII entities to detect
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<string> PiiEntityTypes
        {
            get { return this._piiEntityTypes; }
            set { this._piiEntityTypes = value; }
        }

        // Check to see if PiiEntityTypes property is set
        internal bool IsSetPiiEntityTypes()
        {
            return this._piiEntityTypes != null && (this._piiEntityTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RedactionMaskMode. 
        /// <para>
        /// Mode for redacting detected PII
        /// </para>
        /// </summary>
        public PIIRedactionMaskMode RedactionMaskMode
        {
            get { return this._redactionMaskMode; }
            set { this._redactionMaskMode = value; }
        }

        // Check to see if RedactionMaskMode property is set
        internal bool IsSetRedactionMaskMode()
        {
            return this._redactionMaskMode != null;
        }

    }
}