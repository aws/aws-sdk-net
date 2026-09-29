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
    /// Container for the parameters to the CompleteMultipartReadSetUpload operation. Completes
    /// a multipart read set upload into a sequence store after you have initiated the upload
    /// process with <c>CreateMultipartReadSetUpload</c> and uploaded all read set parts using
    /// <c>UploadReadSetPart</c>. You must specify the parts you uploaded using the parts
    /// parameter. If the operation is successful, it returns the read set ID(s) of the uploaded
    /// read set(s). <para> For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/synchronous-uploads.html">Direct
    /// upload to a sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CompleteMultipartReadSetUploadRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property Parts. 
        /// <para>
        /// The individual uploads or parts of a multipart upload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<CompleteReadSetUploadPartListItem> Parts { get; set; } = AWSConfigs.InitializeCollections ? new List<CompleteReadSetUploadPartListItem>() : null;

        /// <summary>
        /// Checks to see if the Parts property is set.
        /// </summary>
        internal bool IsSetParts() => this.Parts != null && (this.Parts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The sequence store ID for the store involved in the multipart upload.
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
        /// The ID for the multipart upload.
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
