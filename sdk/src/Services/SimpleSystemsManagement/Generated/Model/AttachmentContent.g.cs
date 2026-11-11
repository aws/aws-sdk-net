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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A structure that includes attributes that describe a document attachment.
    /// </summary>
    public partial class AttachmentContent
    {
        /// <summary>
        /// Gets and sets the property Hash. 
        /// <para>
        /// The cryptographic hash value of the document content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Hash { get; set; }

        /// <summary>
        /// Checks to see if the Hash property is set.
        /// </summary>
        internal bool IsSetHash() => this.Hash != null;

        /// <summary>
        /// Gets and sets the property HashType. 
        /// <para>
        /// The hash algorithm used to calculate the hash value.
        /// </para>
        /// </summary>
        public AttachmentHashType HashType { get; set; }

        /// <summary>
        /// Checks to see if the HashType property is set.
        /// </summary>
        internal bool IsSetHashType() => this.HashType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of an attachment.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of an attachment in bytes.
        /// </para>
        /// </summary>
        public long? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL location of the attachment content.
        /// </para>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
