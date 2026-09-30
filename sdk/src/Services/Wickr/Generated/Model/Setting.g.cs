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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Represents a single network-level configuration setting with its name, value, and
    /// data type. Settings control network-wide behaviors and features.
    /// </summary>
    public partial class Setting
    {
        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        /// The name of the network setting (e.g., 'enableClientMetrics', 'dataRetention').
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OptionName { get; set; }

        /// <summary>
        /// Checks to see if the OptionName property is set.
        /// </summary>
        internal bool IsSetOptionName() => this.OptionName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the setting value (e.g., 'boolean', 'string', 'number').
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The current value of the setting as a string. Boolean values are represented as 'true'
        /// or 'false'.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
