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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Text transformations eliminate some of the unusual formatting that attackers use in
    /// web requests in an effort to bypass detection.
    /// </summary>
    public partial class TextTransformation
    {
        private int? _priority;
        private TextTransformationType _type;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Sets the relative processing order for multiple transformations. WAF processes all
        /// transformations, from lowest priority to highest, before inspecting the transformed
        /// content. The priorities don't need to be consecutive, but they must all be different.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// You can specify the following transformation types:
        /// </para>
        ///  
        /// <para>
        ///  <b>BASE64_DECODE</b> - Decode a <code>Base64</code>-encoded string.
        /// </para>
        ///  
        /// <para>
        ///  <b>BASE64_DECODE_EXT</b> - Decode a <code>Base64</code>-encoded string, but use a
        /// forgiving implementation that ignores characters that aren't valid.
        /// </para>
        ///  
        /// <para>
        ///  <b>CMD_LINE</b> - Command-line transformations. These are helpful in reducing effectiveness
        /// of attackers who inject an operating system command-line command and use unusual formatting
        /// to disguise some or all of the command. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Delete the following characters: <code>\ " ' ^</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete spaces before the following characters: <code>/ (</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replace the following characters with a space: <code>, ;</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replace multiple spaces with one space
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Convert uppercase letters (A-Z) to lowercase (a-z)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>COMPRESS_WHITE_SPACE</b> - Replace these characters with a space character (decimal
        /// 32): 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>\f</code>, formfeed, decimal 12
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>\t</code>, tab, decimal 9
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>\n</code>, newline, decimal 10
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>\r</code>, carriage return, decimal 13
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>\v</code>, vertical tab, decimal 11
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Non-breaking space, decimal 160
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>COMPRESS_WHITE_SPACE</code> also replaces multiple spaces with one space.
        /// </para>
        ///  
        /// <para>
        ///  <b>CSS_DECODE</b> - Decode characters that were encoded using CSS 2.x escape rules
        /// <code>syndata.html#characters</code>. This function uses up to two bytes in the decoding
        /// process, so it can help to uncover ASCII characters that were encoded using CSS encoding
        /// that wouldn’t typically be encoded. It's also useful in countering evasion, which
        /// is a combination of a backslash and non-hexadecimal characters. For example, <code>ja\vascript</code>
        /// for javascript. 
        /// </para>
        ///  
        /// <para>
        ///  <b>ESCAPE_SEQ_DECODE</b> - Decode the following ANSI C escape sequences: <code>\a</code>,
        /// <code>\b</code>, <code>\f</code>, <code>\n</code>, <code>\r</code>, <code>\t</code>,
        /// <code>\v</code>, <code>\\</code>, <code>\?</code>, <code>\'</code>, <code>\"</code>,
        /// <code>\xHH</code> (hexadecimal), <code>\0OOO</code> (octal). Encodings that aren't
        /// valid remain in the output. 
        /// </para>
        ///  
        /// <para>
        ///  <b>HEX_DECODE</b> - Decode a string of hexadecimal characters into a binary.
        /// </para>
        ///  
        /// <para>
        ///  <b>HTML_ENTITY_DECODE</b> - Replace HTML-encoded characters with unencoded characters.
        /// <code>HTML_ENTITY_DECODE</code> performs these operations: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Replaces <code>(ampersand)quot;</code> with <code>"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces <code>(ampersand)nbsp;</code> with a non-breaking space, decimal 160
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces <code>(ampersand)lt;</code> with a "less than" symbol
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces <code>(ampersand)gt;</code> with <code>&gt;</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces characters that are represented in hexadecimal format, <code>(ampersand)#xhhhh;</code>,
        /// with the corresponding characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces characters that are represented in decimal format, <code>(ampersand)#nnnn;</code>,
        /// with the corresponding characters
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>JS_DECODE</b> - Decode JavaScript escape sequences. If a <code>\</code> <code>u</code>
        /// <code>HHHH</code> code is in the full-width ASCII code range of <code>FF01-FF5E</code>,
        /// then the higher byte is used to detect and adjust the lower byte. If not, only the
        /// lower byte is used and the higher byte is zeroed, causing a possible loss of information.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>LOWERCASE</b> - Convert uppercase letters (A-Z) to lowercase (a-z). 
        /// </para>
        ///  
        /// <para>
        ///  <b>MD5</b> - Calculate an MD5 hash from the data in the input. The computed hash
        /// is in a raw binary form. 
        /// </para>
        ///  
        /// <para>
        ///  <b>NONE</b> - Specify <code>NONE</code> if you don't want any text transformations.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>NORMALIZE_PATH</b> - Remove multiple slashes, directory self-references, and directory
        /// back-references that are not at the beginning of the input from an input string. 
        /// </para>
        ///  
        /// <para>
        ///  <b>NORMALIZE_PATH_WIN</b> - This is the same as <code>NORMALIZE_PATH</code>, but
        /// first converts backslash characters to forward slashes. 
        /// </para>
        ///  
        /// <para>
        ///  <b>REMOVE_NULLS</b> - Remove all <code>NULL</code> bytes from the input. 
        /// </para>
        ///  
        /// <para>
        ///  <b>REPLACE_COMMENTS</b> - Replace each occurrence of a C-style comment (<code>/*
        /// ... */</code>) with a single space. Multiple consecutive occurrences are not compressed.
        /// Unterminated comments are also replaced with a space (ASCII 0x20). However, a standalone
        /// termination of a comment (<code>*/</code>) is not acted upon. 
        /// </para>
        ///  
        /// <para>
        ///  <b>REPLACE_NULLS</b> - Replace NULL bytes in the input with space characters (ASCII
        /// <code>0x20</code>). 
        /// </para>
        ///  
        /// <para>
        ///  <b>SQL_HEX_DECODE</b> - Decode SQL hex data. Example (<code>0x414243</code>) will
        /// be decoded to (<code>ABC</code>).
        /// </para>
        ///  
        /// <para>
        ///  <b>URL_DECODE</b> - Decode a URL-encoded value. 
        /// </para>
        ///  
        /// <para>
        ///  <b>URL_DECODE_UNI</b> - Like <code>URL_DECODE</code>, but with support for Microsoft-specific
        /// <code>%u</code> encoding. If the code is in the full-width ASCII code range of <code>FF01-FF5E</code>,
        /// the higher byte is used to detect and adjust the lower byte. Otherwise, only the lower
        /// byte is used and the higher byte is zeroed. 
        /// </para>
        ///  
        /// <para>
        ///  <b>UTF8_TO_UNICODE</b> - Convert all UTF-8 character sequences to Unicode. This helps
        /// input normalization, and minimizing false-positives and false-negatives for non-English
        /// languages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TextTransformationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}