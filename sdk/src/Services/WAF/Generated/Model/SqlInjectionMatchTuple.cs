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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Specifies the part of a web request that you want AWS WAF to inspect for snippets
    /// of malicious SQL code and, if you want AWS WAF to inspect a header, the name of the
    /// header.
    /// </summary>
    public partial class SqlInjectionMatchTuple
    {
        private FieldToMatch _fieldToMatch;
        private TextTransformation _textTransformation;

        /// <summary>
        /// Gets and sets the property FieldToMatch.
        /// </summary>
        public FieldToMatch FieldToMatch
        {
            get { return this._fieldToMatch; }
            set { this._fieldToMatch = value; }
        }

        // Check to see if FieldToMatch property is set
        internal bool IsSetFieldToMatch()
        {
            return this._fieldToMatch != null;
        }

        /// <summary>
        /// Gets and sets the property TextTransformation. 
        /// <para>
        /// Text transformations eliminate some of the unusual formatting that attackers use in
        /// web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS
        /// WAF performs the transformation on <code>TargetString</code> before inspecting a request
        /// for a match.
        /// </para>
        ///  
        /// <para>
        /// <b>CMD_LINE</b>
        /// </para>
        ///  
        /// <para>
        /// When you're concerned that attackers are injecting an operating system commandline
        /// command and using unusual formatting to disguise some or all of the command, use this
        /// option to perform the following transformations:
        /// </para>
        ///  <ul> <li>Delete the following characters: \ " ' ^</li> <li>Delete spaces before the
        /// following characters: / (</li> <li>Replace the following characters with a space:
        /// , ;</li> <li>Replace multiple spaces with one space</li> <li>Convert uppercase letters
        /// (A-Z) to lowercase (a-z)</li> </ul> 
        /// <para>
        /// <b>COMPRESS_WHITE_SPACE</b>
        /// </para>
        ///  
        /// <para>
        /// Use this option to replace the following characters with a space character (decimal
        /// 32):
        /// </para>
        ///  <ul> <li>\f, formfeed, decimal 12</li> <li>\t, tab, decimal 9</li> <li>\n, newline,
        /// decimal 10</li> <li>\r, carriage return, decimal 13</li> <li>\v, vertical tab, decimal
        /// 11</li> <li>non-breaking space, decimal 160</li> </ul> 
        /// <para>
        /// <code>COMPRESS_WHITE_SPACE</code> also replaces multiple spaces with one space.
        /// </para>
        ///  
        /// <para>
        /// <b>HTML_ENTITY_DECODE</b>
        /// </para>
        ///  
        /// <para>
        /// Use this option to replace HTML-encoded characters with unencoded characters. <code>HTML_ENTITY_DECODE</code>
        /// performs the following operations:
        /// </para>
        ///  <ul> <li>Replaces <code>(ampersand)quot;</code> with <code>"</code> </li> <li>Replaces
        /// <code>(ampersand)nbsp;</code> with a non-breaking space, decimal 160</li> <li>Replaces
        /// <code>(ampersand)lt;</code> with a "less than" symbol</li> <li>Replaces <code>(ampersand)gt;</code>
        /// with <code>&gt;</code> </li> <li>Replaces characters that are represented in hexadecimal
        /// format, <code>(ampersand)#xhhhh;</code>, with the corresponding characters</li> <li>Replaces
        /// characters that are represented in decimal format, <code>(ampersand)#nnnn;</code>,
        /// with the corresponding characters</li> </ul> 
        /// <para>
        /// <b>LOWERCASE</b>
        /// </para>
        ///  
        /// <para>
        /// Use this option to convert uppercase letters (A-Z) to lowercase (a-z).
        /// </para>
        ///  
        /// <para>
        /// <b>URL_DECODE</b>
        /// </para>
        ///  
        /// <para>
        /// Use this option to decode a URL-encoded value.
        /// </para>
        ///  
        /// <para>
        /// <b>NONE</b>
        /// </para>
        ///  
        /// <para>
        /// Specify <code>NONE</code> if you don't want to perform any text transformations.
        /// </para>
        /// </summary>
        public TextTransformation TextTransformation
        {
            get { return this._textTransformation; }
            set { this._textTransformation = value; }
        }

        // Check to see if TextTransformation property is set
        internal bool IsSetTextTransformation()
        {
            return this._textTransformation != null;
        }

    }
}