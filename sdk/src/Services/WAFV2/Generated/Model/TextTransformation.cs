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
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Text transformations eliminate some of the unusual formatting that attackers use in
    /// web requests in an effort to bypass detection. 
    /// </para>
    /// </summary>
    public partial class TextTransformation
    {
        private int? _priority;
        private TextTransformationType _type;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Sets the relative processing order for multiple transformations that are defined for
        /// a rule statement. AWS WAF processes all transformations, from lowest priority to highest,
        /// before inspecting the transformed content. The priorities don't need to be consecutive,
        /// but they must all be different. 
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
        ///  <b>CMD_LINE</b> 
        /// </para>
        ///  
        /// <para>
        /// When you're concerned that attackers are injecting an operating system command line
        /// command and using unusual formatting to disguise some or all of the command, use this
        /// option to perform the following transformations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Delete the following characters: \ " ' ^
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete spaces before the following characters: / (
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replace the following characters with a space: , ;
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
        ///  <b>COMPRESS_WHITE_SPACE</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this option to replace the following characters with a space character (decimal
        /// 32):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// \f, formfeed, decimal 12
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// \t, tab, decimal 9
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// \n, newline, decimal 10
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// \r, carriage return, decimal 13
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// \v, vertical tab, decimal 11
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// non-breaking space, decimal 160
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>COMPRESS_WHITE_SPACE</code> also replaces multiple spaces with one space.
        /// </para>
        ///  
        /// <para>
        ///  <b>HTML_ENTITY_DECODE</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this option to replace HTML-encoded characters with unencoded characters. <code>HTML_ENTITY_DECODE</code>
        /// performs the following operations:
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
        ///  <b>LOWERCASE</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this option to convert uppercase letters (A-Z) to lowercase (a-z).
        /// </para>
        ///  
        /// <para>
        ///  <b>URL_DECODE</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this option to decode a URL-encoded value.
        /// </para>
        ///  
        /// <para>
        ///  <b>NONE</b> 
        /// </para>
        ///  
        /// <para>
        /// Specify <code>NONE</code> if you don't want any text transformations.
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