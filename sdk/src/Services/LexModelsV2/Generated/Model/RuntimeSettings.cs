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
    /// Contains specifications about the Amazon Lex runtime generative AI capabilities from
    /// Amazon Bedrock that you can turn on for your bot.
    /// </summary>
    public partial class RuntimeSettings
    {
        private NluImprovementSpecification _nluImprovement;
        private SlotResolutionImprovementSpecification _slotResolutionImprovement;

        /// <summary>
        /// Gets and sets the property NluImprovement. 
        /// <para>
        /// An object containing specifications for the assisted nlu feature.
        /// </para>
        /// </summary>
        public NluImprovementSpecification NluImprovement
        {
            get { return this._nluImprovement; }
            set { this._nluImprovement = value; }
        }

        // Check to see if NluImprovement property is set
        internal bool IsSetNluImprovement()
        {
            return this._nluImprovement != null;
        }

        /// <summary>
        /// Gets and sets the property SlotResolutionImprovement. 
        /// <para>
        /// An object containing specifications for the assisted slot resolution feature.
        /// </para>
        /// </summary>
        public SlotResolutionImprovementSpecification SlotResolutionImprovement
        {
            get { return this._slotResolutionImprovement; }
            set { this._slotResolutionImprovement = value; }
        }

        // Check to see if SlotResolutionImprovement property is set
        internal bool IsSetSlotResolutionImprovement()
        {
            return this._slotResolutionImprovement != null;
        }

    }
}