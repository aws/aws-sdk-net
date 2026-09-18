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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// For <c>SCTE35_ENHANCED</c> output, defines a key and corresponding value. MediaTailor
    /// generates these pairs within the <c>EXT-X-ASSET</c>tag.
    /// </summary>
    public partial class KeyValuePair
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// For <c>SCTE35_ENHANCED</c> output, defines a key. MediaTailor takes this key, and
        /// its associated value, and generates the key/value pair within the <c>EXT-X-ASSET</c>tag.
        /// If you specify a key, you must also specify a corresponding value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// For <c>SCTE35_ENHANCED</c> output, defines a value. MediaTailor; takes this value,
        /// and its associated key, and generates the key/value pair within the <c>EXT-X-ASSET</c>tag.
        /// If you specify a value, you must also specify a corresponding key.
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
