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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A description of the import source that you provide at the start of an import job.
    /// This value is set to either <c>Body</c> or <c>S3Uri</c>, depending on how the <c>StartAssetBundleImportJobRequest</c>
    /// is configured.
    /// </summary>
    public partial class AssetBundleImportSourceDescription
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// An HTTPS download URL for the provided asset bundle that you optionally provided at
        /// the start of the import job. This URL is valid for five minutes after issuance. Call
        /// <c>DescribeAssetBundleExportJob</c> again for a fresh URL if needed. The downloaded
        /// asset bundle is a <c>.qs</c> zip file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 URI that you provided at the start of the import job.
        /// </para>
        /// </summary>
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;
    }
}
