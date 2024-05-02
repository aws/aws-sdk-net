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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
        private string _componentTimestampDelimiter;
        private string _timestampFormat;

        /// <summary>
        /// Gets and sets the property ComponentTimestampDelimiter. 
        /// <para>
        /// Indicates the delimiter character used between items in the data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public string ComponentTimestampDelimiter
        {
            get { return this._componentTimestampDelimiter; }
            set { this._componentTimestampDelimiter = value; }
        }

        // Check to see if ComponentTimestampDelimiter property is set
        internal bool IsSetComponentTimestampDelimiter()
        {
            return this._componentTimestampDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampFormat. 
        /// <para>
        /// The format of the timestamp, whether Epoch time, or standard, with or without hyphens
        /// (-). 
        /// </para>
        /// </summary>
        public string TimestampFormat
        {
            get { return this._timestampFormat; }
            set { this._timestampFormat = value; }
        }

        // Check to see if TimestampFormat property is set
        internal bool IsSetTimestampFormat()
        {
            return this._timestampFormat != null;
        }

    }
}