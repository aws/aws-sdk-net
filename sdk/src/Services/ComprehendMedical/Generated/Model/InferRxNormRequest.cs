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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// Container for the parameters to the InferRxNorm operation.
    /// InferRxNorm detects medications as entities listed in a patient record and links to
    /// the normalized concept identifiers in the RxNorm database from the National Library
    /// of Medicine. Amazon Comprehend Medical only detects medical entities in English language
    /// texts.
    /// </summary>
    public partial class InferRxNormRequest : AmazonComprehendMedicalRequest
    {
        private string _text;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The input text used for analysis. The input for InferRxNorm is a string from 1 to
        /// 10000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}