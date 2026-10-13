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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// A pre-formed Amazon SageMaker model input you can include if your detector version
    /// includes an imported Amazon SageMaker model endpoint with pass-through input configuration.
    /// </summary>
    public partial class ModelEndpointDataBlob
    {
        /// <summary>
        /// Gets and sets the property ByteBuffer. 
        /// <para>
        /// The byte buffer of the Amazon SageMaker model endpoint input data blob.
        /// </para>
        /// </summary>
        public MemoryStream ByteBuffer { get; set; }

        /// <summary>
        /// Checks to see if the ByteBuffer property is set.
        /// </summary>
        internal bool IsSetByteBuffer() => this.ByteBuffer != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the Amazon SageMaker model endpoint input data blob. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;
    }
}
