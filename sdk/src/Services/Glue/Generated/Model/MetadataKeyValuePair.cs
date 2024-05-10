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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing a key value pair for metadata.
    /// </summary>
    public partial class MetadataKeyValuePair
    {
        private string _metadataKey;
        private string _metadataValue;

        /// <summary>
        /// Gets and sets the property MetadataKey. 
        /// <para>
        /// A metadata key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string MetadataKey
        {
            get { return this._metadataKey; }
            set { this._metadataKey = value; }
        }

        // Check to see if MetadataKey property is set
        internal bool IsSetMetadataKey()
        {
            return this._metadataKey != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataValue. 
        /// <para>
        /// A metadata key’s corresponding value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MetadataValue
        {
            get { return this._metadataValue; }
            set { this._metadataValue = value; }
        }

        // Check to see if MetadataValue property is set
        internal bool IsSetMetadataValue()
        {
            return this._metadataValue != null;
        }

    }
}