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
    /// A Regex filter configured in a guardrail.
    /// </summary>
    public partial class GuardrailRegexFilter
    {
        private GuardrailSensitiveInformationPolicyAction _action;
        private bool? _detected;
        private string _match;
        private string _name;
        private string _regex;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The region filter action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailSensitiveInformationPolicyAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Detected. 
        /// <para>
        /// Indicates whether custom regex entities that breach the guardrail configuration are
        /// detected.
        /// </para>
        /// </summary>
        public bool? Detected
        {
            get { return this._detected; }
            set { this._detected = value; }
        }

        // Check to see if Detected property is set
        internal bool IsSetDetected()
        {
            return this._detected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// The regesx filter match.
        /// </para>
        /// </summary>
        public string Match
        {
            get { return this._match; }
            set { this._match = value; }
        }

        // Check to see if Match property is set
        internal bool IsSetMatch()
        {
            return this._match != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The regex filter name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The regex query.
        /// </para>
        /// </summary>
        public string Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }

    }
}