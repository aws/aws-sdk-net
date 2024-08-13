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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for suggested query spell corrections.
    /// 
    ///  
    /// <para>
    /// Suggested spell corrections are based on words that appear in your indexed documents
    /// and how closely a corrected word matches a misspelled word.
    /// </para>
    ///  
    /// <para>
    /// This feature is designed with certain defaults or limits. For information on the current
    /// limits and how to request more support for some limits, see the <a href="https://docs.aws.amazon.com/kendra/latest/dg/query-spell-check.html">Spell
    /// Checker documentation</a>.
    /// </para>
    /// </summary>
    public partial class SpellCorrectionConfiguration
    {
        private bool? _includeQuerySpellCheckSuggestions;

        /// <summary>
        /// Gets and sets the property IncludeQuerySpellCheckSuggestions. 
        /// <para>
        ///  <c>TRUE</c> to suggest spell corrections for queries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IncludeQuerySpellCheckSuggestions
        {
            get { return this._includeQuerySpellCheckSuggestions; }
            set { this._includeQuerySpellCheckSuggestions = value; }
        }

        // Check to see if IncludeQuerySpellCheckSuggestions property is set
        internal bool IsSetIncludeQuerySpellCheckSuggestions()
        {
            return this._includeQuerySpellCheckSuggestions.HasValue; 
        }

    }
}