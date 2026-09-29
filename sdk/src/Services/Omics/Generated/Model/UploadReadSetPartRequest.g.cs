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
    /// Container for the parameters to the UploadReadSetPart operation. Uploads a specific
    /// part of a read set into a sequence store. When you a upload a read set part with a
    /// part number that already exists, the new part replaces the existing one. This operation
    /// returns a JSON formatted response containing a string identifier that is used to confirm
    /// that parts are being added to the intended upload. <para> For more information, see
    /// <a href="https://docs.aws.amazon.com/omics/latest/dev/synchronous-uploads.html">Direct
    /// upload to a sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
    /// </para>
    /// </summary>
    public partial class UploadReadSetPartRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// The number of the part being uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public int? PartNumber { get; set; }

        /// <summary>
        /// Checks to see if the PartNumber property is set.
        /// </summary>
        internal bool IsSetPartNumber() => this.PartNumber.HasValue;

        /// <summary>
        /// Gets and sets the property PartSource. 
        /// <para>
        /// The source file for an upload part.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReadSetPartSource PartSource { get; set; }

        /// <summary>
        /// Checks to see if the PartSource property is set.
        /// </summary>
        internal bool IsSetPartSource() => this.PartSource != null;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The read set data to upload for a part.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Stream Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The Sequence Store ID used for the multipart upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string SequenceStoreId { get; set; }

        /// <summary>
        /// Checks to see if the SequenceStoreId property is set.
        /// </summary>
        internal bool IsSetSequenceStoreId() => this.SequenceStoreId != null;

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The ID for the initiated multipart upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string UploadId { get; set; }

        /// <summary>
        /// Checks to see if the UploadId property is set.
        /// </summary>
        internal bool IsSetUploadId() => this.UploadId != null;
    }
}
