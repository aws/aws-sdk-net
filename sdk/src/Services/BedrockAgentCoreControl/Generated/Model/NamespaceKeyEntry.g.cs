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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A namespace variable key definition with optional <c>NamespaceKeyValidation</c> rules.
    /// </summary>
    public partial class NamespaceKeyEntry
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The namespace variable key name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// The validation rules that constrain values for this namespace variable at runtime
        /// (<c>CreateEvent</c> API).
        /// </para>
        /// </summary>
        public NamespaceKeyValidation Validation { get; set; }

        /// <summary>
        /// Checks to see if the Validation property is set.
        /// </summary>
        internal bool IsSetValidation() => this.Validation != null;
    }
}
