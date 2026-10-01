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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The unique external source of the content contained in the wrapper object.
    /// </summary>
    public partial class ExternalSource
    {
        /// <summary>
        /// Gets and sets the property ByteContent. 
        /// <para>
        /// The identifier, content type, and data of the external source wrapper object.
        /// </para>
        /// </summary>
        public ByteContentDoc ByteContent { get; set; }

        /// <summary>
        /// Checks to see if the ByteContent property is set.
        /// </summary>
        internal bool IsSetByteContent() => this.ByteContent != null;

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The S3 location of the external source wrapper object.
        /// </para>
        /// </summary>
        public S3ObjectDoc S3Location { get; set; }

        /// <summary>
        /// Checks to see if the S3Location property is set.
        /// </summary>
        internal bool IsSetS3Location() => this.S3Location != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the external source wrapper object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExternalSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
