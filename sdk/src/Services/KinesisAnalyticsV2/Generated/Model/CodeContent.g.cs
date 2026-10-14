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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Specifies either the application code, or the location of the application code, for
    /// a Managed Service for Apache Flink application.
    /// </summary>
    public partial class CodeContent
    {
        /// <summary>
        /// Gets and sets the property S3ContentLocation. 
        /// <para>
        /// Information about the Amazon S3 bucket that contains the application code.
        /// </para>
        /// </summary>
        public S3ContentLocation S3ContentLocation { get; set; }

        /// <summary>
        /// Checks to see if the S3ContentLocation property is set.
        /// </summary>
        internal bool IsSetS3ContentLocation() => this.S3ContentLocation != null;

        /// <summary>
        /// Gets and sets the property TextContent. 
        /// <para>
        /// The text-format code for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 102400)]
        public string TextContent { get; set; }

        /// <summary>
        /// Checks to see if the TextContent property is set.
        /// </summary>
        internal bool IsSetTextContent() => this.TextContent != null;

        /// <summary>
        /// Gets and sets the property ZipFileContent. 
        /// <para>
        /// The zip-format code for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 52428800)]
        public MemoryStream ZipFileContent { get; set; }

        /// <summary>
        /// Checks to see if the ZipFileContent property is set.
        /// </summary>
        internal bool IsSetZipFileContent() => this.ZipFileContent != null;
    }
}
