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
    /// Represents the body of the message. You can specify text, HTML, or both. If you use
    /// both, then            the message should display correctly in the widest variety of
    /// email clients.
    /// </summary>
    public partial class Body
    {
        ///// <summary>
        ///// Default constructor for a new Body object.  Callers should use the
        ///// properties to initialize this object after creating it.
        ///// </summary>
        //public Body() { }

        ///// <summary>
        ///// Constructs a new Body object.
        ///// Callers should use the properties initialize any additional object members.
        ///// </summary>
        ///// 
        ///// <param name="text"> The content of the message, in text format. Use this for text-based email clients, or clients on high-latency networks
        ///// (such as mobile devices). </param>
        //public Body(Content text)
        //{
        //    this.Text = text;
        //}
    }
}