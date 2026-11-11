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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The progress of a multipart attachment upload, returned by <a>DescribeAttachmentUploadStatus</a>.
    /// </summary>
    public partial class UploadProgress
    {
        /// <summary>
        /// Gets and sets the property CompletedPartsCount. 
        /// <para>
        /// The number of parts that have been successfully uploaded.
        /// </para>
        /// </summary>
        public int? CompletedPartsCount { get; set; }

        /// <summary>
        /// Checks to see if the CompletedPartsCount property is set.
        /// </summary>
        internal bool IsSetCompletedPartsCount() => this.CompletedPartsCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalParts. 
        /// <para>
        /// The total number of parts that the file is split into.
        /// </para>
        /// </summary>
        public int? TotalParts { get; set; }

        /// <summary>
        /// Checks to see if the TotalParts property is set.
        /// </summary>
        internal bool IsSetTotalParts() => this.TotalParts.HasValue;
    }
}
