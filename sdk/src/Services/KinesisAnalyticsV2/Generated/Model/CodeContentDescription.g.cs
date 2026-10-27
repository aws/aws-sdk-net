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
    /// Describes details about the code of a Managed Service for Apache Flink application.
    /// </summary>
    public partial class CodeContentDescription
    {
        /// <summary>
        /// Gets and sets the property CodeMD5. 
        /// <para>
        /// The checksum that can be used to validate zip-format code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 128, Max = 128)]
        public string CodeMD5 { get; set; }

        /// <summary>
        /// Checks to see if the CodeMD5 property is set.
        /// </summary>
        internal bool IsSetCodeMD5() => this.CodeMD5 != null;

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size in bytes of the application code. Can be used to validate zip-format code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 52428800)]
        public long? CodeSize { get; set; }

        /// <summary>
        /// Checks to see if the CodeSize property is set.
        /// </summary>
        internal bool IsSetCodeSize() => this.CodeSize.HasValue;

        /// <summary>
        /// Gets and sets the property S3ApplicationCodeLocationDescription. 
        /// <para>
        /// The S3 bucket Amazon Resource Name (ARN), file key, and object version of the application
        /// code stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3ApplicationCodeLocationDescription S3ApplicationCodeLocationDescription { get; set; }

        /// <summary>
        /// Checks to see if the S3ApplicationCodeLocationDescription property is set.
        /// </summary>
        internal bool IsSetS3ApplicationCodeLocationDescription() => this.S3ApplicationCodeLocationDescription != null;

        /// <summary>
        /// Gets and sets the property TextContent. 
        /// <para>
        /// The text-format code
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 102400)]
        public string TextContent { get; set; }

        /// <summary>
        /// Checks to see if the TextContent property is set.
        /// </summary>
        internal bool IsSetTextContent() => this.TextContent != null;
    }
}
