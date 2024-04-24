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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// A batch job definition contained in a script.
    /// </summary>
    public partial class ScriptBatchJobDefinition
    {
        private string _scriptName;

        /// <summary>
        /// Gets and sets the property ScriptName. 
        /// <para>
        /// The name of the script containing the batch job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScriptName
        {
            get { return this._scriptName; }
            set { this._scriptName = value; }
        }

        // Check to see if ScriptName property is set
        internal bool IsSetScriptName()
        {
            return this._scriptName != null;
        }

    }
}