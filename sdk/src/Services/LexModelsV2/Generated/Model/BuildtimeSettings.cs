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
    /// Contains specifications about the Amazon Lex build time generative AI capabilities
    /// from Amazon Bedrock that you can turn on for your bot.
    /// </summary>
    public partial class BuildtimeSettings
    {
        private DescriptiveBotBuilderSpecification _descriptiveBotBuilder;
        private SampleUtteranceGenerationSpecification _sampleUtteranceGeneration;

        /// <summary>
        /// Gets and sets the property DescriptiveBotBuilder. 
        /// <para>
        /// An object containing specifications for the descriptive bot building feature.
        /// </para>
        /// </summary>
        public DescriptiveBotBuilderSpecification DescriptiveBotBuilder
        {
            get { return this._descriptiveBotBuilder; }
            set { this._descriptiveBotBuilder = value; }
        }

        // Check to see if DescriptiveBotBuilder property is set
        internal bool IsSetDescriptiveBotBuilder()
        {
            return this._descriptiveBotBuilder != null;
        }

        /// <summary>
        /// Gets and sets the property SampleUtteranceGeneration. 
        /// <para>
        /// Contains specifications for the sample utterance generation feature.
        /// </para>
        /// </summary>
        public SampleUtteranceGenerationSpecification SampleUtteranceGeneration
        {
            get { return this._sampleUtteranceGeneration; }
            set { this._sampleUtteranceGeneration = value; }
        }

        // Check to see if SampleUtteranceGeneration property is set
        internal bool IsSetSampleUtteranceGeneration()
        {
            return this._sampleUtteranceGeneration != null;
        }

    }
}