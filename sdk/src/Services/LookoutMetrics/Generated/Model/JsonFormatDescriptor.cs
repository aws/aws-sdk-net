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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Contains information about how a source JSON data file should be analyzed.
    /// </summary>
    public partial class JsonFormatDescriptor
    {
        private string _charset;
        private JsonFileCompression _fileCompression;

        /// <summary>
        /// Gets and sets the property Charset. 
        /// <para>
        /// The character set in which the source JSON file is written.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string Charset
        {
            get { return this._charset; }
            set { this._charset = value; }
        }

        // Check to see if Charset property is set
        internal bool IsSetCharset()
        {
            return this._charset != null;
        }

        /// <summary>
        /// Gets and sets the property FileCompression. 
        /// <para>
        /// The level of compression of the source CSV file.
        /// </para>
        /// </summary>
        public JsonFileCompression FileCompression
        {
            get { return this._fileCompression; }
            set { this._fileCompression = value; }
        }

        // Check to see if FileCompression property is set
        internal bool IsSetFileCompression()
        {
            return this._fileCompression != null;
        }

    }
}