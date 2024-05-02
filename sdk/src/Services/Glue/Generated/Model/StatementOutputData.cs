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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The code execution output in JSON format.
    /// </summary>
    public partial class StatementOutputData
    {
        private string _textPlain;

        /// <summary>
        /// Gets and sets the property TextPlain. 
        /// <para>
        /// The code execution output in text format.
        /// </para>
        /// </summary>
        public string TextPlain
        {
            get { return this._textPlain; }
            set { this._textPlain = value; }
        }

        // Check to see if TextPlain property is set
        internal bool IsSetTextPlain()
        {
            return this._textPlain != null;
        }

    }
}