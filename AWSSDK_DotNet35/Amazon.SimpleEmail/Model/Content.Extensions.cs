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
        ///// <summary>
        ///// Default constructor for a new Content object.  Callers should use the
        ///// properties to initialize this object after creating it.
        ///// </summary>
        //public Content() { }

        ///// <summary>
        ///// Constructs a new Content object.
        ///// Callers should use the properties initialize any additional object members.
        ///// </summary>
        ///// 
        ///// <param name="data"> The textual data of the content. </param>
        //public Content(string data)
        //{
        //    this.Data = data;
        //}

    }
}