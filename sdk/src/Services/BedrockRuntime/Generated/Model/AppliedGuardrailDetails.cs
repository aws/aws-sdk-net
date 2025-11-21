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
    /// Details about the specific guardrail that was applied during this assessment, including
    /// its identifier, version, ARN, origin, and ownership information.
    /// </summary>
    public partial class AppliedGuardrailDetails
    {
        private string _guardrailArn;
        private string _guardrailId;
        private List<string> _guardrailOrigin = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GuardrailOwnership _guardrailOwnership;
        private string _guardrailVersion;

        /// <summary>
        /// Gets and sets the property GuardrailArn. 
        /// <para>
        /// The ARN of the guardrail that was applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string GuardrailArn
        {
            get { return this._guardrailArn; }
            set { this._guardrailArn = value; }
        }

        // Check to see if GuardrailArn property is set
        internal bool IsSetGuardrailArn()
        {
            return this._guardrailArn != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// The unique ID of the guardrail that was applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string GuardrailId
        {
            get { return this._guardrailId; }
            set { this._guardrailId = value; }
        }

        // Check to see if GuardrailId property is set
        internal bool IsSetGuardrailId()
        {
            return this._guardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailOrigin. 
        /// <para>
        /// The origin of how the guardrail was applied. This can be either requested at the API
        /// level or enforced at the account or organization level as a default guardrail.
        /// </para>
        /// </summary>
        public List<string> GuardrailOrigin
        {
            get { return this._guardrailOrigin; }
            set { this._guardrailOrigin = value; }
        }

        // Check to see if GuardrailOrigin property is set
        internal bool IsSetGuardrailOrigin()
        {
            return this._guardrailOrigin != null && (this._guardrailOrigin.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GuardrailOwnership. 
        /// <para>
        /// The ownership type of the guardrail, indicating whether it is owned by the requesting
        /// account or is a cross-account guardrail shared from another AWS account.
        /// </para>
        /// </summary>
        public GuardrailOwnership GuardrailOwnership
        {
            get { return this._guardrailOwnership; }
            set { this._guardrailOwnership = value; }
        }

        // Check to see if GuardrailOwnership property is set
        internal bool IsSetGuardrailOwnership()
        {
            return this._guardrailOwnership != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// The version of the guardrail that was applied.
        /// </para>
        /// </summary>
        public string GuardrailVersion
        {
            get { return this._guardrailVersion; }
            set { this._guardrailVersion = value; }
        }

        // Check to see if GuardrailVersion property is set
        internal bool IsSetGuardrailVersion()
        {
            return this._guardrailVersion != null;
        }

    }
}