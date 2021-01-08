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
    /// Container for the parameters to the InferICD10CM operation.
    /// InferICD10CM detects medical conditions as entities listed in a patient record and
    /// links those entities to normalized concept identifiers in the ICD-10-CM knowledge
    /// base from the Centers for Disease Control. Amazon Comprehend Medical only detects
    /// medical entities in English language texts.
    /// </summary>
    public partial class InferICD10CMRequest : AmazonComprehendMedicalRequest
    {
        private string _text;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The input text used for analysis. The input for InferICD10CM is a string from 1 to
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