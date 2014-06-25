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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents textual data, plus an optional character set specification.
    /// 
    ///         
    /// <para>
    /// By default, the text must be 7-bit ASCII, due to the constraints of the SMTP protocol.
    /// If the text must            contain any other characters, then you must also specify
    /// a character set. Examples include UTF-8, ISO-8859-1,            and Shift_JIS.   
    ///     
    /// </para>
    /// </summary>
    public partial class Content
    {
        private string _charset;
        private string _data;


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


        /// <summary>
        /// Sets the Charset property
        /// </summary>
        /// <param name="charset">The value to set for the Charset property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Content WithCharset(string charset)
        {
            this._charset = charset;
            return this;
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
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }


        /// <summary>
        /// Sets the Data property
        /// </summary>
        /// <param name="data">The value to set for the Data property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Content WithData(string data)
        {
            this._data = data;
            return this;
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

    }
}