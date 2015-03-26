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
    /// Specifies how to map source attribute values to custom values when populating an <code>IndexField</code>.
    /// </summary>
    public partial class SourceDataMap
    {
        private Dictionary<string, string> _cases = new Dictionary<string, string>();
        private string _defaultValue;
        private string _sourceName;

        /// <summary>
        /// Gets and sets the property Cases. 
        /// <para>
        /// A map that translates source field values to custom values.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Cases
        {
            get { return this._cases; }
            set { this._cases = value; }
        }

        // Check to see if Cases property is set
        internal bool IsSetCases()
        {
            return this._cases != null && this._cases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value to use if the source attribute is not specified in a document. Optional.
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
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the document source field to add to this <code>IndexField</code>.
        /// </para>
        /// </summary>
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

    }
}