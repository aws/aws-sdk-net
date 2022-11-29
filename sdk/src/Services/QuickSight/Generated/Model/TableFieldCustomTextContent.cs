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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The custom text content (value, font configuration) for the table link content configuration.
    /// </summary>
    public partial class TableFieldCustomTextContent
    {
        private FontConfiguration _fontConfiguration;
        private string _value;

        /// <summary>
        /// Gets and sets the property FontConfiguration. 
        /// <para>
        /// The font configuration of the custom text content for the table URL link content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FontConfiguration FontConfiguration
        {
            get { return this._fontConfiguration; }
            set { this._fontConfiguration = value; }
        }

        // Check to see if FontConfiguration property is set
        internal bool IsSetFontConfiguration()
        {
            return this._fontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The string value of the custom text content for the table URL link content.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}