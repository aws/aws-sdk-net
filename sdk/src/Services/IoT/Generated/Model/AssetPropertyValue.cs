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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// An asset property value entry containing the following information.
    /// </summary>
    public partial class AssetPropertyValue
    {
        private string _quality;
        private AssetPropertyTimestamp _timestamp;
        private AssetPropertyVariant _value;

        /// <summary>
        /// Gets and sets the property Quality. 
        /// <para>
        /// Optional. A string that describes the quality of the value. Accepts substitution templates.
        /// Must be <c>GOOD</c>, <c>BAD</c>, or <c>UNCERTAIN</c>.
        /// </para>
        /// </summary>
        public string Quality
        {
            get { return this._quality; }
            set { this._quality = value; }
        }

        // Check to see if Quality property is set
        internal bool IsSetQuality()
        {
            return this._quality != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The asset property value timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetPropertyTimestamp Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the asset property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetPropertyVariant Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}