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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
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
namespace Amazon.BCMDataExports.Model
{
    /// <summary>
    /// The compression type, file format, and overwrite preference for the data export.
    /// </summary>
    public partial class S3OutputConfigurations
    {
        private CompressionOption _compression;
        private FormatOption _format;
        private S3OutputType _outputType;
        private OverwriteOption _overwrite;

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// The compression type for the data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CompressionOption Compression
        {
            get { return this._compression; }
            set { this._compression = value; }
        }

        // Check to see if Compression property is set
        internal bool IsSetCompression()
        {
            return this._compression != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The file format for the data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FormatOption Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property OutputType. 
        /// <para>
        /// The output type for the data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3OutputType OutputType
        {
            get { return this._outputType; }
            set { this._outputType = value; }
        }

        // Check to see if OutputType property is set
        internal bool IsSetOutputType()
        {
            return this._outputType != null;
        }

        /// <summary>
        /// Gets and sets the property Overwrite. 
        /// <para>
        /// The rule to follow when generating a version of the data export file. You have the
        /// choice to overwrite the previous version or to be delivered in addition to the previous
        /// versions. Overwriting exports can save on Amazon S3 storage costs. Creating new export
        /// versions allows you to track the changes in cost and usage data over time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OverwriteOption Overwrite
        {
            get { return this._overwrite; }
            set { this._overwrite = value; }
        }

        // Check to see if Overwrite property is set
        internal bool IsSetOverwrite()
        {
            return this._overwrite != null;
        }

    }
}