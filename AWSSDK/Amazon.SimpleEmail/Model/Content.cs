/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents textual data, plus an optional character set specification.</para> <para>By default, the text must be 7-bit ASCII, due to
    /// the constraints of the SMTP protocol. If the text must contain any other characters, then you must also specify a character set. Examples
    /// include UTF-8, ISO-8859-1, and Shift_JIS. </para>
    /// </summary>
    public class Content  
    {
        
        private string data;
        private string charset;
        /// <summary>
        /// Default constructor for a new Content object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public Content() {}
    
        /// <summary>
        /// Constructs a new Content object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="data"> The textual data of the content. </param>
        public Content(string data) 
        {
            this.data = data;
        }
    

        /// <summary>
        /// The textual data of the content.
        ///  
        /// </summary>
        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        /// <summary>
        /// Sets the Data property
        /// </summary>
        /// <param name="data">The value to set for the Data property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Content WithData(string data)
        {
            this.data = data;
            return this;
        }
            

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this.data != null;       
        }

        /// <summary>
        /// The character set of the content.
        ///  
        /// </summary>
        public string Charset
        {
            get { return this.charset; }
            set { this.charset = value; }
        }

        /// <summary>
        /// Sets the Charset property
        /// </summary>
        /// <param name="charset">The value to set for the Charset property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Content WithCharset(string charset)
        {
            this.charset = charset;
            return this;
        }
            

        // Check to see if Charset property is set
        internal bool IsSetCharset()
        {
            return this.charset != null;       
        }
    }
}
