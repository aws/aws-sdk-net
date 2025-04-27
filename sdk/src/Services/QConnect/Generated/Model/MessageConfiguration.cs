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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The configuration for a <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_amazon-q-connect_SendMessage.html">SendMessage</a>
    /// request.
    /// </summary>
    public partial class MessageConfiguration
    {
        private bool? _generateFillerMessage;

        /// <summary>
        /// Gets and sets the property GenerateFillerMessage. 
        /// <para>
        /// Generates a filler response when tool selection is <c>QUESTION</c>.
        /// </para>
        /// </summary>
        public bool? GenerateFillerMessage
        {
            get { return this._generateFillerMessage; }
            set { this._generateFillerMessage = value; }
        }

        // Check to see if GenerateFillerMessage property is set
        internal bool IsSetGenerateFillerMessage()
        {
            return this._generateFillerMessage.HasValue; 
        }

    }
}