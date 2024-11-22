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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
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
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// The definition of the command to run when invoked as an alias or as an action button.
    /// </summary>
    public partial class CustomActionDefinition
    {
        private string _commandText;

        /// <summary>
        /// Gets and sets the property CommandText. 
        /// <para>
        /// The command string to run which may include variables by prefixing with a dollar sign
        /// ($).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CommandText
        {
            get { return this._commandText; }
            set { this._commandText = value; }
        }

        // Check to see if CommandText property is set
        internal bool IsSetCommandText()
        {
            return this._commandText != null;
        }

    }
}