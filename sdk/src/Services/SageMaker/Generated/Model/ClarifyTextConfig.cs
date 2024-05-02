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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A parameter used to configure the SageMaker Clarify explainer to treat text features
    /// as text so that explanations are provided for individual units of text. Required only
    /// for natural language processing (NLP) explainability.
    /// </summary>
    public partial class ClarifyTextConfig
    {
        private ClarifyTextGranularity _granularity;
        private ClarifyTextLanguage _language;

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The unit of granularity for the analysis of text features. For example, if the unit
        /// is <c>'token'</c>, then each token (like a word in English) of the text is treated
        /// as a feature. SHAP values are computed for each unit/feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClarifyTextGranularity Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// Specifies the language of the text features in <a href=" https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO
        /// 639-1</a> or <a href="https://en.wikipedia.org/wiki/ISO_639-3">ISO 639-3</a> code
        /// of a supported language. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For a mix of multiple languages, use code <c>'xx'</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClarifyTextLanguage Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

    }
}