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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// Options that define a text field in the search index.
    /// </summary>
    public partial class TextOptions
    {
        private string _defaultValue;
        private bool? _facetEnabled;
        private bool? _resultEnabled;
        private string _textProcessor;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for a text field. Optional.
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property FacetEnabled. 
        /// <para>
        /// Specifies whether facets are enabled for this field. Default: False.
        /// </para>
        /// </summary>
        public bool FacetEnabled
        {
            get { return this._facetEnabled.GetValueOrDefault(); }
            set { this._facetEnabled = value; }
        }

        // Check to see if FacetEnabled property is set
        internal bool IsSetFacetEnabled()
        {
            return this._facetEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultEnabled. 
        /// <para>
        /// Specifies whether values of this field can be returned in search results and used
        /// for ranking. Default: False.
        /// </para>
        /// </summary>
        public bool ResultEnabled
        {
            get { return this._resultEnabled.GetValueOrDefault(); }
            set { this._resultEnabled = value; }
        }

        // Check to see if ResultEnabled property is set
        internal bool IsSetResultEnabled()
        {
            return this._resultEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TextProcessor. 
        /// <para>
        /// The text processor to apply to this field. Optional. Possible values:
        /// </para>
        ///  <ul> <li> <code>cs_text_no_stemming</code>: turns off stemming for the field.</li>
        /// </ul> 
        /// <para>
        /// Default: none
        /// </para>
        /// </summary>
        public string TextProcessor
        {
            get { return this._textProcessor; }
            set { this._textProcessor = value; }
        }

        // Check to see if TextProcessor property is set
        internal bool IsSetTextProcessor()
        {
            return this._textProcessor != null;
        }

    }
}