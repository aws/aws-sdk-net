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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the LocalizeText operation.
    /// Translates a textual identifier into a user-readable text in a specified locale.
    /// </summary>
    public partial class LocalizeTextRequest : AmazonInspectorRequest
    {
        private string _locale;
        private List<LocalizedText> _localizedTexts = new List<LocalizedText>();

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale that you want to translate a textual identifier into.
        /// </para>
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property LocalizedTexts. 
        /// <para>
        /// A list of textual identifiers.
        /// </para>
        /// </summary>
        public List<LocalizedText> LocalizedTexts
        {
            get { return this._localizedTexts; }
            set { this._localizedTexts = value; }
        }

        // Check to see if LocalizedTexts property is set
        internal bool IsSetLocalizedTexts()
        {
            return this._localizedTexts != null && this._localizedTexts.Count > 0; 
        }

    }
}