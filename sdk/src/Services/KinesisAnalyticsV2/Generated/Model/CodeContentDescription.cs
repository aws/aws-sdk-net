/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes details about the application code for a Java-based Kinesis Data Analytics
    /// application.
    /// </summary>
    public partial class CodeContentDescription
    {
        private string _codeMD5;
        private long? _codeSize;
        private S3ApplicationCodeLocationDescription _s3ApplicationCodeLocationDescription;
        private string _textContent;

        /// <summary>
        /// Gets and sets the property CodeMD5. 
        /// <para>
        /// The checksum that can be used to validate zip-format code.
        /// </para>
        /// </summary>
        public string CodeMD5
        {
            get { return this._codeMD5; }
            set { this._codeMD5 = value; }
        }

        // Check to see if CodeMD5 property is set
        internal bool IsSetCodeMD5()
        {
            return this._codeMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size in bytes of the application code. Can be used to validate zip-format code.
        /// </para>
        /// </summary>
        public long CodeSize
        {
            get { return this._codeSize.GetValueOrDefault(); }
            set { this._codeSize = value; }
        }

        // Check to see if CodeSize property is set
        internal bool IsSetCodeSize()
        {
            return this._codeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3ApplicationCodeLocationDescription. 
        /// <para>
        /// The S3 bucket Amazon Resource Name (ARN), file key, and object version of the application
        /// code stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3ApplicationCodeLocationDescription S3ApplicationCodeLocationDescription
        {
            get { return this._s3ApplicationCodeLocationDescription; }
            set { this._s3ApplicationCodeLocationDescription = value; }
        }

        // Check to see if S3ApplicationCodeLocationDescription property is set
        internal bool IsSetS3ApplicationCodeLocationDescription()
        {
            return this._s3ApplicationCodeLocationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TextContent. 
        /// <para>
        /// The text-format code
        /// </para>
        /// </summary>
        public string TextContent
        {
            get { return this._textContent; }
            set { this._textContent = value; }
        }

        // Check to see if TextContent property is set
        internal bool IsSetTextContent()
        {
            return this._textContent != null;
        }

    }
}