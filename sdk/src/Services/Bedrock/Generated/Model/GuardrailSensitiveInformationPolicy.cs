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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
    /// Contains details about PII entities and regular expressions configured for the guardrail.
    /// </summary>
    public partial class GuardrailSensitiveInformationPolicy
    {
        private List<GuardrailPiiEntity> _piiEntities = AWSConfigs.InitializeCollections ? new List<GuardrailPiiEntity>() : null;
        private List<GuardrailRegex> _regexes = AWSConfigs.InitializeCollections ? new List<GuardrailRegex>() : null;

        /// <summary>
        /// Gets and sets the property PiiEntities. 
        /// <para>
        /// The list of PII entities configured for the guardrail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<GuardrailPiiEntity> PiiEntities
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
        /// The list of regular expressions configured for the guardrail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GuardrailRegex> Regexes
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