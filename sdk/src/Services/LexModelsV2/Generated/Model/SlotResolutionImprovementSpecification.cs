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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains specifications for the assisted slot resolution feature.
    /// </summary>
    public partial class SlotResolutionImprovementSpecification
    {
        private BedrockModelSpecification _bedrockModelSpecification;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property BedrockModelSpecification. 
        /// <para>
        /// An object containing information about the Amazon Bedrock model used to assist slot
        /// resolution.
        /// </para>
        /// </summary>
        public BedrockModelSpecification BedrockModelSpecification
        {
            get { return this._bedrockModelSpecification; }
            set { this._bedrockModelSpecification = value; }
        }

        // Check to see if BedrockModelSpecification property is set
        internal bool IsSetBedrockModelSpecification()
        {
            return this._bedrockModelSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether assisted slot resolution is turned on or off.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}