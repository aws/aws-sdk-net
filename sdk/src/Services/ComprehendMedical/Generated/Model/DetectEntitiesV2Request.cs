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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// Container for the parameters to the DetectEntitiesV2 operation.
    /// Inspects the clinical text for a variety of medical entities and returns specific
    /// information about them such as entity category, location, and confidence score on
    /// that information. Amazon Comprehend Medical only detects medical entities in English
    /// language texts.
    /// 
    ///  
    /// <para>
    /// The <c>DetectEntitiesV2</c> operation replaces the <a>DetectEntities</a> operation.
    /// This new action uses a different model for determining the entities in your medical
    /// text and changes the way that some entities are returned in the output. You should
    /// use the <c>DetectEntitiesV2</c> operation in all new applications.
    /// </para>
    ///  
    /// <para>
    /// The <c>DetectEntitiesV2</c> operation returns the <c>Acuity</c> and <c>Direction</c>
    /// entities as attributes instead of types. 
    /// </para>
    /// </summary>
    public partial class DetectEntitiesV2Request : AmazonComprehendMedicalRequest
    {
        private string _text;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// A UTF-8 string containing the clinical content being examined for entities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20000)]
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