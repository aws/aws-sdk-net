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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents textual data, plus an optional character set specification.
    /// 
    ///  
    /// <para>
    /// By default, the text must be 7-bit ASCII, due to the constraints of the SMTP protocol.
    /// If the text must contain any other characters, then you must also specify a character
    /// set. Examples include UTF-8, ISO-8859-1, and Shift_JIS.
    /// </para>
    /// </summary>
    public partial class Content
    {
        private string _charset;
        private string _data;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Content() { }

        /// <summary>
        /// Instantiates Content with the parameterized properties
        /// </summary>
        /// <param name="data">The textual data of the content.</param>
        public Content(string data)
        {
            _data = data;
        }

        /// <summary>
        /// Gets and sets the property Charset. 
        /// <para>
        /// The character set of the content.
        /// </para>
        /// </summary>
        public string Charset
        {
            get { return this._charset; }
            set { this._charset = value; }
        }

        // Check to see if Charset property is set
        internal bool IsSetCharset()
        {
            return this._charset != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The textual data of the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

    }
}