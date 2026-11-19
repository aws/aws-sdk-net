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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// A reference to a partner-supplied file in the Partner Central file staging bucket.
    /// 
    /// &lt;para&gt;
    /// The URI must be `s3://{stagingBucket}/{callerAccountId}/…`, where the account id segment
    /// equals the caller's session-derived account — never an account named in the request
    /// body. A mismatch is refused `FILE_REFERENCE_NOT_OWNED`; any other bucket, `FILE_REFERENCE_INVALID`.
    /// 
    /// &lt;para&gt;
    /// `VersionId` is required: the staging bucket is versioned, and the service takes exactly
    /// the version the upload returned, so a later upload to the same key cannot change what
    /// was referenced. The service copies that version into storage it controls and pins
    /// the copy for scanning and processing.
    /// </summary>
    public partial class FileRef
    {
        /// <summary>
        /// Gets and sets the property S3Uri. The `s3://` location of the file.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;

        /// <summary>
        /// Gets and sets the property VersionId. The version of the object to take: the `VersionId`
        /// the staging upload returned.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
