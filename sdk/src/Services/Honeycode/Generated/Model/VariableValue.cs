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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// The input variables to the app to be used by the InvokeScreenAutomation action request.
    /// </summary>
    public partial class VariableValue
    {
        private string _rawValue;

        /// <summary>
        /// Gets and sets the property RawValue. 
        /// <para>
        /// Raw value of the variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32767)]
        public string RawValue
        {
            get { return this._rawValue; }
            set { this._rawValue = value; }
        }

        // Check to see if RawValue property is set
        internal bool IsSetRawValue()
        {
            return this._rawValue != null;
        }

    }
}