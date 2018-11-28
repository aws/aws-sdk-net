/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// The custom terminology applied to the input text by Amazon Translate for the translated
    /// text response. This is optional in the response and will only be present if you specified
    /// terminology input in the request. Currently, only one terminology can be applied per
    /// TranslateText request.
    /// </summary>
    public partial class AppliedTerminology
    {
        private string _name;
        private List<Term> _terms = new List<Term>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom terminology applied to the input text by Amazon Translate for
        /// the translated text response.
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
        /// Gets and sets the property Terms. 
        /// <para>
        /// The specific terms of the custom terminology applied to the input text by Amazon Translate
        /// for the translated text response. A maximum of 250 terms will be returned, and the
        /// specific terms applied will be the first 250 terms in the source text. 
        /// </para>
        /// </summary>
        public List<Term> Terms
        {
            get { return this._terms; }
            set { this._terms = value; }
        }

        // Check to see if Terms property is set
        internal bool IsSetTerms()
        {
            return this._terms != null && this._terms.Count > 0; 
        }

    }
}