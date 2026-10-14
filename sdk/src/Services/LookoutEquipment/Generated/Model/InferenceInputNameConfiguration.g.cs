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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Specifies configuration information for the input data for the inference, including
    /// timestamp format and delimiter.
    /// </summary>
    public partial class InferenceInputNameConfiguration
    {
        /// <summary>
        /// Gets and sets the property ComponentTimestampDelimiter. 
        /// <para>
        /// Indicates the delimiter character used between items in the data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public string ComponentTimestampDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the ComponentTimestampDelimiter property is set.
        /// </summary>
        internal bool IsSetComponentTimestampDelimiter() => this.ComponentTimestampDelimiter != null;

        /// <summary>
        /// Gets and sets the property TimestampFormat. 
        /// <para>
        /// The format of the timestamp, whether Epoch time, or standard, with or without hyphens
        /// (-). 
        /// </para>
        /// </summary>
        public string TimestampFormat { get; set; }

        /// <summary>
        /// Checks to see if the TimestampFormat property is set.
        /// </summary>
        internal bool IsSetTimestampFormat() => this.TimestampFormat != null;
    }
}
