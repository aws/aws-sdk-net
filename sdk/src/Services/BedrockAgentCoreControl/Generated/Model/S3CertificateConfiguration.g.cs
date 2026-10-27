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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A reference to a PEM-encoded private CA certificate stored as an Amazon S3 object.
    /// </summary>
    public partial class S3CertificateConfiguration
    {
        /// <summary>
        /// Gets and sets the property BucketOwnerAccountId. 
        /// <para>
        /// The account ID of the Amazon S3 bucket owner. This ID is used for cross-account access
        /// to the bucket.
        /// </para>
        /// </summary>
        public string BucketOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the BucketOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetBucketOwnerAccountId() => this.BucketOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The URI of the Amazon S3 object that contains the PEM-encoded certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;
    }
}
