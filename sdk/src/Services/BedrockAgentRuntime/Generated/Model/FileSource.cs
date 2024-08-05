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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The source file of the content contained in the wrapper object.
    /// </summary>
    public partial class FileSource
    {
        private ByteContentFile _byteContent;
        private S3ObjectFile _s3Location;
        private FileSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property ByteContent. 
        /// <para>
        /// The data and the text of the attached files.
        /// </para>
        /// </summary>
        public ByteContentFile ByteContent
        {
            get { return this._byteContent; }
            set { this._byteContent = value; }
        }

        // Check to see if ByteContent property is set
        internal bool IsSetByteContent()
        {
            return this._byteContent != null;
        }

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The s3 location of the files to attach.
        /// </para>
        /// </summary>
        public S3ObjectFile S3Location
        {
            get { return this._s3Location; }
            set { this._s3Location = value; }
        }

        // Check to see if S3Location property is set
        internal bool IsSetS3Location()
        {
            return this._s3Location != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the files to attach.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}