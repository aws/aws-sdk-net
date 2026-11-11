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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// A list of the part sizes of the multipart upload.
    /// </summary>
    public partial class PartListElement
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public PartListElement() { }

        /// <summary>
        /// Gets and sets the property RangeInBytes. 
        /// <para>
        /// The byte range of a part, inclusive of the upper value of the range.
        /// </para>
        /// </summary>
        public string RangeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the RangeInBytes property is set.
        /// </summary>
        internal bool IsSetRangeInBytes() => this.RangeInBytes != null;

        /// <summary>
        /// Gets and sets the property SHA256TreeHash. 
        /// <para>
        /// The SHA256 tree hash value that Amazon Glacier calculated for the part. This field
        /// is never <c>null</c>.
        /// </para>
        /// </summary>
        public string SHA256TreeHash { get; set; }

        /// <summary>
        /// Checks to see if the SHA256TreeHash property is set.
        /// </summary>
        internal bool IsSetSHA256TreeHash() => this.SHA256TreeHash != null;
    }
}
