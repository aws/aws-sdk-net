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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The assessment for a Personally Identifiable Information (PII) policy.
    /// </summary>
    public partial class GuardrailSensitiveInformationPolicyAssessment
    {
        private List<GuardrailPiiEntityFilter> _piiEntities = AWSConfigs.InitializeCollections ? new List<GuardrailPiiEntityFilter>() : null;
        private List<GuardrailRegexFilter> _regexes = AWSConfigs.InitializeCollections ? new List<GuardrailRegexFilter>() : null;

        /// <summary>
        /// Gets and sets the property PiiEntities. 
        /// <para>
        /// The PII entities in the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GuardrailPiiEntityFilter> PiiEntities
        {
            get { return this._piiEntities; }
            set { this._piiEntities = value; }
        }

        // Check to see if PiiEntities property is set
        internal bool IsSetPiiEntities()
        {
            return this._piiEntities != null && (this._piiEntities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Regexes. 
        /// <para>
        /// The regex queries in the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GuardrailRegexFilter> Regexes
        {
            get { return this._regexes; }
            set { this._regexes = value; }
        }

        // Check to see if Regexes property is set
        internal bool IsSetRegexes()
        {
            return this._regexes != null && (this._regexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}