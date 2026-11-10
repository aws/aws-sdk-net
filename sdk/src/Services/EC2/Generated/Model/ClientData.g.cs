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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the client-specific data.
    /// </summary>
    public partial class ClientData
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A user-defined comment about the disk upload.
        /// </para>
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property UploadEnd. 
        /// <para>
        /// The time that the disk upload ends.
        /// </para>
        /// </summary>
        public DateTime? UploadEnd { get; set; }

        /// <summary>
        /// Checks to see if the UploadEnd property is set.
        /// </summary>
        internal bool IsSetUploadEnd() => this.UploadEnd.HasValue;

        /// <summary>
        /// Gets and sets the property UploadSize. 
        /// <para>
        /// The size of the uploaded disk image, in GiB.
        /// </para>
        /// </summary>
        public double? UploadSize { get; set; }

        /// <summary>
        /// Checks to see if the UploadSize property is set.
        /// </summary>
        internal bool IsSetUploadSize() => this.UploadSize.HasValue;

        /// <summary>
        /// Gets and sets the property UploadStart. 
        /// <para>
        /// The time that the disk upload starts.
        /// </para>
        /// </summary>
        public DateTime? UploadStart { get; set; }

        /// <summary>
        /// Checks to see if the UploadStart property is set.
        /// </summary>
        internal bool IsSetUploadStart() => this.UploadStart.HasValue;
    }
}
