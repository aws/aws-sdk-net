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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The filter configuration details for the AI Guardrail's contextual grounding filter.
    /// </summary>
    public partial class GuardrailContextualGroundingFilterConfig
    {
        private double? _threshold;
        private GuardrailContextualGroundingFilterType _type;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The threshold details for the AI Guardrail's contextual grounding filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0)]
        public double? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The filter type for the AI Guardrail's contextual grounding filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public GuardrailContextualGroundingFilterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}