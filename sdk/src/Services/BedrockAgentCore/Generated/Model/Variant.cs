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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A variant in an A/B test, representing either the control (C) or treatment (T1) configuration.
    /// </summary>
    public partial class Variant
    {
        private string _name;
        private VariantConfiguration _variantConfiguration;
        private int? _weight;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the variant. Must be <c>C</c> for control or <c>T1</c> for treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
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
        /// Gets and sets the property VariantConfiguration. 
        /// <para>
        /// The configuration for this variant, including the configuration bundle or target reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VariantConfiguration VariantConfiguration
        {
            get { return this._variantConfiguration; }
            set { this._variantConfiguration = value; }
        }

        // Check to see if VariantConfiguration property is set
        internal bool IsSetVariantConfiguration()
        {
            return this._variantConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The percentage of traffic to route to this variant. Weights across all variants must
        /// sum to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public int? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}