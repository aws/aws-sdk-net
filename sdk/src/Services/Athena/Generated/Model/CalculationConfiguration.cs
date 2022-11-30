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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains configuration information for the calculation.
    /// </summary>
    public partial class CalculationConfiguration
    {
        private string _codeBlock;

        /// <summary>
        /// Gets and sets the property CodeBlock. 
        /// <para>
        /// A string that contains the code for the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=68000)]
        public string CodeBlock
        {
            get { return this._codeBlock; }
            set { this._codeBlock = value; }
        }

        // Check to see if CodeBlock property is set
        internal bool IsSetCodeBlock()
        {
            return this._codeBlock != null;
        }

    }
}