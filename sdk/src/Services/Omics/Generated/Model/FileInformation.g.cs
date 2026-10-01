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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Details about a file.
    /// </summary>
    public partial class FileInformation
    {
        /// <summary>
        /// Gets and sets the property ContentLength. 
        /// <para>
        /// The file's content length.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5497558138880)]
        public long? ContentLength { get; set; }

        /// <summary>
        /// Checks to see if the ContentLength property is set.
        /// </summary>
        internal bool IsSetContentLength() => this.ContentLength.HasValue;

        /// <summary>
        /// Gets and sets the property PartSize. 
        /// <para>
        /// The file's part size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5368709120)]
        public long? PartSize { get; set; }

        /// <summary>
        /// Checks to see if the PartSize property is set.
        /// </summary>
        internal bool IsSetPartSize() => this.PartSize.HasValue;

        /// <summary>
        /// Gets and sets the property S3Access. 
        /// <para>
        /// The S3 URI metadata of a sequence store.
        /// </para>
        /// </summary>
        public ReadSetS3Access S3Access { get; set; }

        /// <summary>
        /// Checks to see if the S3Access property is set.
        /// </summary>
        internal bool IsSetS3Access() => this.S3Access != null;

        /// <summary>
        /// Gets and sets the property TotalParts. 
        /// <para>
        /// The file's total parts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? TotalParts { get; set; }

        /// <summary>
        /// Checks to see if the TotalParts property is set.
        /// </summary>
        internal bool IsSetTotalParts() => this.TotalParts.HasValue;
    }
}
